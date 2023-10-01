namespace design_patterns.Builder
{
    public class Presentation
    {
        private List<Slide> slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            slides.Add(slide);
        }

        public void Export(PresentationBuilder presentationBuilder)
        {
            presentationBuilder.AddSlide(new Slide("Copywright"));
            foreach (var slide in slides)
            {
                presentationBuilder.AddSlide(slide);
            }
        }
    }
}
