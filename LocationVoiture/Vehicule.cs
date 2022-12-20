using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVoiture
{
    interface IVehicule
    {
        int Kilometrage { get; set; }
        void AjusterKilometrage(int pKmparcourus);
    }
    internal class Vehicule : IVehicule
    {
        protected string Marque;
        protected string Modele;
        protected int Annee;
        protected string Couleur;
        protected int kilometrage;
        protected char Categorie;
        protected int idVehicule;
        public static Dictionary<string, Vehicule> dicVehicule { get; private set; } = new Dictionary<string, Vehicule>();

        public Vehicule()
        {
            this.Marque = "XYZ";
            this.Modele = "ABC";
            this.Annee = 9999;
            this.Couleur = "BBB";
            this.kilometrage = 0;
            this.Categorie = 'Z';
            this.idVehicule = 0;

        }
        public Vehicule(int p_id, string pMarque, string pModele, int pAnnee, string pCouleur, int pKilometrage, char pCategorie)
        {
            this.IdVehicule = p_id;
            this.Marque = pMarque;
            this.Modele = pModele;
            this.Annee = pAnnee;
            this.Couleur = pCouleur;
            this.kilometrage = pKilometrage;
            this.Categorie = pCategorie;



        }
        public override string ToString()
        {
            return string.Format("Marque client: {0}\nModele du client: {1}\nAnnee client: {2}\nCouleur client: {3}" +
                "\nKilometrage client: {4}\nCategorie client: {5}",
                this.Marque, this.Modele, this.Annee, this.Couleur, this.Kilometrage, this.Categorie);
        }
        public void AjusterKilometrage(int pKmparcourus)
        {
            return; // temporairement useless for now

        }


        // inspiré de https://stackoverflow.com/a/36372531/14694236
        public int IdVehicule { get => idVehicule; set => idVehicule = value; }
        public string LeMarque
        {
            get { return this.Marque; }

            set { this.Marque = value; }
        }
        public string LeModele
        {
            get { return this.Modele; }

            set { this.Modele = value; }
        }
        public int LeAnnee
        {
            get { return this.Annee; }

            set { this.Annee = value; }
        }
        public string LeCouleur
        {
            get { return this.Couleur; }

            set { this.Couleur = value; }
        }
        public int Kilometrage
        {
            get { return this.Kilometrage; }

            set { this.Kilometrage = value; }
        }
        public char LeCategorie
        {
            get { return this.Categorie; }

            set { this.Categorie = value; }
        }

    }
}
