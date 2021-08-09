using ConsoleQuestionnaire.Commands.Interfaces;
using ConsoleQuestionnaire.Commands.Receivers;

namespace ConsoleQuestionnaire.Commands
{
    public class NewProfileCommand : ICommand
    {
        private readonly IReceiver _receiver;

        public NewProfileCommand(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public string Name => "new_profile";
        public string Description => "Заполнить новую анкету";
        public void Execute() => _receiver.CreateProfile();
    }
}
