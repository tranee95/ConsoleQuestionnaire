using ConsoleQuestionnaire.Commands.Interfaces;
using ConsoleQuestionnaire.Commands.Receivers;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleQuestionnaire.Commands
{
    public class CommandsGroup : ICommandsGroup
    {
        private readonly List<ICommand> _commands;

        public CommandsGroup(IReceiver receiver)
        {
            _commands = new List<ICommand>
            {
                new HelpCommand(this, receiver),
                new NewProfileCommand(receiver)
            };
        }

        private bool TryGetCommand(string commandName, out ICommand command)
        {
            command = _commands.FirstOrDefault(s => s.Name.Equals(commandName));
            return command is not null;
        }

        public void FindAndExecute(string commandName)
        {
            if (TryGetCommand(commandName, out var command))
            {
                command.Execute();
            }
        }

        public List<ICommand> GetAllCommands() => _commands;
    }
}
