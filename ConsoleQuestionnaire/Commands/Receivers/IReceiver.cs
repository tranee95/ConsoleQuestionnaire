using System.Collections.Generic;
using ConsoleQuestionnaire.Commands.Interfaces;

namespace ConsoleQuestionnaire.Commands.Receivers
{
    public interface IReceiver
    {
        void ShowHelp(List<ICommand> commands);
        void CreateProfile();
    }
}
