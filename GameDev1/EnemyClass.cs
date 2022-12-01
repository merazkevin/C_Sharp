class Enemy
{
    private string Name;
    public string _Name {get{return Name;}}
    private int Health;
    public int _Health {get{return Health;} set{Health=value;}} 
    public List<Attack> Attacks; 
    public List<Attack> _Attacks{get{return Attacks;}} 
    public Enemy(string n, int h)
    {
        Name = n;
        Health = h;
        Attacks = new List<Attack>();
    }
    public Attack? RandAttack()
    {
        Random rand = new Random();
        int randNum = rand.Next(0,Attacks.Count);
        _Health-= Attacks[randNum]._Damage;
        Console.WriteLine($"Enemy: {Name} has attacked you with {Attacks[randNum].Name} Damage:{Attacks[randNum]._Damage}");
        Console.WriteLine($"Your HP+ is now {_Health}");
        return Attacks[randNum];
    }
    
}

