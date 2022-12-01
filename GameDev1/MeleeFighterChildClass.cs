class MeleeFighter : Enemy
{
    int Health = 120;

    public MeleeFighter(string name): base(name,120)
    {

        Attacks.Add(new Attack("Logic", 20));
        Attacks.Add(new Attack("BehaviorQuest", 15));
        Attacks.Add(new Attack("RejectLetter", 15));

    }

    public void Rage()
    {
        base.RandAttack();
        Health -= 10; 
    }
}