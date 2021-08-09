using System;
using System.Collections.Generic;
using ConsoleQuestionnaire.Models;
using ConsoleQuestionnaire.Service.Interfaces;

namespace ConsoleQuestionnaire.Service
{
    public class ConsoleService: IConsoleService
    {
        public void WriteLines(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public Questionnaire AskQuestions(Questionnaire questionnaire)
        {
            for (var i = 0; i < questionnaire.Questions.Count; i++)
            {
                Console.Write($"{questionnaire.Questions[i].QuestionText} > ");
                questionnaire.Questions[i].Ansver = Console.ReadLine();

                if (!questionnaire.Questions[i].IsValidAnsver())
                {
                    Console.WriteLine("Ошибка ввода данных");
                    i--;
                }
            }

            return questionnaire;
        }
    }
}
