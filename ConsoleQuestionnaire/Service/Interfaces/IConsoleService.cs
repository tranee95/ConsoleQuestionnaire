using ConsoleQuestionnaire.Models;
using System.Collections.Generic;

namespace ConsoleQuestionnaire.Service.Interfaces
{
    public interface IConsoleService
    {
        void WriteLines(IEnumerable<string> lines);
        Questionnaire AskQuestions(Questionnaire questionnaire);
    }
}
