class Attack
{
    public string Name {get;set;}
    protected int Damage;
    public int _Damage {get{return Damage;}}
    public Attack(string name, int damage)
    {
        Name = name;
        Damage = damage;
    } 

}