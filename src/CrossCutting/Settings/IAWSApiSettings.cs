namespace CrossCutting.Settings
{
    public interface IAWSApiSettings
    {
        public const string Section = "AWSApi";
        public string PostgreSqlConnectionString { get; }
        public Uri ImageApiUrl { get; }
        public string ImageApiKey { get; }
        public long MaxImageSizeMb { get; }
        public IEnumerable<string> AllowedImageExtensions { get; }
    }
}