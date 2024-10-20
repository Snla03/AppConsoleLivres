using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }
        public Revue(string titre, string auteur, int nombrepages, int numero, int annee) : base(titre, auteur, nombrepages)
        {
            Annee = annee;
            Numero = numero;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, NombrePages: {NombrePages},Numero: {Numero}, Annee: {Annee}");
        }
    }
    
}
