class Attack
{
    public string Name {get;set;}
    // protected int Damage;
    public int _Damage {get;set;}
    public Attack(string name, int damage)
    {
        Name = name;
        _Damage = damage;
    } 

}