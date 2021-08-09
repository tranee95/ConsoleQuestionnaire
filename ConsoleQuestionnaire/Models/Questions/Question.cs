namespace ConsoleQuestionnaire.Models.Questions
{
    public abstract class Question
    {
        public abstract string QuestionText { get; }
        public abstract string Ansver { get; set; }
        public abstract bool IsValidAnsver();
    }
}
