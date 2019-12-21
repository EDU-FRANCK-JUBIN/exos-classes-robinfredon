using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Exercice 1 : ");
            CompteBancaire test = new CompteBancaire("Nicolas", 23.3, "euros", 20);
            Console.WriteLine(test.Decrire());
            test.Crediter(0.7);
            test.Debiter(8);
            Console.WriteLine(test.Decrire());

            Console.WriteLine(System.Environment.NewLine + "Exercice 2 : ");
            Client testClient = new Client(235689, "Robin", "FREDON");
            Compte testCompte = new Compte(testClient);

            Console.WriteLine(System.Environment.NewLine + "Exercice 3 : ");
            testArticle();
        }

        

        static void testArticle()
        {
            Console.WriteLine("Test 1 (valeurs par défaut) :");
            Article test1 = new Article();
            test1.AfficherArticle();

            Console.WriteLine("Test 2 (initialisation partielle) :");
            Article test2 = new Article(reference: "88888",designation: "Ecocup");
            test2.AfficherArticle();

            Console.WriteLine("Test 3 (initialisation complète) :");
            Article test3 = new Article(reference: "777777", designation: "Telephone", prixHT: 200.0, tauxTVA: 20);
            test3.AfficherArticle();

            Console.WriteLine("Test 4 (duplication test3) :");
            Article test4 = new Article(test3);
            test4.AfficherArticle();
        }
    }
}
