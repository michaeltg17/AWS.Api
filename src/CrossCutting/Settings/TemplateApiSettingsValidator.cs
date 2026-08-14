using Microsoft.Extensions.Options;

namespace CrossCutting.Settings
{
    internal class AWSApiSettingsValidator : IValidateOptions<AWSApiSettings>
    {
        public ValidateOptionsResult Validate(string? name, AWSApiSettings awsApiSettings)
        {
            var validationErrors = new List<string>();

            if (string.IsNullOrWhiteSpace(awsApiSettings.PostgreSqlConnectionString))
                validationErrors.Add($"The '{nameof(awsApiSettings.PostgreSqlConnectionString)}' setting is required");

            if (awsApiSettings.ImageApiUrl is null or { IsAbsoluteUri: false })
                validationErrors.Add($"The '{nameof(awsApiSettings.ImageApiUrl)}' setting is required");

            if (string.IsNullOrWhiteSpace(awsApiSettings.ImageApiKey))
                validationErrors.Add($"The '{nameof(awsApiSettings.ImageApiKey)}' setting is required");

            return validationErrors.Count > 0 ? ValidateOptionsResult.Fail(validationErrors) : ValidateOptionsResult.Success;
        }
    }
}