namespace design_patterns.Builder
{
    public class Slide
    {
        private string text;

        public Slide(string text)
        {
            this.text = text;
        }

      
        public string GetText()
        {
            return text;
        }
    }
}
