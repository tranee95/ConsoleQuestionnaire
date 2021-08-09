using ConsoleQuestionnaire.Commands;
using ConsoleQuestionnaire.Managers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleQuestionnaire
{
    public class Program
    {
        static void Main(string[] args)
        {
            var configuration = ConfigurationManager.Build();
            var host = ServiceManager.Build();
            var instance = ActivatorUtilities.CreateInstance<CommandsGroup>(host.Services);
            
            LoggerManager.Build(configuration);
            
            while (true)
            {
                Console.Write("Выберите действие > ");
                instance.FindAndExecute(Console.ReadLine());
                Console.WriteLine(string.Empty);
            }
        }
    }
}
