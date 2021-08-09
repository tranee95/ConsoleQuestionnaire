using ConsoleQuestionnaire.Commands.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace ConsoleQuestionnaire.Commands.Receivers
{
    public class Receiver : IReceiver
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<Receiver> _logger;

        public Receiver(IConfiguration configuration, ILogger<Receiver> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public void ShowHelp(List<ICommand> commands)
        {
            foreach (var command in commands)
            {
                var prefx = _configuration["CommandPrefix"];
                Console.WriteLine($"{prefx}{command.Name}: {command.Description}");
            }

            _logger.LogInformation("Command complite!");
        }

        public void CreateProfile()
        {
            throw new NotImplementedException();
        }
    }
}
