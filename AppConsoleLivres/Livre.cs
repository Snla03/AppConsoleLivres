using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        //atrribut de la classe livre
        public string Titre {  get; set; }
        public string Auteur { get; set; }
        public int NombrePages { get; set; }

        //constructeur 
        public Livre(string titre,string auteur, int nombrePages)
        {
            Titre = titre;
            Auteur = auteur;
            NombrePages = nombrePages;

        }
        //Afficher les details de la classse livre 
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, NombrePages:{NombrePages} ");
        }
    }
}
