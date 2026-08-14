using CrossCutting.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CrossCutting
{
    public static class DependencyConfigurator
    {
        public static IServiceCollection AddCrossCuttingDependencies(this IServiceCollection services)
        {
            services
                .AddOptionsWithValidateOnStart<AWSApiSettings>()
                .BindConfiguration(IAWSApiSettings.Section);

            services.AddSingleton<IValidateOptions<AWSApiSettings>, AWSApiSettingsValidator>();

            services.AddSingleton<IAWSApiSettings>(sp => sp.GetRequiredService<IOptions<AWSApiSettings>>().Value);

            return services;
        }
    }
}