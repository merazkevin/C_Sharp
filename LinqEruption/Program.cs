﻿List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// 1. Use LINQ to find the first eruption that is in Chile and print the result.
Eruption? firstEruptionInChile = eruptions.FirstOrDefault(n => n.Location == "Chile");
// Console.WriteLine(firstEruptionInChile);

// 2. Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Eruption? firstEruptionInHawaiianIs = eruptions.FirstOrDefault(n => n.Location == "Hawaiian Is");
// Console.WriteLine(firstEruptionInHawaiianIs);

// 3. Find the first eruption from the "Greenland" location and print it. If none is found, print "No Greenland Eruption found."
Eruption? firstEruptionInGreenLand = eruptions.FirstOrDefault(n => n.Location == "Greenland");
// if(firstEruptionInGreenLand==null)
// {
//     Console.WriteLine("============================");
//     Console.WriteLine("----------------------------");
//     Console.WriteLine("No Greenland Eruption found");
//     Console.WriteLine("----------------------------");
//     Console.WriteLine("============================");
// }
// else
// {
//     Console.WriteLine(firstEruptionInGreenLand);
// }


// 3. Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
IEnumerable<Eruption> firstEruption = eruptions.Where(l => l.Year > 1900).Where(l => l.Location == "New Zealand");
// PrintEach(firstEruption);




// 4. Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> greater2000m = eruptions.Where(e => e.ElevationInMeters > 2000);
// PrintEach(greater2000m);


// 5. Find all eruptions where the volcano's name starts with "L" and print them. Also print the number of eruptions found.
List<Eruption> EruptionsStartWitL = eruptions.Where(p=>p.Volcano.StartsWith("C")).ToList();
// PrintEach(EruptionsStartWitL);

// 6. Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
int highestElevation = eruptions.Max(p=>p.ElevationInMeters);
// Console.WriteLine(highestElevation);

// 7. Use the highest elevation variable to find a print the name of the Volcano with that elevation.
IEnumerable<Eruption> tallestVolcano = eruptions.Where(e=>e.ElevationInMeters==highestElevation).ToList();
// PrintEach(tallestVolcano);

// 8. Print all Volcano names alphabetically.
IEnumerable<Eruption> sortedVolcanos = eruptions.OrderBy(a=>a.Volcano);
// PrintEach(sortedVolcanos);

// 9. Print the sum of all the elevations of the volcanoes combined.
int sumAllElevations = eruptions.Sum(e=>e.ElevationInMeters);
// Console.WriteLine("");
// Console.WriteLine("============================================");
// Console.WriteLine("--------------------------------------------");
// Console.WriteLine(sumAllElevations);
// Console.WriteLine("--------------------------------------------");
// Console.WriteLine("============================================");
// Console.WriteLine("");

// 10. Print whether any volcanoes erupted in the year 2000 (Hint: look up the Any query)
bool PossibleEruptions = eruptions.Any(e=>e.Year==2000);
// Console.WriteLine("");
// Console.WriteLine("============================================");
// Console.WriteLine("--------------------------------------------");
// Console.WriteLine(PossibleEruptions);
// Console.WriteLine("--------------------------------------------");
// Console.WriteLine("============================================");
// Console.WriteLine("");

// 11. Find all stratovolcanoes and print just the first three (Hint: look up Take)
IEnumerable<Eruption> stratoVolcanoes = eruptions.Where(e=>e.Type=="Stratovolcano").Take(3);
// PrintEach(stratoVolcanoes);

// 12. Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> EruptionsWithVol = eruptions.Where(e=>e.Year<1000).OrderBy(e=>e.Volcano);
PrintEach(EruptionsWithVol);

// 13. Redo the last query, but this time use LINQ to only select the volcano's name so that only the names are printed.
IEnumerable<string> VolNames = eruptions.Where(e=>e.Year<1000).OrderBy(e=>e.Volcano).Select(e=>e.Volcano).ToList();
foreach(string item in VolNames)
{
    Console.WriteLine(item);
}



// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("============================================");
        Console.WriteLine(item.ToString());
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("============================================");
        Console.WriteLine("");
    }
}