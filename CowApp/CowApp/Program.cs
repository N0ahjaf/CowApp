namespace CowApp;

class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows = new List<Cow>
        {
            new Cow("Milka", "lila", 4),
            new Cow("Paula", "weiss", 6),
            new Cow("Conny", "schwarz", 4),
            new Cow("Berta", "weiss", 7),
            new Cow("Mathias", "rosa", 4),
            new Cow("Milka", "rosa", 4),
            new Cow("Milka", "lila", 5),

        };
        
        Console.WriteLine($"Nach Name sortiert");
        cows.Sort();
        foreach (Cow cow in cows)
            Console.WriteLine($"{cow.Name} {cow.Colour}  {cow.Age}");

        Console.WriteLine($"Nach Farbe sortiert ");
        cows.Sort((new CompareByColor()));
        foreach (Cow cow in cows)
            Console.WriteLine($"{cow.Name} {cow.Colour}  {cow.Age}");



        Console.WriteLine($"Nach alter absteigend sortiert:");
        cows.Sort((new ComparebyAge()));
        foreach (Cow cow in cows)
            Console.WriteLine($"{cow.Name} {cow.Colour}  {cow.Age}");
        
    }
}