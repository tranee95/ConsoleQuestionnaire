using Microsoft.Extensions.Configuration;
using Serilog;

namespace ConsoleQuestionnaire.Managers
{
    public static class LoggerManager
    {
        public static void Build(IConfigurationBuilder builder)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();
        }
    }
}
