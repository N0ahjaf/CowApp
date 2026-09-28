namespace CowApp;

class Program
{
    static void Main(string[] args)
    {   
        List<Cow> cows = new List<Cow>
        {
            new Cow("Milka", "lila", 4,new DateTime(2009,10,17)),
            new Cow("Paula", "weiss", 6,new DateTime(2000,4,12)),
            new Cow("Conny", "schwarz", 4,new DateTime(1999,12,5)),
            new Cow("Berta", "weiss", 7,new DateTime(2009,10,7)),
            new Cow("Mathias", "rosa", 4,new DateTime(2020,12,2)),
            new Cow("Milka", "rosa", 4,new DateTime(2024,5,22)),
            new Cow("Milka", "lila", 5,new DateTime(2001,1,8)),

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

        // erste eigene Implementierung 
        Console.WriteLine($"Nach 2ten Buchstaben sortiert:"); 
        cows.Sort((new CompareBySecondLetter()));
        foreach (Cow cow in cows)
            Console.WriteLine($"{cow.Name} {cow.Colour}  {cow.Age}");
        
        
        // zweite eigene Implementierung 
        Console.WriteLine($"Nach Geburtsdatum steigend sortiert:");
        cows.Sort((new CompareByBirthday()));
        foreach (Cow  cow in  cows)
        {
            Console.WriteLine($"{cow.Name} {cow.Colour}  {cow.Age} {cow.Geburt}");
        }
    }
}