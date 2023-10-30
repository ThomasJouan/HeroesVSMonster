namespace HeroesVSMonsters.Classes;

public class De
{
    private Random rnd = new Random();
    private int _nbrFace;

    public De() {}

    public De(int nbrFace)
    {
        _nbrFace = nbrFace;
    }

    /****************************************
     * La méthode Lance permet de lancer 1 ou
     * plusieur Dé et retourne une liste avec
     * les meilleur résultats en début de liste
     ****************************************/
    public List<int> Lance(int nbrLance)
    {
        List<int> results = new List<int>();

        if (nbrLance == 1)
        {
            results.Add(rnd.Next(1,_nbrFace+1));
            return results;
        }
        for (int i = 0; i < nbrLance; i++)
        {
            results.Add(rnd.Next(1,_nbrFace+1));
        }
        results.Sort();
        results.Reverse();
        
        return results;
    }
}