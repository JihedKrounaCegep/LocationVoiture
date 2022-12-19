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

namespace LocationVoiture
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            // Mettre les premiers parametre selectioné pour les combobox de la partie véhicule
            comboMarque.SelectedItem = comboMarque.Items[0];
            comboModele.SelectedItem = comboModele.Items[0];
            comboAnnee.SelectedItem = comboAnnee.Items[0];
            comboCouleur.SelectedItem = comboCouleur.Items[0];
            comboCategorie.SelectedItem = comboCategorie.Items[0];
        }
        int i;
        AdoNet Ado = new AdoNet();
        public string MessageErreur;
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

            if (!Client.ValiderAge(dateTimePicker.Value))
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
            string Query = "select * from client;";
            string Query2 = "select * from Vehicule;";
            Ado.Cmd.CommandText = Query;
            
            Ado.Cmd.Connection = Ado.Conn;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Dslocation);

            Ado.DtLocation = Ado.Dslocation.Tables[0];
            this.dataGridViewClient.DataSource = Ado.DtLocation;



            Ado.Cmd.CommandText = Query2;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.DsVehicule);
            Ado.DtVehicule = Ado.DsVehicule.Tables[0];
            this.dataGridViewVehicule.DataSource = Ado.DtVehicule;
            

        }
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
                DataRow UnClient = Ado.DtLocation.NewRow();
                UnClient[0] = txtNoPermis.Text.Trim();
                UnClient[1] = txtNom.Text.Trim();
                UnClient[2] = txtPrenom.Text.Trim();
                UnClient[3] = dateTimePicker.Value;
                UnClient[4] = txtCourriel.Text.Trim();
                UnClient[5] = txtTel.Text.Trim();
                UnClient[6] = txtAdresse.Text.Trim();
                Ado.DtLocation.Rows.Add(UnClient);


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
        private int TrouverIndexRow(string p_noPermis)
        {

            for (int i = 0; i < Ado.DtLocation.Rows.Count; i++)
            {
                if (p_noPermis == Ado.DtLocation.Rows[i][0].ToString())
                {
                    return i;
                }
            }

            return -1;
        }
        private int TrouverIndexRowVehicule(string p_idVehicule)
        {
            for (int i = 0; i < Ado.DtVehicule.Rows.Count; i++)
            {
                if (p_idVehicule == Ado.DtVehicule.Rows[i][0].ToString())
                {
                    return i;
                }
            }

            return -1;
        }
        private void BtnAjouterVehicule_Click_1(object sender, EventArgs e)
        {

            MessageErreur = "";
            
            i = TrouverIndexRowVehicule(txtIDvehicule.Text);
            if (i != -1)
            {
                MessageErreur += "\nUn autre véhicule existe avec le même numéro de permis";
            }
            //lblErreurVehicule

            if (MessageErreur == "")
            {
                // ajout dans dataview
                // inspiré du laboratoire ADO.NET : Mode déconnecté ou indirect
                DataRow unVehicule = Ado.DtLocation.NewRow();
                unVehicule[0] = txtIDvehicule.Text.Trim();
                unVehicule[1] = comboMarque.Text.Trim();
                unVehicule[2] = comboModele.Text.Trim();
                unVehicule[3] = DateTime.Parse(comboAnnee.Text.Trim());
                unVehicule[4] = comboCouleur.Text.Trim();
                unVehicule[5] = int.Parse(txtKilometrage.Text.Trim()); ;
                unVehicule[6] = txtAdresse.Text.Trim();
                unVehicule[7] = comboCategorie.Text.Trim();
                Ado.DtVehicule.Rows.Add(unVehicule);

            }
            if (MessageErreur != "")
            {
                lblDeLobjet.Visible = false;
                lblErreurVehicule.Text = MessageErreur;
                MessageErreur = "";
                lblErreurVehicule.Visible = true;
            }

        }
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
                Ado.DtLocation.Rows[i].Delete();
                MessageBox.Show("Le client a été supprimé avec succès.", BarreTitre);
            }
            else
            {
                string Message = "Le client n'a pu être supprimé. Vérifiez le numéro du permis et recommencez.";
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNoPermis.Focus();
            }

        }

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
                foreach (DataRow row in Ado.DtLocation.Rows)
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
                        Ado.DtLocation.Rows[i][1] = txtNom.Text.Trim();
                        Ado.DtLocation.Rows[i][2] = txtPrenom.Text.Trim();
                        Ado.DtLocation.Rows[i][3] = dateTimePicker.Value;
                        Ado.DtLocation.Rows[i][4] = txtCourriel.Text.Trim();
                        Ado.DtLocation.Rows[i][5] = txtTel.Text.Trim();
                        Ado.DtLocation.Rows[i][6] = txtAdresse.Text.Trim();
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


        private void BtnSauvegarder_Click(object sender, EventArgs e)
        {
            // inspiré du laboratoire ADO.NET : Mode déconnecté ou indirect
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                Ado.Adapter.Update(Ado.Dslocation, Ado.DtLocation.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            string BarreTitre = "Rechercher un client";
            i = TrouverIndexRow(txtRechercher.Text);
                if (i != -1)
                {
                
                string Message = string.Format("Nom client: {0}\nPrenom du client: {1}\nAdresse client: {2}\nTelephone client: {3}" +
            "\nCourriel client: {4}\nNo Permis client: {5}\nDate naissance client: {6}", Ado.DtLocation.Rows[i][1].ToString(), Ado.DtLocation.Rows[i][2].ToString(), Ado.DtLocation.Rows[i][6].ToString(), Ado.DtLocation.Rows[i][5].ToString(), Ado.DtLocation.Rows[i][4].ToString(), Ado.DtLocation.Rows[i][0].ToString(), Ado.DtLocation.Rows[i][3].ToString());
                MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    
                    string Message = "Le client n'a pu être modifié. Vérifiez le numéro du permis et recommencez.";
                    MessageBox.Show(Message, BarreTitre, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoPermis.Focus();
                }
            
        
        }

        

        
    }
}

