namespace LocationVoiture
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LocationTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.BtnSauvegarder = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblErreur = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoPermis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblDeLobjet = new System.Windows.Forms.Label();
            this.btnSoumettre = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDvehicule = new System.Windows.Forms.TextBox();
            this.btnSauvegarderVehicule = new System.Windows.Forms.Button();
            this.dataGridViewVehicule = new System.Windows.Forms.DataGridView();
            this.comboMarque = new System.Windows.Forms.ComboBox();
            this.comboModele = new System.Windows.Forms.ComboBox();
            this.comboAnnee = new System.Windows.Forms.ComboBox();
            this.comboCouleur = new System.Windows.Forms.ComboBox();
            this.comboCategorie = new System.Windows.Forms.ComboBox();
            this.btnModifierVéhicule = new System.Windows.Forms.Button();
            this.BtnSupprimerVehicule = new System.Windows.Forms.Button();
            this.lblErreurVehicule = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtKilometrage = new System.Windows.Forms.TextBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblModele = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblVehicule = new System.Windows.Forms.Label();
            this.BtnAjouterVehicule = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BtnFiltrer = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtKmMax = new System.Windows.Forms.TextBox();
            this.txtKmMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNoConducteur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDVehiculeLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKmLocation = new System.Windows.Forms.TextBox();
            this.BtnAjouterLocation = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationVoitureDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationVoitureDataSet = new LocationVoiture.LocationVoitureDataSet();
            this.datasetVehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new LocationVoiture.LocationVoitureDataSetTableAdapters.clientTableAdapter();
            this.vehiculeTableAdapter = new LocationVoiture.LocationVoitureDataSetTableAdapters.VehiculeTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIDLocation = new System.Windows.Forms.TextBox();
            this.LocationTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicule)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationVoitureDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationVoitureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationTab
            // 
            this.LocationTab.Controls.Add(this.tabPage1);
            this.LocationTab.Controls.Add(this.tabPage2);
            this.LocationTab.Controls.Add(this.tabPage3);
            this.LocationTab.Location = new System.Drawing.Point(12, 12);
            this.LocationTab.Name = "LocationTab";
            this.LocationTab.SelectedIndex = 0;
            this.LocationTab.Size = new System.Drawing.Size(1064, 543);
            this.LocationTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRechercher);
            this.tabPage1.Controls.Add(this.BtnRechercher);
            this.tabPage1.Controls.Add(this.BtnSauvegarder);
            this.tabPage1.Controls.Add(this.dataGridViewClient);
            this.tabPage1.Controls.Add(this.BtnModifier);
            this.tabPage1.Controls.Add(this.btnSupprimer);
            this.tabPage1.Controls.Add(this.lblErreur);
            this.tabPage1.Controls.Add(this.dateTimePicker);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtNoPermis);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCourriel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtAdresse);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPrenom);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNom);
            this.tabPage1.Controls.Add(this.lblDeLobjet);
            this.tabPage1.Controls.Add(this.btnSoumettre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(478, 315);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(114, 20);
            this.txtRechercher.TabIndex = 23;
            this.txtRechercher.Text = "AAAA1231236";
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.Location = new System.Drawing.Point(478, 259);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(114, 50);
            this.BtnRechercher.TabIndex = 22;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // BtnSauvegarder
            // 
            this.BtnSauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSauvegarder.Location = new System.Drawing.Point(358, 259);
            this.BtnSauvegarder.Name = "BtnSauvegarder";
            this.BtnSauvegarder.Size = new System.Drawing.Size(114, 50);
            this.BtnSauvegarder.TabIndex = 21;
            this.BtnSauvegarder.Text = "Sauvegarder";
            this.BtnSauvegarder.UseVisualStyleBackColor = true;
            this.BtnSauvegarder.Click += new System.EventHandler(this.BtnSauvegarder_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(31, 343);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(842, 150);
            this.dataGridViewClient.TabIndex = 20;
            // 
            // BtnModifier
            // 
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Location = new System.Drawing.Point(140, 259);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(103, 50);
            this.BtnModifier.TabIndex = 19;
            this.BtnModifier.Text = "Modifier un client";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(249, 259);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(103, 50);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer un client";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(313, 61);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(35, 13);
            this.lblErreur.TabIndex = 17;
            this.lblErreur.Text = "Erreur";
            this.lblErreur.Visible = false;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(130, 233);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker.TabIndex = 16;
            this.dateTimePicker.Value = new System.DateTime(1995, 12, 18, 19, 34, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date naissance :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Numero de permis :";
            // 
            // txtNoPermis
            // 
            this.txtNoPermis.Location = new System.Drawing.Point(130, 204);
            this.txtNoPermis.Name = "txtNoPermis";
            this.txtNoPermis.Size = new System.Drawing.Size(179, 20);
            this.txtNoPermis.TabIndex = 12;
            this.txtNoPermis.Text = "AAAA1231236";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Courriel :";
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(130, 178);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(179, 20);
            this.txtCourriel.TabIndex = 10;
            this.txtCourriel.Text = "exemple@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Téléphone :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(130, 152);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(179, 20);
            this.txtTel.TabIndex = 8;
            this.txtTel.Text = "1231231234";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresse :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(130, 126);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(179, 20);
            this.txtAdresse.TabIndex = 6;
            this.txtAdresse.Text = "13 exemple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prenom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(130, 100);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(179, 20);
            this.txtPrenom.TabIndex = 4;
            this.txtPrenom.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 74);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(179, 20);
            this.txtNom.TabIndex = 2;
            this.txtNom.Text = "nom";
            // 
            // lblDeLobjet
            // 
            this.lblDeLobjet.AutoSize = true;
            this.lblDeLobjet.Location = new System.Drawing.Point(316, 74);
            this.lblDeLobjet.Name = "lblDeLobjet";
            this.lblDeLobjet.Size = new System.Drawing.Size(32, 13);
            this.lblDeLobjet.TabIndex = 1;
            this.lblDeLobjet.Text = "Objet";
            this.lblDeLobjet.Visible = false;
            // 
            // btnSoumettre
            // 
            this.btnSoumettre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoumettre.Location = new System.Drawing.Point(31, 259);
            this.btnSoumettre.Name = "btnSoumettre";
            this.btnSoumettre.Size = new System.Drawing.Size(103, 50);
            this.btnSoumettre.TabIndex = 0;
            this.btnSoumettre.Text = "Crée un client";
            this.btnSoumettre.UseVisualStyleBackColor = true;
            this.btnSoumettre.Click += new System.EventHandler(this.btnSoumettre_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtIDvehicule);
            this.tabPage2.Controls.Add(this.btnSauvegarderVehicule);
            this.tabPage2.Controls.Add(this.dataGridViewVehicule);
            this.tabPage2.Controls.Add(this.comboMarque);
            this.tabPage2.Controls.Add(this.comboModele);
            this.tabPage2.Controls.Add(this.comboAnnee);
            this.tabPage2.Controls.Add(this.comboCouleur);
            this.tabPage2.Controls.Add(this.comboCategorie);
            this.tabPage2.Controls.Add(this.btnModifierVéhicule);
            this.tabPage2.Controls.Add(this.BtnSupprimerVehicule);
            this.tabPage2.Controls.Add(this.lblErreurVehicule);
            this.tabPage2.Controls.Add(this.lblCategorie);
            this.tabPage2.Controls.Add(this.lblKm);
            this.tabPage2.Controls.Add(this.txtKilometrage);
            this.tabPage2.Controls.Add(this.lblCouleur);
            this.tabPage2.Controls.Add(this.lblAnnee);
            this.tabPage2.Controls.Add(this.lblModele);
            this.tabPage2.Controls.Add(this.lblMarque);
            this.tabPage2.Controls.Add(this.lblVehicule);
            this.tabPage2.Controls.Add(this.BtnAjouterVehicule);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vehicule";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "ID véhicule";
            // 
            // txtIDvehicule
            // 
            this.txtIDvehicule.Location = new System.Drawing.Point(137, 204);
            this.txtIDvehicule.Name = "txtIDvehicule";
            this.txtIDvehicule.Size = new System.Drawing.Size(179, 20);
            this.txtIDvehicule.TabIndex = 48;
            this.txtIDvehicule.Text = "123123";
            // 
            // btnSauvegarderVehicule
            // 
            this.btnSauvegarderVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauvegarderVehicule.Location = new System.Drawing.Point(365, 230);
            this.btnSauvegarderVehicule.Name = "btnSauvegarderVehicule";
            this.btnSauvegarderVehicule.Size = new System.Drawing.Size(114, 50);
            this.btnSauvegarderVehicule.TabIndex = 45;
            this.btnSauvegarderVehicule.Text = "Sauvegarder";
            this.btnSauvegarderVehicule.UseVisualStyleBackColor = true;
            this.btnSauvegarderVehicule.Click += new System.EventHandler(this.BtnSauvegarderVehicule_Click);
            // 
            // dataGridViewVehicule
            // 
            this.dataGridViewVehicule.AllowUserToAddRows = false;
            this.dataGridViewVehicule.AllowUserToDeleteRows = false;
            this.dataGridViewVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicule.Location = new System.Drawing.Point(27, 339);
            this.dataGridViewVehicule.Name = "dataGridViewVehicule";
            this.dataGridViewVehicule.ReadOnly = true;
            this.dataGridViewVehicule.Size = new System.Drawing.Size(838, 150);
            this.dataGridViewVehicule.TabIndex = 44;
            // 
            // comboMarque
            // 
            this.comboMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarque.FormattingEnabled = true;
            this.comboMarque.Items.AddRange(new object[] {
            "Marque A",
            "Marque B",
            "Marque C",
            "Marque D",
            "Marque E",
            "Marque F"});
            this.comboMarque.Location = new System.Drawing.Point(137, 45);
            this.comboMarque.Name = "comboMarque";
            this.comboMarque.Size = new System.Drawing.Size(179, 21);
            this.comboMarque.TabIndex = 43;
            // 
            // comboModele
            // 
            this.comboModele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModele.FormattingEnabled = true;
            this.comboModele.Items.AddRange(new object[] {
            "Modèle A",
            "Modèle B",
            "Modèle C",
            "Modèle D",
            "Modèle E",
            "Modèle F"});
            this.comboModele.Location = new System.Drawing.Point(137, 71);
            this.comboModele.Name = "comboModele";
            this.comboModele.Size = new System.Drawing.Size(179, 21);
            this.comboModele.TabIndex = 42;
            // 
            // comboAnnee
            // 
            this.comboAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnnee.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.comboAnnee.Location = new System.Drawing.Point(137, 96);
            this.comboAnnee.Name = "comboAnnee";
            this.comboAnnee.Size = new System.Drawing.Size(179, 21);
            this.comboAnnee.TabIndex = 41;
            // 
            // comboCouleur
            // 
            this.comboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCouleur.FormattingEnabled = true;
            this.comboCouleur.Items.AddRange(new object[] {
            "Blanc",
            "Bleu",
            "Noir",
            "Rouge",
            "Vert"});
            this.comboCouleur.Location = new System.Drawing.Point(137, 123);
            this.comboCouleur.Name = "comboCouleur";
            this.comboCouleur.Size = new System.Drawing.Size(179, 21);
            this.comboCouleur.Sorted = true;
            this.comboCouleur.TabIndex = 40;
            // 
            // comboCategorie
            // 
            this.comboCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategorie.FormattingEnabled = true;
            this.comboCategorie.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboCategorie.Location = new System.Drawing.Point(137, 152);
            this.comboCategorie.Name = "comboCategorie";
            this.comboCategorie.Size = new System.Drawing.Size(179, 21);
            this.comboCategorie.TabIndex = 39;
            // 
            // btnModifierVéhicule
            // 
            this.btnModifierVéhicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierVéhicule.Location = new System.Drawing.Point(147, 230);
            this.btnModifierVéhicule.Name = "btnModifierVéhicule";
            this.btnModifierVéhicule.Size = new System.Drawing.Size(103, 50);
            this.btnModifierVéhicule.TabIndex = 38;
            this.btnModifierVéhicule.Text = "Modifier un véhicule";
            this.btnModifierVéhicule.UseVisualStyleBackColor = true;
            this.btnModifierVéhicule.Click += new System.EventHandler(this.Btn_modiferVehicule_click);
            // 
            // BtnSupprimerVehicule
            // 
            this.BtnSupprimerVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimerVehicule.Location = new System.Drawing.Point(256, 230);
            this.BtnSupprimerVehicule.Name = "BtnSupprimerVehicule";
            this.BtnSupprimerVehicule.Size = new System.Drawing.Size(103, 50);
            this.BtnSupprimerVehicule.TabIndex = 37;
            this.BtnSupprimerVehicule.Text = "Supprimer un véhicule";
            this.BtnSupprimerVehicule.UseVisualStyleBackColor = true;
            this.BtnSupprimerVehicule.Click += new System.EventHandler(this.BtnSupprimerVehicule_Click);
            // 
            // lblErreurVehicule
            // 
            this.lblErreurVehicule.AutoSize = true;
            this.lblErreurVehicule.ForeColor = System.Drawing.Color.Red;
            this.lblErreurVehicule.Location = new System.Drawing.Point(320, 32);
            this.lblErreurVehicule.Name = "lblErreurVehicule";
            this.lblErreurVehicule.Size = new System.Drawing.Size(35, 13);
            this.lblErreurVehicule.TabIndex = 36;
            this.lblErreurVehicule.Text = "Erreur";
            this.lblErreurVehicule.Visible = false;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(35, 152);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 33;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(36, 182);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(65, 13);
            this.lblKm.TabIndex = 31;
            this.lblKm.Text = "Kilométrage ";
            // 
            // txtKilometrage
            // 
            this.txtKilometrage.Location = new System.Drawing.Point(137, 179);
            this.txtKilometrage.Name = "txtKilometrage";
            this.txtKilometrage.Size = new System.Drawing.Size(179, 20);
            this.txtKilometrage.TabIndex = 30;
            this.txtKilometrage.Text = "1";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(36, 126);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(49, 13);
            this.lblCouleur.TabIndex = 29;
            this.lblCouleur.Text = "Couleur :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(36, 100);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(44, 13);
            this.lblAnnee.TabIndex = 27;
            this.lblAnnee.Text = "Année :";
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Location = new System.Drawing.Point(35, 74);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(48, 13);
            this.lblModele.TabIndex = 25;
            this.lblModele.Text = "Modèle :";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(35, 48);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(49, 13);
            this.lblMarque.TabIndex = 23;
            this.lblMarque.Text = "Marque :";
            // 
            // lblVehicule
            // 
            this.lblVehicule.AutoSize = true;
            this.lblVehicule.Location = new System.Drawing.Point(323, 45);
            this.lblVehicule.Name = "lblVehicule";
            this.lblVehicule.Size = new System.Drawing.Size(32, 13);
            this.lblVehicule.TabIndex = 21;
            this.lblVehicule.Text = "Objet";
            this.lblVehicule.Visible = false;
            // 
            // BtnAjouterVehicule
            // 
            this.BtnAjouterVehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouterVehicule.Location = new System.Drawing.Point(38, 230);
            this.BtnAjouterVehicule.Name = "BtnAjouterVehicule";
            this.BtnAjouterVehicule.Size = new System.Drawing.Size(103, 50);
            this.BtnAjouterVehicule.TabIndex = 20;
            this.BtnAjouterVehicule.Text = "Ajouter véhicule";
            this.BtnAjouterVehicule.UseVisualStyleBackColor = true;
            this.BtnAjouterVehicule.Click += new System.EventHandler(this.BtnAjouterVehicule_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtIDLocation);
            this.tabPage3.Controls.Add(this.BtnFiltrer);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtKmMax);
            this.tabPage3.Controls.Add(this.txtKmMin);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtNoConducteur);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtIDVehiculeLocation);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridViewLocation);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtKmLocation);
            this.tabPage3.Controls.Add(this.BtnAjouterLocation);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1056, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Location";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BtnFiltrer
            // 
            this.BtnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrer.Location = new System.Drawing.Point(397, 130);
            this.BtnFiltrer.Name = "BtnFiltrer";
            this.BtnFiltrer.Size = new System.Drawing.Size(164, 29);
            this.BtnFiltrer.TabIndex = 77;
            this.BtnFiltrer.Text = "Filtrer";
            this.BtnFiltrer.UseVisualStyleBackColor = true;
            this.BtnFiltrer.Click += new System.EventHandler(this.BtnFiltrer_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Kilométrage maximum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(374, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "Kilométrage minimum";
            // 
            // txtKmMax
            // 
            this.txtKmMax.Location = new System.Drawing.Point(494, 89);
            this.txtKmMax.Name = "txtKmMax";
            this.txtKmMax.Size = new System.Drawing.Size(80, 20);
            this.txtKmMax.TabIndex = 74;
            this.txtKmMax.Text = "1";
            // 
            // txtKmMin
            // 
            this.txtKmMin.Location = new System.Drawing.Point(494, 57);
            this.txtKmMin.Name = "txtKmMin";
            this.txtKmMin.Size = new System.Drawing.Size(80, 20);
            this.txtKmMin.TabIndex = 73;
            this.txtKmMin.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(349, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(522, 31);
            this.label10.TabIndex = 72;
            this.label10.Text = "Filtre du nombre de km que le client a fait :";
            // 
            // txtNoConducteur
            // 
            this.txtNoConducteur.Location = new System.Drawing.Point(137, 31);
            this.txtNoConducteur.Name = "txtNoConducteur";
            this.txtNoConducteur.Size = new System.Drawing.Size(179, 20);
            this.txtNoConducteur.TabIndex = 71;
            this.txtNoConducteur.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "ID véhicule";
            // 
            // txtIDVehiculeLocation
            // 
            this.txtIDVehiculeLocation.Location = new System.Drawing.Point(137, 86);
            this.txtIDVehiculeLocation.Name = "txtIDVehiculeLocation";
            this.txtIDVehiculeLocation.Size = new System.Drawing.Size(179, 20);
            this.txtIDVehiculeLocation.TabIndex = 69;
            this.txtIDVehiculeLocation.Text = "123123";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 50);
            this.button1.TabIndex = 68;
            this.button1.Text = "Sauvegarder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLocation
            // 
            this.dataGridViewLocation.AllowUserToAddRows = false;
            this.dataGridViewLocation.AllowUserToDeleteRows = false;
            this.dataGridViewLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocation.Location = new System.Drawing.Point(26, 332);
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.ReadOnly = true;
            this.dataGridViewLocation.Size = new System.Drawing.Size(838, 150);
            this.dataGridViewLocation.TabIndex = 67;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(137, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 50);
            this.button2.TabIndex = 61;
            this.button2.Text = "Modifier une location";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(246, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 50);
            this.button3.TabIndex = 60;
            this.button3.Text = "Supprimer une location";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "No permis du conducteur";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Kilométrage ";
            // 
            // txtKmLocation
            // 
            this.txtKmLocation.Location = new System.Drawing.Point(137, 61);
            this.txtKmLocation.Name = "txtKmLocation";
            this.txtKmLocation.Size = new System.Drawing.Size(179, 20);
            this.txtKmLocation.TabIndex = 56;
            this.txtKmLocation.Text = "1";
            // 
            // BtnAjouterLocation
            // 
            this.BtnAjouterLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouterLocation.Location = new System.Drawing.Point(38, 223);
            this.BtnAjouterLocation.Name = "BtnAjouterLocation";
            this.BtnAjouterLocation.Size = new System.Drawing.Size(103, 50);
            this.BtnAjouterLocation.TabIndex = 50;
            this.BtnAjouterLocation.Text = "Ajouter location";
            this.BtnAjouterLocation.UseVisualStyleBackColor = true;
            this.BtnAjouterLocation.Click += new System.EventHandler(this.BtnAjouterLocation_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.locationVoitureDataSetBindingSource;
            // 
            // locationVoitureDataSetBindingSource
            // 
            this.locationVoitureDataSetBindingSource.DataSource = this.locationVoitureDataSet;
            this.locationVoitureDataSetBindingSource.Position = 0;
            // 
            // locationVoitureDataSet
            // 
            this.locationVoitureDataSet.DataSetName = "LocationVoitureDataSet";
            this.locationVoitureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataMember = "Vehicule";
            this.vehiculeBindingSource.DataSource = this.locationVoitureDataSetBindingSource;
            // 
            // vehiculeBindingSource1
            // 
            this.vehiculeBindingSource1.DataMember = "Vehicule";
            this.vehiculeBindingSource1.DataSource = this.locationVoitureDataSetBindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculeTableAdapter
            // 
            this.vehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "ID Location";
            // 
            // txtIDLocation
            // 
            this.txtIDLocation.Location = new System.Drawing.Point(137, 112);
            this.txtIDLocation.Name = "txtIDLocation";
            this.txtIDLocation.Size = new System.Drawing.Size(179, 20);
            this.txtIDLocation.TabIndex = 78;
            this.txtIDLocation.Text = "123123";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 558);
            this.Controls.Add(this.LocationTab);
            this.Name = "main";
            this.Text = "Gestionnaire de locaiton de voiture";
            this.Load += new System.EventHandler(this.main_Load);
            this.LocationTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicule)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationVoitureDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationVoitureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetVehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LocationTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoPermis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblDeLobjet;
        private System.Windows.Forms.Button btnSoumettre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboMarque;
        private System.Windows.Forms.ComboBox comboModele;
        private System.Windows.Forms.ComboBox comboCouleur;
        private System.Windows.Forms.ComboBox comboCategorie;
        private System.Windows.Forms.Button btnModifierVéhicule;
        private System.Windows.Forms.Button BtnSupprimerVehicule;
        private System.Windows.Forms.Label lblErreurVehicule;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtKilometrage;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblVehicule;
        private System.Windows.Forms.Button BtnAjouterVehicule;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.BindingSource locationVoitureDataSetBindingSource;
        private LocationVoitureDataSet locationVoitureDataSet;
        private System.Windows.Forms.DataGridView dataGridViewVehicule;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private LocationVoitureDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button BtnSauvegarder;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.Button btnSauvegarderVehicule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDvehicule;
        private System.Windows.Forms.BindingSource datasetVehiculeBindingSource;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private LocationVoitureDataSetTableAdapters.VehiculeTableAdapter vehiculeTableAdapter;
        private System.Windows.Forms.BindingSource vehiculeBindingSource1;
        private System.Windows.Forms.ComboBox comboAnnee;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDVehiculeLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKmLocation;
        private System.Windows.Forms.Button BtnAjouterLocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKmMax;
        private System.Windows.Forms.TextBox txtKmMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNoConducteur;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnFiltrer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDLocation;
    }
}

