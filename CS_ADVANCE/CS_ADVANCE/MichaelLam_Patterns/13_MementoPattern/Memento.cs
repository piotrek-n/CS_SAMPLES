namespace CS_ADVANCE.MichaelLam_Patterns._13_MementoPattern
{
    public class Memento
    {
        private string _text;

        public Memento(string text)
        {
            _text = text;
        }
        public string GetText()
        {
            return _text;
        }
    }
}