using LocationVehicule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
// jihed krouna 2077603
// source icone : https://www.flaticon.com/free-icon/project-management_1087927?term=manager&page=1&position=7&page=1&position=7&related_id=1087927&origin=tag
// auteur : dDara

namespace LocationVoiture
{

    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

        }
        // délégation de la méthode ValiderAge
        delegate bool CalculAge(DateTime pDate);
        CalculAge calculAge = new CalculAge(Client.ValiderAge);
        int i;
        // initialisation des objets AdoNet
        AdoNet Ado = new AdoNet();
        AdoNet AdoVehicule = new AdoNet();
        AdoNet AdoLocation = new AdoNet();
        public string MessageErreur;
        // regex pour le nom, prenom , no téléphone, curriel, no permis et adresse du client
        public const string ModeleNom = "^[a-zA-Z]+$";
        public const string ModelePrenom = "^[a-zA-Z]+$";
        public const string ModelTelephone = "^[0-9]{10}$";
        public const string ModelCourriel =
                @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        // source : https://stackoverflow.com/a/16168117 (consulté le 2022-12-17)
        public const string ModeleNoPermis = "^[A-Za-z]{4}[0-9]{7}$";
        public const string ModeleAdresse = "^[0-9a-zA-Z ]+$";

        public void ConnectionLocation(int p_option)
        {
            int valeurMin = -1;
            int valeurMax = -1;
            if ((p_option == 1 || p_option == 2))
            {
                valeurMin = int.Parse(txtKmMin.Text);
            }
            if (p_option == 0)
            {
                string Query2 = "select * from location;";
                AdoLocation.Cmd.CommandText = Query2;
            }
            else if (p_option == 1)
            {
                string Query2 = "select * from location where noKmParcourus >= " + valeurMin + ";";
                AdoLocation.Cmd.CommandText = Query2;
            }
            else if (p_option == 2)
            {
                string Query2 = "select * from location where noKmParcourus <= " + valeurMax + ";";
                AdoLocation.Cmd.CommandText = Query2;
            }
            else if (p_option == 3)
            {
                string Query2 = "select * from location where noKmParcourus >= " + valeurMin + "and noKmParcourus <= " + valeurMax + ";";
                AdoLocation.Cmd.CommandText = Query2;
            }
            
            AdoLocation.Cmd.Connection = AdoLocation.Conn;
            AdoLocation.Adapter.SelectCommand = AdoLocation.Cmd;
            AdoLocation.Adapter.Fill(Ado.Dslocation);

            AdoLocation.DtLocation = Ado.Dslocation.Tables[0];
            this.dataGridViewLocation.DataSource = AdoLocation.DtLocation;
            AdoLocation.Cmd.Connection.Close(); 
        }


        /// <summary>
        /// methode pour vérifier les données entrée par l'utilisateur pour la création de client
        /// </summary>
        public void VerificationEntree()
        {
            MessageErreur = ""; // probablement inutile
            Regex Reg1 = new Regex(ModeleNom);
            Regex Reg2 = new Regex(ModelePrenom);
            Regex Reg3 = new Regex(ModelTelephone);
            Regex Reg4 = new Regex(ModelCourriel);
            Regex Reg5 = new Regex(ModeleNoPermis);
            Regex Reg6 = new Regex(ModeleAdresse);

            if (!Reg1.IsMatch(txtNom.Text))
            {
                MessageErreur += "\nLe nom devrait contenir au minimum une lettre et n\'accepte pas les chiffres.";
            }
            if (!Reg2.IsMatch(txtPrenom.Text))
            {
                MessageErreur += "\nLe prenom devrait contenir au minimum une lettre et n'accepte pas les chiffres.";
            }
            if (!Reg3.IsMatch(txtTel.Text))
            {
                MessageErreur += "\nLe numéro de télélphone devrait devrait être composé de 10 chiffre.";
            }
            if (!Reg4.IsMatch(txtCourriel.Text))
            {
                MessageErreur += "\nLe courriel ne devrait pas avoir un caractère irrégulier.";
            }
            if (!Reg5.IsMatch(txtNoPermis.Text))
            {
                MessageErreur += "\nLe numero de permis ne correspond pas au modèle standard.";
            }
            if (!Reg6.IsMatch(txtAdresse.Text))
            {
                MessageErreur += "\nL\'adresse devrait contenir au minimum une lettre et n\'accepte pas les chiffres.";
            }

            if (!calculAge(dateTimePicker.Value))
            {
                MessageErreur += "\nL\'âge du client est inferieur à 25 ans.";
            }

            if (MessageErreur == "")
            {
                lblDeLobjet.Visible = true;
                lblErreur.Text = MessageErreur;
                lblErreur.Visible = false;
            }
            if (MessageErreur != "")
            {
                lblErreur.Visible = true;
                lblDeLobjet.Visible = false;
                lblErreur.Text = MessageErreur;
            }

        }

        private void main_Load(object sender, EventArgs e)
        {

            // inspiré du laboratoire ADO.NET : Mode déconnecté ou indirect.
            string Query = "select * from client";
            Ado.Cmd.CommandText = Query;

            Ado.Cmd.Connection = Ado.Conn;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Dslocation);

            Ado.DtClient = Ado.Dslocation.Tables[0];
            this.dataGridViewClient.DataSource = Ado.DtClient;

            string Query1 = "select * from Vehicule;";
            AdoVehicule.Cmd.CommandText = Query1;

            AdoVehicule.Cmd.Connection = AdoVehicule.Conn;
            AdoVehicule.Adapter.SelectCommand = AdoVehicule.Cmd;
            AdoVehicule.Adapter.Fill(AdoVehicule.Dslocation);


            AdoVehicule.DtVehicule = AdoVehicule.Dslocation.Tables[0];
            this.dataGridViewVehicule.DataSource = AdoVehicule.DtVehicule;

            // selectionner les premiers elements des combobox de la partie voiture
            comboMarque.SelectedItem = comboMarque.Items[0];
            comboModele.SelectedItem = comboModele.Items[0];
            comboAnnee.SelectedItem = comboAnnee.Items[0];
            comboCouleur.SelectedItem = comboCouleur.Items[0];
            comboCategorie.SelectedItem = comboCategorie.Items[0];
            ConnectionLocation(0);


        }
        /// <summary>
        /// méthode pour le bouton de soumission du client qui permet
        /// d'ajouter un client à la base de donnée suite à la vérification des entrées et ensuite l'affiche
        /// </summary>
        private void btnSoumettre_Click(object sender, EventArgs e)
        {

            VerificationEntree();
            /*
             * Code à executer si on désire pas une base SQL
            foreach (string Clef in Client.dicClient.Keys)
            {
                if (Clef == txtNoPermis.Text)
                {
                    MessageErreur += "\nUn autre client existe avec le même numéro de permis";
                }
            }
            */


            i = TrouverIndexRow(txtNoPermis.Text);
            if (i != -1)
            {
                MessageErreur += "\nUn autre client existe avec le même numéro de permis";
            }




            if (MessageErreur == "")
            {
                // ajout dans dataview
                // inspiré du laboratoire ADO.NET : Mode déconnecté ou indirect
                DataRow UnClient = Ado.DtClient.NewRow();
                UnClient[0] = txtNoPermis.Text.Trim();
                UnClient[1] = txtNom.Text.Trim();
                UnClient[2] = txtPrenom.Text.Trim();
                UnClient[3] = dateTimePicker.Value;
                UnClient[4] = txtCourriel.Text.Trim();
                UnClient[5] = txtTel.Text.Trim();
                UnClient[6] = txtAdresse.Text.Trim();
                Ado.DtClient.Rows.Add(UnClient);


                //Possibilité d'utiliser le programme sans base de donnée SQL
                Client nouveauClient = new Client(txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTel.Text, txtCourriel.Text, txtNoPermis.Text, dateTimePicker.Value);
                //Client.AjouterClient(nouveauClient);
                lblDeLobjet.Text = nouveauClient.ToString();
            }
            if (MessageErreur != "")
            {
                lblDeLobjet.Visible = false;
                lblErreur.Text = MessageErreur;
                MessageErreur = "";
                lblErreur.Visible = true;
            }

        }
        /// <summary>
        /// méthode pour trouver si l'objet existe dans la liste des clients et retourne l'index
        /// </summary>
        /// <param name="p_noPermis">numéro du permis du client</param>
        /// <returns>index du client ou -1 si il n'a pas été trouvé</returns>
        private int TrouverIndexRow(string p_noPermis)
        {

            for (int i = 0; i < Ado.DtClient.Rows.Count; i++)
            {
                if (p_noPermis == Ado.DtClient.Rows[i][0].ToString())
                {
                    return i;
                }
            }

            return -1;
        }
        /// <summary>
        /// méthode pour trouver si l'objet existe dans la liste des véhicules et retourne l'index
        /// </summary>
        /// <param name="p_noPermis">numéro du permis du véhicules</param>
        /// <returns>index du véhicule ou -1 si il n'a pas été trouvé</returns>
        private int TrouverIndexRowVehicule(string p_idVehicule)
        {
            for (int i = 0; i < AdoVehicule.DtVehicule.Rows.Count; i++)
            {
                if (p_idVehicule == AdoVehicule.DtVehicule.Rows[i][0].ToString())
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// méthode pour le bouton ajouter qui permet d'ajouter un véhicule à la base de donnée et l'affiche ensuite après plusieurs validations
        /// </summary>

        private void BtnAjouterVehicule_Click(object sender, EventArgs e)
        {

            MessageErreur = "";

            i = TrouverIndexRowVehicule(txtIDvehicule.Text.Trim());
            if (i != -1)
            {
                MessageErreur += "\nUn autre véhicule existe avec le même numéro de permis";
            }
            if (txtIDvehicule.Text.Length != 5)
            {

                MessageErreur += "\nLe ID du véhicule devrait être 5 charactère";
            }

            if (MessageErreur == "")
            {
                // ajout dans dataview
                // inspiré du laboratoire ADO.NET : Mode déconnecté ou indirect
                DataRow unVehicule = AdoVehicule.DtVehicule.NewRow();
                unVehicule[0] = txtIDvehicule.Text.Trim();
                unVehicule[1] = comboMarque.Text.Trim();
                unVehicule[2] = comboModele.Text.Trim();
                unVehicule[3] = comboAnnee.Text.Trim();
                unVehicule[4] = comboCouleur.Text.Trim();
                unVehicule[5] = int.Parse(txtKilometrage.Text.Trim()); ;
                unVehicule[6] = comboCategorie.Text.Trim();
                AdoVehicule.DtVehicule.Rows.Add(unVehicule);

            }
            if (MessageErreur != "")
            {
                lblDeLobjet.Visible = false;
                lblErreurVehicule.Text = MessageErreur;
                MessageErreur = "";
                lblErreurVehicule.Visible = true;
            }

        }

        /// <summary>
        /// méthode pour le bouton supprimer qui permet de supprimer un client dans la base de donnée suite à plusieurs vérification
        /// </summary>

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string BarreTitre = "Supprimer un client";
            /*
             Possibilité d'utiliser le programme sans base de donnée SQL
             bool Flag = false;
             string BarreTitre = "Supprimer un client";
             Flag = Client.SupprimerClient(txtNoPermis.Text);
             if (!Flag)
             {
                 string Message = "Le client n'a pu être supprimé. Vérifiez le numéro du permis et recommencez.";
                 MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtNoPermis.Focus();
             }
            */

            i = TrouverIndexRow(txtNoPermis.Text);
            if (i != -1)
            {
                Ado.DtClient.Rows[i].Delete();
                MessageBox.Show("Le client a été supprimé avec succès.", BarreTitre);
            }
            else
            {
                string Message = "Le client n'a pu être supprimé. Vérifiez le numéro du permis et recommencez.";
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPermis.Focus();
            }

        }
        /// <summary>
        /// méthode pour le bouton supprimer qui permet de supprimer un véhicule dans la base de donnée suite à plusieurs vérification
        /// </summary>
        private void BtnSupprimerVehicule_Click(object sender, EventArgs e)
        {
            string BarreTitre = "Supprimer un vehicule";

            i = TrouverIndexRowVehicule(txtIDvehicule.Text);
            if (i != -1)
            {
                AdoVehicule.DtVehicule.Rows[i].Delete();
                MessageBox.Show("Le vehicule a été supprimé avec succès.", BarreTitre);
            }
            else
            {
                string Message = "Le vehicule n'a pu être supprimé. Vérifiez le ID du véhicule et recommencez.";
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPermis.Focus();
            }

        }
        /// <summary>
        /// méthode pour le bouton modifier qui permet de modifier un client la base de donnée suite à la vérification des entrées et ensuite l'affiche le changement
        /// </summary>
        private void BtnModifier_Click(object sender, EventArgs e)
        {

            bool Flag = false;
            bool Flag2 = false;
            string BarreTitre = "Modifier un client";
            if (txtNoPermis.Text == "")
            {
                Flag2 = true;
                string Message = "Le client n'a pu être Modifier. Aucun numéro de permis détecté.";
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPermis.Focus();
            }
            VerificationEntree();
            if (MessageErreur == "" && Flag2 == false)
            {
                Client modificationClient = new Client(txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtTel.Text, txtCourriel.Text, txtNoPermis.Text, dateTimePicker.Value);
                //Flag = Client.ModifierClient(txtNoPermis.Text, modificationClient);
                foreach (DataRow row in Ado.DtClient.Rows)
                {
                    // inspiré du laboratoire ADO.NET : Mode déconnecté ou indirect 
                    if (row[0].ToString() == txtNoPermis.Text)
                    {
                        Flag = true;
                    }
                }
                if (!Flag)
                {
                    string Message = "Le client n'a pu être Modifier. Vérifiez le numéro du permis et recommencez.";
                    MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoPermis.Focus();
                }
                else
                {
                    i = TrouverIndexRow(txtNoPermis.Text);
                    if (i != -1)
                    {
                        Ado.DtClient.Rows[i][1] = txtNom.Text.Trim();
                        Ado.DtClient.Rows[i][2] = txtPrenom.Text.Trim();
                        Ado.DtClient.Rows[i][3] = dateTimePicker.Value;
                        Ado.DtClient.Rows[i][4] = txtCourriel.Text.Trim();
                        Ado.DtClient.Rows[i][5] = txtTel.Text.Trim();
                        Ado.DtClient.Rows[i][6] = txtAdresse.Text.Trim();
                    }
                    else
                    {
                        string Message = "Le client n'a pu être modifié. Vérifiez le numéro du permis et recommencez.";
                        MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNoPermis.Focus();
                    }



                    MessageBox.Show("Le client a été modifier avec succès.", BarreTitre);
                    lblDeLobjet.Text = modificationClient.ToString();
                    lblDeLobjet.Visible = true;
                }

            }

        }

        /// <summary>
        /// méthode pour le bouton sauvegarder qui permet de sauver tout les changements dans le programme à la base de données 
        /// </summary>
        private void BtnSauvegarder_Click(object sender, EventArgs e)
        {
            // inspiré du laboratoire ADO.NET : Mode déconnecté ou indirect
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                Ado.Adapter.Update(Ado.Dslocation, Ado.DtClient.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// méthode pour la recherche du client avec le numéro du permit ensuite l'affichage des informations de celui-ci 
        /// </summary>
        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            string BarreTitre = "Rechercher un client";
            i = TrouverIndexRow(txtRechercher.Text);
            if (i != -1)
            {

                string Message = string.Format("Nom client: {0}\nPrenom du client: {1}\nAdresse client: {2}\nTelephone client: {3}" +
            "\nCourriel client: {4}\nNo Permis client: {5}\nDate naissance client: {6}", Ado.DtClient.Rows[i][1].ToString(), Ado.DtClient.Rows[i][2].ToString(), Ado.DtClient.Rows[i][6].ToString(), Ado.DtClient.Rows[i][5].ToString(), Ado.DtClient.Rows[i][4].ToString(), Ado.DtClient.Rows[i][0].ToString(), Ado.DtClient.Rows[i][3].ToString());
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                string Message = "Le client n'a pu être modifié. Vérifiez le numéro du permis et recommencez.";
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPermis.Focus();
            }
        }

        /// <summary>
        /// méthode pour le bouton sauvegarder qui permet de sauver tout les changements dans le programme à la base de données 
        /// </summary>
        private void BtnSauvegarderVehicule_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(AdoVehicule.Adapter);
                AdoVehicule.Adapter.Update(AdoVehicule.Dslocation, Ado.DtClient.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// bouton modifier qui permet de modifier un véhicule de la base de donnée suite à la vérification des entrées et ensuite l'affiche le changement
        /// </summary>
        private void Btn_modiferVehicule_click(object sender, EventArgs e)
        {

            bool Flag = false;
            string BarreTitre = "Modifier une voiture";
            if (txtKilometrage.Text == "" || txtIDvehicule.Text == "")
            {
                Flag = true;
                string Message = "La voiture n'a pu être modifié. Veuillez entrer une valeur pour le nombre de kilométre et le id du véhicule";
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPermis.Focus();
            }
            else if (!txtKilometrage.Text.All(Char.IsDigit))
            {
                Flag = true;
                string Message = "Veuillez entrer un nombre de kilometrage composé de chiffre";
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPermis.Focus();
            }
            if (Flag == false)
            {
                // Vehicule modificationVehicule = new Vehicule(); à travailler
                //Flag = Client.ModifierClient(txtNoPermis.Text, modificationClient);
                i = TrouverIndexRowVehicule(txtIDvehicule.Text.Trim());
                if (i == -1)
                {
                    string Message = "La voiture été trouvé. Vérifiez le ID de la voiture et recommencez.";
                    MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoPermis.Focus();
                }
                else
                {

                    AdoVehicule.DtVehicule.Rows[i][1] = comboMarque.Text.Trim();
                    AdoVehicule.DtVehicule.Rows[i][2] = comboModele.Text.Trim();
                    AdoVehicule.DtVehicule.Rows[i][3] = comboAnnee.Text.Trim();
                    AdoVehicule.DtVehicule.Rows[i][4] = comboCouleur.Text.Trim();
                    AdoVehicule.DtVehicule.Rows[i][5] = int.Parse(txtKilometrage.Text.Trim());
                    AdoVehicule.DtVehicule.Rows[i][6] = comboCategorie.Text.Trim();


                    MessageBox.Show("La voiture a été modifier avec succès.", BarreTitre);
                    //lblDeLobjet.Text = modificationClient.ToString(); à travailler
                    lblDeLobjet.Visible = true;
                }

            }


        }

        private void BtnAjouterLocation_Click(object sender, EventArgs e)
        {




            DataRow uneLocation = AdoVehicule.DtVehicule.NewRow();
            uneLocation[0] = txtIDvehicule.Text.Trim();
            uneLocation[1] = comboMarque.Text.Trim();
            uneLocation[2] = comboModele.Text.Trim();
            uneLocation[3] = comboAnnee.Text.Trim();
            uneLocation[4] = comboCouleur.Text.Trim();
            uneLocation[5] = int.Parse(txtKilometrage.Text.Trim()); ;
            uneLocation[6] = comboCategorie.Text.Trim();
            AdoLocation.DtLocation.Rows.Add(uneLocation);
        }

        private void BtnFiltrer_Click(object sender, EventArgs e)
        {
            if (txtKmMin.Text == "" && txtKmMax.Text == "")
            {
                MessageBox.Show(("Veuillez entrer une valeur dans un des champs"), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtKmMin.Text != "" && txtKmMax.Text == "")
            {
                if (txtKmMin.Text.Trim().All(Char.IsDigit))
                {
                    ConnectionLocation(1);

                }
                else
                {
                    MessageBox.Show(("Veuillez entrer une valeur composé de chiffre"), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtKmMax.Text != "" && txtKmMin.Text == "")
            {
                if (txtKmMin.Text.Trim().All(Char.IsDigit))
                {
                    ConnectionLocation(2);

                }
                else
                {
                    MessageBox.Show(("Veuillez entrer une valeur composé de chiffre"), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtKmMax.Text != "" && txtKmMin.Text != "")
            {
                if (txtKmMin.Text.Trim().All(Char.IsDigit) && txtKmMax.Text.Trim().All(Char.IsDigit))
                {
                    ConnectionLocation(3);

                }
                else
                {
                    MessageBox.Show(("Veuillez entrer une valeur composé de chiffre"), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

