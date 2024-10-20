using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Revue : Livre
    {
        public int  Numero {  get; set; }
        public int Annee  { get; set; }

        public Revue (string titre,string auteur , int nombrepages , int numero ,int annee):base (titre ,auteur,nombrepages)
        {
            Numero = numero;
            Annee = annee;

        }

        public override void AfficheDetails()
        {
            Console.WriteLine($"L'auteur du livre est {Auteur}et  le titre {Titre} et nombre de page {NombrePage},le numero de revue est {Numero}et l annee {Annee}");
        }
    }
}
