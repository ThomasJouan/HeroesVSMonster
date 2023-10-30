namespace HeroesVSMonsters.Classes;

public class Nain : Hero
{
    public Nain(int end, int force) : base(end,force)
    {
        EnduHero = end + 2;
    }
}