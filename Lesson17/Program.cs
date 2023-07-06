namespace Lesson17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SeasonsWeather winter = new Winter();
            SeasonsWeather spring = new Spring();
            SeasonsWeather sammer = new Sammer();
            SeasonsWeather automn = new Autom();

            winter.Snow();
            winter.Hail();
            winter.Tycoon();
            winter.Rain();

            spring.Snow();
            spring.Rain();
            spring.Hail();
            spring.Tycoon();

            sammer.Rain();
            sammer.Hail();
            sammer.Tycoon();

            automn.Snow();
            automn.Rain();
            automn.Hail();
            automn.Tycoon();

            

        }
    }
}