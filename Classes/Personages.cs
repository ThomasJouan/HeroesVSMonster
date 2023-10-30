namespace HeroesVSMonsters.Classes;

public abstract class Personages
{
    //Propriétés
    public virtual int Endurance { get; init; }
    public virtual int Force { get; init; }
    public virtual int Pv { get; init; }
    
    //Méthodes

    protected int Modificateur(int attribut)
    {
        if (attribut < 5)
        {
            return - 1;
        }
        if (attribut < 10)
        {
            return 0;
        }
        if (attribut < 15)
        {
            return 1;
        }
        return 2;
    }
    public virtual void Frappe(/*PAS OUBLIER DE METTRE MECHANT*/)
    {
        De d4 = new De(4);
        List<int> lDegat = d4.Lance(1);
        int degat = lDegat[0] + Modificateur(Force);
        Console.WriteLine($"Frappe de {degat}");
    }
    
    //Constructeur
    public Personages(){}

    public Personages(int end, int force)
    {
        Endurance = end;
        Force = force;
        Pv = Endurance + Modificateur(Endurance);
    }
}

//delegate void setPv(int amountPv);