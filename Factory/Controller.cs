using design_patterns.Factory.matcha;

namespace design_patterns.Factory
{
    public  class Controller
    {
        public void Render(string  viewName, Dictionary<string, object> parameters)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, parameters);
            Console.WriteLine(html) ;
        }

        protected virtual ViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}
