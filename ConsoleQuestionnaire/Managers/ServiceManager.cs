using ConsoleQuestionnaire.Commands;
using ConsoleQuestionnaire.Commands.Interfaces;
using ConsoleQuestionnaire.Commands.Receivers;
using ConsoleQuestionnaire.Service;
using ConsoleQuestionnaire.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace ConsoleQuestionnaire.Managers
{
    public static class ServiceManager
    {
        public static IHost Build()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(service =>
                {
                    service.AddTransient<ICommandsGroup, CommandsGroup>();
                    service.AddTransient<IReceiver, Receiver>();
                    service.AddTransient<IConsoleService, ConsoleService>();
                })
                .UseSerilog()
                .Build();

            return host;
        }
    }
}
