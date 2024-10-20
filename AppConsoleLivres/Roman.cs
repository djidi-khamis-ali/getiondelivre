using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman (string titre,string auteur,int nombrepages,string genre) :base (titre, auteur, nombrepages)
        {
            Genre = genre;
        }

        public override void AfficheDetails() 
        {
            Console.WriteLine($"l'auteur est {Auteur}, le livre a pour titre {Titre} de nombre de page{NombrePage} du genre {Genre}");
        }
    }
}
