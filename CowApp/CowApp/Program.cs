using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
namespace CowApp;

class Program
{
    static void Main(string[] args)
    {
        if (File.Exists("file.txt"))
        {
            List<Cow> cows = new List<Cow>();
            using (StreamReader reader = new StreamReader("file.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(';');

                    if (parts.Length != 4)
                    {
                        Console.WriteLine($"Falsches Format: {line}");
                        continue;
                    }

                    if (!line.StartsWith('"'))
                    {
                        Console.WriteLine($"Name nicht in Anführungszeichen: {line}");
                        continue;
                    }

                    string name = parts[0].Trim('"');
                    string farbe = parts[1].Trim('"');

                    if (!int.TryParse(parts[2], out int alter))
                    {
                        Console.WriteLine($"Ungültiges Alter: {parts[2]}");
                        continue;
                    }

                    if (!DateTime.TryParse(parts[3], out DateTime gB))
                    {
                        Console.WriteLine($"Ungültiges Datum: {parts[3]}");
                        continue;
                    }

                    cows.Add(new Cow(name, farbe, alter, gB));
                }
            }

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
        }else Console.WriteLine($"File nicht gefunden");
    }
}