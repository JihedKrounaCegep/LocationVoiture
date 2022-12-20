using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule
{
   
    class Client
    {
        protected string Nom;
        protected string Prenom;
        protected string Adresse;
        protected string Telephone;
        protected string Courriel;
        protected string NoPermis;
        protected DateTime DateNaissance;
        public static Dictionary<string, Client> dicClient { get; private set; } = new Dictionary<string, Client>();
        public Client()
        {
            this.Nom = "XYZ";
            this.Prenom = "ABC";
            this.Adresse = "Adresse";
            this.Telephone = "1234567890"; // changer à noTelephone TODO
            this.Courriel = "abc.xyz@bbb.cc";
            this.NoPermis = "XYZA1234567";
            this.DateNaissance = DateTime.Now;
        }
        public Client(string pNom, string pPrenom, string pAdresse, string pTelephone, string pCourriel, string pNoPermis, DateTime pDateNaissance)
        {
            this.Nom = pNom;
            this.Prenom = pPrenom;
            this.Adresse = pAdresse;
            this.Telephone = pTelephone;
            this.Courriel = pCourriel;
            this.NoPermis = pNoPermis;
            this.DateNaissance = pDateNaissance;
        }
        public override string ToString()
        {
            return string.Format("Nom client: {0}\nPrenom du client: {1}\nAdresse client: {2}\nTelephone client: {3}" +
                "\nCourriel client: {4}\nNo Permis client: {5}\nDate naissance client: {6}",
                this.Nom, this.Prenom, this.Adresse, this.Telephone, this.Courriel, this.NoPermis, this.DateNaissance.ToString("mm-dd-yyyy"));
        }
        public static bool ValiderAge(DateTime pDate)
        {

            DateTime n = DateTime.Now; // To avoid a race condition around midnight
            int age = n.Year - pDate.Year;

            if (n.Month < pDate.Month || (n.Month == pDate.Month && n.Day < pDate.Day))
                age--;
            // source du code de cette méthode : https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday
            // consulté le 2021-11-07 11pm
            if (age >= 25)
            {
                return true;
            }
            else { return false; }

        }

        public static void AjouterClient(Client pClient)
        {
            dicClient.Add(pClient.NoPermis, pClient);

        }
        //Possibilité d'utiliser le programme sans base de donnée SQL
        public static bool SupprimerClient(string pNoPermis)
        {
            bool Flag = false;
            // métode inspiré de Exercise S4 Stagiaires 

            foreach (string Clef in dicClient.Keys)
            {
                if (Clef == pNoPermis)
                {
                    dicClient.Remove(Clef);
                    Flag = true;
                    break;
                }
            }

            return Flag;
        }

        //Possibilité d'utiliser le programme sans base de donnée SQL
        public static bool ModifierClient(string pNoPermis, Client pObj)
        {
            bool Flag = false;

            foreach (string Clef in dicClient.Keys)
            {
                if (Clef == pNoPermis)
                {
                    dicClient[Clef] = pObj;
                    Flag = true;
                    break;
                }
            }

            return Flag;
        }
        public string LeNom
        {
            get { return this.Nom; }

            set { this.Nom = value; }
        }
        public string LePrenom
        {
            get { return this.Prenom; }

            set { this.Prenom = value; }
        }
        public string LeAdresse
        {
            get { return this.Adresse; }

            set { this.Adresse = value; }
        }
        public string LeTelephone
        {
            get { return this.Telephone; }

            set { this.Telephone = value; }
        }
        public string LeCourriel
        {
            get { return this.Courriel; }

            set { this.Courriel = value; }
        }
        public string LeNoPermis
        {
            get { return this.NoPermis; }

            set { this.NoPermis = value; }
        }
        public DateTime LeDateNaissance
        {
            get { return this.DateNaissance; }

            set { this.DateNaissance = value; }
        }


    }
}
