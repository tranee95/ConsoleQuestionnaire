namespace ConsoleQuestionnaire.Models.Questions
{
    public class FullName : Question
    {
        public override string QuestionText => "ФИО";
        public override string Ansver { get; set; }
        public override bool IsValidAnsver() => Ansver.Length <= 100;
    }
}
