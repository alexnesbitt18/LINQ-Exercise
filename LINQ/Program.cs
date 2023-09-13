namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videogames = new List<string>() { "Axe", "Starfield", "Falling", "Zelda", "Halo"};
            var ordervideogames = videogames.OrderBy(name => name.Length);
            foreach(var game in ordervideogames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
