using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ConsoleQuestionnaire.Managers
{
    public static class ConfigurationManager
    {
        public static IConfigurationBuilder Build()
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true)
                 .AddJsonFile($"appsettings.{env}.json", true, true)
                 .AddEnvironmentVariables();
        }
    }
}
