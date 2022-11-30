class Vehicle
{
    private string Name;
    public string _name {get{return Name;}}
    public int NumberPass;
    string Color;
    bool WithEngine;
    int TopSpeed;
    public int TraveledDist = 0;

    public Vehicle(string n, int np, string c, bool we, int tp)
    {
        Name = n;
        NumberPass = np;
        Color = c;
        WithEngine = we;
        TopSpeed = tp;
    }
    public Vehicle(string n,  string c)
    {
        Name = n;
        NumberPass = 0;
        Color = c;
        WithEngine = true;
        TopSpeed = 80;
    }
    public void showInfo()
    {
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"NumberPass:{NumberPass}");
        Console.WriteLine($"Color:{Color}");
        Console.WriteLine($"WithEngine:{WithEngine}");
        Console.WriteLine($"TraveledDist:{TraveledDist}");
        Console.WriteLine($"TopSpeed:{TopSpeed}");
    }
    public void Travel(int newTraveledDist)
    {
        TraveledDist += newTraveledDist;
        Console.WriteLine($" Your {Name} has traveled {TraveledDist}!");
    }

}


