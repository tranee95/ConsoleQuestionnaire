using ConsoleQuestionnaire.Commands.Interfaces;
using System;

namespace ConsoleQuestionnaire.Commands
{
    public class ExitCommand : ICommand
    {
        public string Name => "exit";
        public string Description => "Выйти из приложения";
        public void Execute() => Environment.Exit(0);
    }
}
