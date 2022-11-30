class Enemy
{
    private string Name;
    public string _Name {get{return Name;}}
    private int Health;
    private int _Health {get{return Health;}} 
    public List<Attack> Attacks; 
    public List<Attack> _Attacks{get{return Attacks;}} 
    public Enemy(string n, int h)
    {
        Name = n;
        Health = h;
        Attacks = new List<Attack>();
    }
    public Attack RandAttack()
    {
        Random rand = new Random();
        int randNum = rand.Next(0,Attacks.Count);
        Console.WriteLine($"Enemy: {Name} has attacked you with {Attacks[randNum].Name}");
        return Attacks[randNum];
    }
}

