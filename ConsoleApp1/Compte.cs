using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Compte
    {
        private readonly double solde;
        private static readonly int numero;
        public static int nbrNumero;
        private Client proprietaire;

        static Compte()
        {
            numero++;
        }

        public Compte(Client proprietaire)
        {
            this.proprietaire = proprietaire;
        }

        public double Solde { get => solde; }
        public static int Numero { get => numero; }
        internal Client Proprietaire { get => proprietaire; set => proprietaire = value; }

        public void Crediter (double somme)
        {
            // this.solde += somme;
        }
    }
}
