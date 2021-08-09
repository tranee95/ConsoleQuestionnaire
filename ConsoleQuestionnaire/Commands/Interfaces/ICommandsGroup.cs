using System.Collections.Generic;

namespace ConsoleQuestionnaire.Commands.Interfaces
{
    public interface ICommandsGroup
    {
        void FindAndExecute(string commandName);
        List<ICommand> GetAllCommands();
    }
}
