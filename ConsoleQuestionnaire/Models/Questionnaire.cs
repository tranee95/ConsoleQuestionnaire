using System;
using System.Collections.Generic;
using ConsoleQuestionnaire.Models.Questions;

namespace ConsoleQuestionnaire.Models
{
    public class Questionnaire
    {
        public Questionnaire()
        {
            Questions = new List<Question>
            {
                new FullName(),
                new DateOfBirth()
            };
        }

        public string Name { get; set; }

        public List<Question> Questions { get; set; }

        public DateTime CreateQuestionnaireDate { get; set; }
    }
}
