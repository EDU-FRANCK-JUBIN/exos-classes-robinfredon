using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Compte
    {
        private Client proprietaire;
        private double solde;
        private readonly int numero;
        public static int nbrCompte;

        public Compte(Client proprietaire)
        {
            this.proprietaire = proprietaire;
            numero = ++nbrCompte;
        }

        public Compte(Client proprietaire, Double asolde)
        {
            this.proprietaire = proprietaire;
            this.solde = asolde;
            numero = ++nbrCompte;
        }

        public double Solde { get => solde; }
        internal Client Proprietaire { get => proprietaire; set => proprietaire = value; }

        public int Numero1 => numero;

        public void Crediter (double somme)
        {
            this.solde += somme;
        }

        public void Crediter (double somme, Compte compteDebit)
        {
            this.solde += somme;
            compteDebit.solde -= somme;
        }

        public void Debiter(double somme)
        {
            this.solde -= somme;
        }

        public void Debiter(double somme, Compte compteCredit)
        {
            this.solde -= somme;
            compteCredit.solde += somme;
        }

        public void Afficher()
        {
            Console.WriteLine("Le compte appartient à " + this.proprietaire.Prenom + " " + this.proprietaire.Nom + " (n°" + numero + ") - solde = " + Solde + " euros");
        }

        public void AfficherNbrCompte()
        {
            Console.WriteLine("Nombre de compte créé : " + nbrCompte);
        }
    }
}
