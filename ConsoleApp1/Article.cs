using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Article
    {
        private string reference;
        private string designation;
        private double prixHT;
        private double tauxTVA;

        public Article()
        {
            this.reference = null;
            this.designation = null;
            this.prixHT = 0;
            this.tauxTVA = 0;
        }

        public Article(string reference, string designation)
        {
            this.reference = reference;
            this.designation = designation;
        }

        public Article(string reference, string designation, double prixHT, double tauxTVA)
        {
            this.reference = reference;
            this.designation = designation;
            this.prixHT = prixHT;
            this.tauxTVA = tauxTVA;
        }

        public Article(Article newArticle)
        {
            this.reference = newArticle.reference;
            this.designation = newArticle.designation;
            this.prixHT = newArticle.prixHT;
            this.tauxTVA = newArticle.tauxTVA;
        }


        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public double PrixHT { get => prixHT; set => prixHT = value; }
        public double TauxTVA { get => tauxTVA; set => tauxTVA = value; }

        public void CalculerPrixTTC(out double prixTTC)
        {
            prixTTC = this.PrixHT + (this.PrixHT * this.TauxTVA / 100);
        }

        public void AfficherArticle()
        {
            double prixTTC;
            CalculerPrixTTC(out prixTTC);
            Console.WriteLine(this.designation + " (ref:" + this.reference + ") : " + prixTTC + " euros TTC");
        }


    }
}
