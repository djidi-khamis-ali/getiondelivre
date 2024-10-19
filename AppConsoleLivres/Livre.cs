

namespace AppConsoleLivres
{
    internal class Livre
    {
        public string Titre {  get; set; }
        public string Auteur { get; set; }
        public int NombrePage { get; set; }

        public Livre(string titre, string auteur, int nombrePage)
        {
            Titre = titre;
            Auteur = auteur;
            NombrePage = nombrePage;

        }
        public virtual void AfficheDetails()
        { Console.WriteLine($"Le livre a pour auteur {Auteur} et son titre est {Titre},le nombre de page est de {NombrePage} pages "); }
    }
}
