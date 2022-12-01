class MagicCaster : Enemy
{
    public int Health = 80;
    public MagicCaster(string name) : base(name,80)
    {
        Attacks.Add(new Attack(" Burning Exodus", 25));
        Attacks.Add(new Attack("Barrier ", 0));
        Attacks.Add(new Attack("Evil Blaze Spell", 65));

    }
    public void HealSpell(Enemy newEnemy)
    {
        Health+=40;
        Console.WriteLine($"You used the Heal Spell!");
        Console.WriteLine($"HP: {newEnemy._Health} ");
    }
}