using HeroesVSMonsters.Classes;

De d6 = new De(6);
//Jet de force
List<int> jetForce = d6.Lance(6);
int valForce = 0;
for (int i = 0; i < 3; i++)
{
    valForce += jetForce[i];
}
//Jet d'endurance
List<int> jetEndu = d6.Lance(6);
int valEndu = 0;
for (int i = 0; i < 3; i++)
{
    valEndu += jetEndu[i];
}
//Création perso
Humain humain = new Humain(valEndu, valForce);
Nain nain = new Nain(valEndu, valForce);
Console.WriteLine("C'est l'humain");
humain.Frappe();
Console.WriteLine("C'est le nain");
nain.Frappe();
Console.WriteLine("HUMAIN");
Console.WriteLine($"Endurance : {humain.EnduHero} \nForce : {humain.ForceHero} \nForce de base : {humain.Force}\nPV : {humain.Pv}");
Console.WriteLine("NAIN");
Console.WriteLine($"Endurance : {nain.EnduHero} \nForce : {nain.ForceHero} \nForce de base : {nain.Force}\nPV : {nain.Pv}");