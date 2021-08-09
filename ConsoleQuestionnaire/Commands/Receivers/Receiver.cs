using ConsoleQuestionnaire.Commands.Interfaces;
using ConsoleQuestionnaire.Models;
using ConsoleQuestionnaire.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleQuestionnaire.Commands.Receivers
{
    public class Receiver : IReceiver
    {
        private readonly IConfiguration _configuration;
        private readonly IConsoleService _consoleService;
        private readonly ILogger<Receiver> _logger;

        public Receiver(
            IConfiguration configuration,
            IConsoleService consoleService,
            ILogger<Receiver> logger)
        {
            _configuration = configuration;
            _consoleService = consoleService;
            _logger = logger;
        }

        public void ShowHelp(List<ICommand> commands)
        {
            var prefx = _configuration["CommandPrefix"];
            var lines = commands.Select(s => $"{prefx}{s.Name}: {s.Description}");

            _consoleService.WriteLines(lines);
            _logger.LogInformation("Command complite!");
        }

        public void CreateProfile()
        {
            var profile = _consoleService.AskQuestions(new Questionnaire());
        }
    }
}
