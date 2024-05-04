using System;
using System.Collections.Generic;
using Eksamen_1;


BogAnbefaling anbefalingsSystem = new ();

List<string> genrer = [];

Console.WriteLine("Indtast op til 3 af dine yndlingsgenrer (tryk Enter, når du er færdig eller skriv: færdig):");

for (int i = 0; i < 3; i++)
    {
        Console.Write($"Genre {i + 1}: ");
        string genre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(genre) || genre.ToLower() == "færdig")
        break;
        genrer.Add(genre);
    }

 List<Bog> anbefalede = anbefalingsSystem.AnbefalBoeger(genrer);
    
