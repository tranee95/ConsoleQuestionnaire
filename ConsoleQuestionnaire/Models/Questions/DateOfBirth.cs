using System;
using System.Globalization;

namespace ConsoleQuestionnaire.Models.Questions
{
    public class DateOfBirth : Question
    {
        public override string QuestionText => "Дата рождения (Формат ДД.ММ.ГГГГ)";
        public override string Ansver { get; set; }

        public override bool IsValidAnsver()
        {
            const string format = "dd.MM.yyyy";
            return DateTime.TryParseExact(Ansver, format, null, DateTimeStyles.None, out _);
        }
    }
}
