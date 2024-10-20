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
    }
}