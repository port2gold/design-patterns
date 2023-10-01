namespace design_patterns.Builder
{
    public class MovieBuilder : PresentationBuilder
    {
        private Movie movie = new Movie();
        public void AddSlide(Slide slide)
        {
            movie.AddFrame(slide.GetText(), 3);
        }

        public Movie GetMovie()
        {
            return movie;
        }
    }
}
