namespace LINQ
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            List<string> movies = new List<string>() { "Avatar", "Thor", "Black Panter", "The Avengers" };
            movies.OrderBy(film => film.Length).ToList().ForEach(film => Console.WriteLine(film));
           
        }
    }
}
