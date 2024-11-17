using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
       Revue revue1=new Revue ("king","Ali",412,30,1990);
       Revue revue2 = new Revue("Arbre", "Brahim", 1012, 80, 1880);
       Revue revue3 = new Revue("Foret", "Saleh", 412, 30, 2000);

        List<Revue>Revues = new List<Revue> { revue1,revue2,revue3};
        Console.WriteLine("Revues sont : ");
        foreach (var Revue in Revues) 
        {
            Revue.AfficheDetails();
        }


        Roman roman1 = new Roman("technologie","Djidi",300,"science");
        Roman roman2 = new Roman("histoir", "Romain", 2339, "history");
        Roman roman3 = new Roman("Lion", "Mark", 3572, "Humour");

        List<Roman>Romains = new List<Roman> { roman1, roman2, roman3 };
        Console.WriteLine("les romains sont :");
        foreach (var Romain in Romains)
        {
            Romain.AfficheDetails();
        }
        Console.WriteLine();




        List<Livre> livres = new List<Livre> {revue1,revue2,revue3,roman1,roman2,roman3 };

        Console.WriteLine("les Livres sont: ");
        foreach(var Livre in livres)
        {
            Livre.AfficheDetails();
        }

    }
}