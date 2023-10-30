namespace HeroesVSMonsters.Classes;

public class Hero : Personages
{
    private int _sacOr = 0;
    private int _sacCuire = 0;

    public int SacOr
    {
        set { SacOr = _sacOr; }
        get { return SacOr; }
    }
    public int SacCuir
    {
        set { SacCuir = _sacCuire; }
        get { return SacCuir; }
    }
    public int EnduHero { get; init; }//ACHECK
    public int ForceHero { get; init; }
    

    public Hero(int end, int force) : base(end, force)
    {
        EnduHero = end;
        ForceHero = force;
    }
}