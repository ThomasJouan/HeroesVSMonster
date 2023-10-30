namespace HeroesVSMonsters.Classes;

public class Humain : Hero
{
    public Humain(int end, int force) : base(end,force)
    {
        ForceHero = force + 1;
        EnduHero = end + 1;
    }
}