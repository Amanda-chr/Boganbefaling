using Eksamen_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen_1
{
    class BogAnbefaling
    {
        private List<Bog> boeger;

        public BogAnbefaling()
        {
            boeger =
         [
            new() { Titel = "The Great Gatsby", Forfatter = "F. Scott Fitzgerald", Genrer = ["Drama", "Klassiker"] },
            new() { Titel = "To Kill a Mockingbird", Forfatter = "Harper Lee", Genrer = ["Fiktion", "Drama"] },
            new() { Titel = "1984", Forfatter = "George Orwell", Genrer = ["Science Fiction", "Dystopisk"] },
            new() { Titel = "The Catcher in the Rye", Forfatter = "J.D. Salinger", Genrer = ["Fiktion", "Drama"] },
            new() { Titel = "Pride and Prejudice", Forfatter = "Jane Austen", Genrer = ["Romance", "Klassiker"] }
        ];
        }
        public List<Bog> AnbefalBoeger(List<string> genrer)
        {
            List<Bog> anbefalede = [];

            // Recommend books based on genres
            if (genrer.Count > 0)
            {
                foreach (var bog in boeger)
                {
                    foreach (var genre in genrer)
                    {
                        if (bog.Genrer.Any(g => g.Equals(genre, StringComparison.OrdinalIgnoreCase)))
                        {
                            anbefalede.Add(bog);
                            break; // Once a match is found for a genre, break out of inner loop
                        }
                    }
                }

                Console.WriteLine("\nAnbefalede bøger:");
                foreach (var bog in anbefalede)
                {
                    Console.WriteLine($"{bog.Titel} af {bog.Forfatter}");
                }
            }
            else
            {
                Console.WriteLine("\nDu har ikke skrevet nogle yndlingsgenrer. Må jeg anbefale dig 1, 2 eller 3 forslag?");
                string antalForslag = Console.ReadLine();
                string momo = "Momo af Michael Ende";
                string kompas = "Det Gyldne Kompas af Philip Pullman";
                string ender = "Ender's Game af Orson Scott Card";

                switch (antalForslag)
                {
                    case "1": 
                        Console.WriteLine($"{momo}");
                        break;

                    case "2":
                        Console.WriteLine($"{momo} og {kompas}");
                        break;

                    case "3":
                        Console.WriteLine($"{momo}, {kompas} og {ender}");
                        break;
                }

            }

            return anbefalede;
        }
    }
}
