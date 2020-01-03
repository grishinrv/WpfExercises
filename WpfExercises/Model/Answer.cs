namespace WpfExercises.Model
{
    public class Answer
    {
        public bool IsRightAnswer { get; private set; }
        public string Text { get; private set; }

        public Answer(bool isright, string text)
        {
            IsRightAnswer = isright;
            Text = text;
        }
    }
}
