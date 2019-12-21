using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CompteBancaire
    {
        private String titulaire;
        private double solde;
        private String devise;

        public CompteBancaire(String titulaire, double solde, String devise, int nbrCompte)
        {
            this.Titulaire = titulaire;
            this.Solde = solde;
            this.Devise = devise;
        }

        public string Titulaire { get => titulaire; set => titulaire = value; }
        public double Solde { get => solde; set => solde = value; }
        public string Devise { get => devise; set => devise = value; }

        public void Crediter(double montant)
        {
            this.Solde += montant;
        }

        public void Debiter(double montant)
        {
            this.Solde -= montant;
        } 

        public String Decrire()
        {
            return this.titulaire + " a " + this.solde.ToString() + " " + this.devise;
        }
    }
}
