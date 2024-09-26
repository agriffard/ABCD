namespace ABCD.App.Configuration
{
    public static class SerilogConfiguration
    {
        public static Serilog.Core.Logger AddSerilog(this WebApplicationBuilder builder)
        {
            // build logger configuration
            var loggerConfiguration = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration);

            // create logger instance
            var logger = loggerConfiguration.CreateLogger();

            // Register the logger
            builder.Host.UseSerilog(logger);

            return logger;
        }
    }
}
