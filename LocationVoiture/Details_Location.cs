using LocationVoiture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationVehicule
{
    class Details_Location
    {
        protected Client Client = new Client();
        protected Vehicule Vehicule = new Vehicule();
        protected int NbrJoursLocation;
        protected int NbrKmParcourus;
        protected bool Assurance;

        public Details_Location()
        {
            this.NbrJoursLocation = -1;
            this.NbrKmParcourus = -1;
            this.Assurance = false;

        }
        public Details_Location(int pNbrJoursLocation, int pNbrKmParcourus, bool pAssurance)
        {
            this.NbrJoursLocation = pNbrJoursLocation;
            this.NbrKmParcourus = pNbrKmParcourus;
            this.Assurance = pAssurance;

        }
        public override string ToString()
        {
            return string.Format("No de jours de location: {0}\nNo de kilometre parcouru: {1}\nPossession d'assurance: {2}",
                this.NbrJoursLocation, this.NbrKmParcourus, this.Assurance.ToString());
        }

        public int LeNbrJoursLocation
        {
            get { return this.NbrJoursLocation; }

            set { this.NbrJoursLocation = value; }
        }
        public int LeNbrKmParcourus
        {
            get { return this.NbrKmParcourus; }

            set { this.NbrKmParcourus = value; }
        }
        public bool LeAssurance
        {
            get { return this.Assurance; }

            set { this.Assurance = value; }
        }

    }
}
