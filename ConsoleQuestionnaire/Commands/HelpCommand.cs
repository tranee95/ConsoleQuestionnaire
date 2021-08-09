using ConsoleQuestionnaire.Commands.Interfaces;
using ConsoleQuestionnaire.Commands.Receivers;

namespace ConsoleQuestionnaire.Commands
{
    public class HelpCommand : ICommand
    {
        private readonly IReceiver _receiver;
        private readonly ICommandsGroup _commandsGroup;

        public HelpCommand(ICommandsGroup commandsGroup, IReceiver receiver)
        {
            _receiver = receiver;
            _commandsGroup = commandsGroup;
        }

        public string Name => "help";
        public string Description => "Показать список доступных команд с описанием";
        public void Execute() => _receiver.ShowHelp(_commandsGroup.GetAllCommands());
    }
}
