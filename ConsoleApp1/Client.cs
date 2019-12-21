using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client
    {
        private int CNI;
        private String nom;
        private String prenom;
        private String tel;

        public Client(int cNI, string nom, string prenom)
        {
            CNI = cNI;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Client(int cNI, string nom, string prenom, string tel)
        {
            this.CNI = cNI;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public int CNI1 { get => CNI; set => CNI = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }

        public void Afficher()
        {
            Console.WriteLine("Client : " + this.Nom + " " + this.Prenom + " - " + this.Tel);
        }
    }
}
