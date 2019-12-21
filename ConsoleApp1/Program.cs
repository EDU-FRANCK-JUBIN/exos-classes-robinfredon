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
            // Exo 1
            Console.WriteLine("Exercice 1 : ");
            CompteBancaire test = new CompteBancaire("Nicolas", 23.3, "euros", 20);
            Console.WriteLine(test.Decrire());
            test.Crediter(0.7);
            test.Debiter(8);
            Console.WriteLine(test.Decrire());

            // Exo 2
            Console.WriteLine(System.Environment.NewLine + "Exercice 2 : ");
            Console.WriteLine("Test 1 (Client partiel) :");
            Client testClient = new Client(235689, "FREDON", "Robin" );
            testClient.Afficher();

            Console.WriteLine("Test 2 (Client complet) :");
            Client testClientComplet = new Client(235689, "ARMADA", "Toto", "0565232323");
            testClientComplet.Afficher();

            //
            Compte.nbrCompte = 0;
            Compte testCompte = new Compte(testClient);            
            Compte testCompteComplet = new Compte(testClientComplet,500);

            Console.WriteLine("Test 3 (Compte partiel) :");
            testCompte.Afficher();

            Console.WriteLine("Test 4 (Compte complet) :");
            testCompteComplet.Afficher();

            testCompte.AfficherNbrCompte();

            Console.WriteLine("Test 5 (Modifs comptes) :");
            testCompteComplet.Crediter(200);
            testCompte.Debiter(100);

            testCompte.Afficher();
            testCompteComplet.Afficher();

            Console.WriteLine("Test 6 (Modifs comptes mutuels) :");
            testCompte.Crediter(200,testCompteComplet);

            testCompte.Afficher();
            testCompteComplet.Afficher();

            // Exo 3
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
