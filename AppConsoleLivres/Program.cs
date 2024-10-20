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
// creer une liste  pour stocker les objets Roman
List<Roman> ListRomans = new List<Roman>();

// les objest de la classe Roman
Roman r1 = new Roman("quatre mariage une lune de miel", "Evelyne Mpoudi Ngole", 146, "Tragedie");
Roman r2 = new Roman("sous la cendre le feu", "Emile Roland", 88, "Tragedie");
Roman r3 = new Roman("petit JOE enfant des rues", "Evelyne Mpoudi Ngole", 112, "Comedie");
// ajoutons les objets a la liste 
ListRomans.Add(r1);
ListRomans.Add(r2);
ListRomans.Add(r3);

Console.WriteLine("Liste des Romans : ");
foreach (Roman Roman in ListRomans)
{
    Roman.AfficherDetails();
}
//gestions des intances  de la classes livre
List<Livre> ListLivres = new List<Livre>();
ListLivres.Add(R1);
ListLivres.Add(R2);
ListLivres.Add(R3);
ListLivres.Add(r1);
ListLivres.Add(r2);
ListLivres.Add(r3);

Console.WriteLine("Liste des livres : ");
foreach (Livre livre in ListLivres)
{
    livre.AfficherDetails();
}

