class RangedFighter : Enemy
{
    public int Distance = 5;

    public RangedFighter(string name) : base(name,100)
    {
        Attacks.Add(new Attack("Shoot an Arrow", 20));
        Attacks.Add(new Attack("Throw a Knife", 15));
    }

    public void Dash()
    {
        Distance=20;
    }
    public Attack? RandAttack()
    {
        if(Distance<10)
        {
            Console.WriteLine($" Current Distance is {Distance}ft!!  you gotta be at least 10ft away");
            return null;
        }
        else
        {
            return base.RandAttack();
        }
    }
}