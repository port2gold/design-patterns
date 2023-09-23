namespace design_patterns.Factory.sharp
{
    public class SharpController : Controller
    {
        protected override ViewEngine CreateViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}
