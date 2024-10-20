using AppConsoleLivres;
   // creer une liste  pour stocker les objets Revue
   List<Revue> ListRevues = new List<Revue>();

    //creeons les objest de la clase Revue
    Revue R1 = new Revue("election AGEE 2024", "Achille", 10, 1, 2024);
    Revue R2 = new Revue("la crise en ukraine", "hugo", 10, 1, 2024);
    Revue R3 = new Revue("le covid 19", "loic", 10, 1, 2024);

    // ajoutons les objets a la liste 
    ListRevues.Add(R1);
    ListRevues.Add(R2);
    ListRevues.Add(R3);

Console.WriteLine("Liste des Revues : ");
foreach (Revue Revues in ListRevues)
{
    Revues.AfficherDetails();
}