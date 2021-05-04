namespace GUI
{
    partial class FormComptabilite
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
            this.lblSetBudgetAS = new System.Windows.Forms.Label();
            this.lblSetBudgetEPS = new System.Windows.Forms.Label();
            this.txbBudgetEPS = new System.Windows.Forms.TextBox();
            this.txbBudgetAS = new System.Windows.Forms.TextBox();
            this.lblTitreCompta = new System.Windows.Forms.Label();
            this.btnSetBudgetEPS = new System.Windows.Forms.Button();
            this.btnSetBudgetAS = new System.Windows.Forms.Button();
            this.lblBudgetEPSInitial = new System.Windows.Forms.Label();
            this.lblBudgetASInitial = new System.Windows.Forms.Label();
            this.lblFiltreAdherant = new System.Windows.Forms.Label();
            this.tbxRechercheNomPrenom = new System.Windows.Forms.TextBox();
            this.lblFiltreClasse = new System.Windows.Forms.Label();
            this.lsbClasse = new System.Windows.Forms.ListBox();
            this.lblFiltrePrelevementAutorise = new System.Windows.Forms.Label();
            this.lblFiltreSweetPris = new System.Windows.Forms.Label();
            this.rdbPrelevementAutoriseOui = new System.Windows.Forms.RadioButton();
            this.rdbPrelevementAutoriseNon = new System.Windows.Forms.RadioButton();
            this.rdbSweetPrisNon = new System.Windows.Forms.RadioButton();
            this.rdbSweetPrisOui = new System.Windows.Forms.RadioButton();
            this.lblInformations = new System.Windows.Forms.Label();
            this.dtgDebit = new System.Windows.Forms.DataGridView();
            this.lblDebit = new System.Windows.Forms.Label();
            this.dtgCredit = new System.Windows.Forms.DataGridView();
            this.lblCredit = new System.Windows.Forms.Label();
            this.dtgFiltres = new System.Windows.Forms.DataGridView();
            this.lblResultats = new System.Windows.Forms.Label();
            this.btnFluxAjouter = new System.Windows.Forms.Button();
            this.btnFluxModifier = new System.Windows.Forms.Button();
            this.btnFluxSupprimer = new System.Windows.Forms.Button();
            this.dtgFluxAdherant = new System.Windows.Forms.DataGridView();
            this.lblFluxAdherant = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.gbxInfoAdherant = new System.Windows.Forms.GroupBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelParent = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMontantPrelevement = new System.Windows.Forms.Label();
            this.lblPrelevementAutorise = new System.Windows.Forms.Label();
            this.lblSweet = new System.Windows.Forms.Label();
            this.lblClasseAdherant = new System.Windows.Forms.Label();
            this.lblPrenomAdherant = new System.Windows.Forms.Label();
            this.lblNomAdherant = new System.Windows.Forms.Label();
            this.btnModifierBudgetEPS = new System.Windows.Forms.Button();
            this.btnModifierBudgetAS = new System.Windows.Forms.Button();
            this.btnEnvoyerModifEPS = new System.Windows.Forms.Button();
            this.btnAnnulerModifEPS = new System.Windows.Forms.Button();
            this.btnEnvoyerModifAS = new System.Windows.Forms.Button();
            this.btnAnnulerModifAS = new System.Windows.Forms.Button();
            this.lblSetBudgetEPSInitial = new System.Windows.Forms.Label();
            this.lblSetBudgetASInitial = new System.Windows.Forms.Label();
            this.lblBudgetAS = new System.Windows.Forms.Label();
            this.lblBudgetEPS = new System.Windows.Forms.Label();
            this.pnlPrelevementAutorise = new System.Windows.Forms.Panel();
            this.pnlSweetPris = new System.Windows.Forms.Panel();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDebit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFluxAdherant)).BeginInit();
            this.gbxInfoAdherant.SuspendLayout();
            this.pnlPrelevementAutorise.SuspendLayout();
            this.pnlSweetPris.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSetBudgetAS
            // 
            this.lblSetBudgetAS.AutoSize = true;
            this.lblSetBudgetAS.Location = new System.Drawing.Point(13, 122);
            this.lblSetBudgetAS.Name = "lblSetBudgetAS";
            this.lblSetBudgetAS.Size = new System.Drawing.Size(64, 13);
            this.lblSetBudgetAS.TabIndex = 0;
            this.lblSetBudgetAS.Text = "Budget AS :";
            // 
            // lblSetBudgetEPS
            // 
            this.lblSetBudgetEPS.AutoSize = true;
            this.lblSetBudgetEPS.Location = new System.Drawing.Point(13, 98);
            this.lblSetBudgetEPS.Name = "lblSetBudgetEPS";
            this.lblSetBudgetEPS.Size = new System.Drawing.Size(71, 13);
            this.lblSetBudgetEPS.TabIndex = 1;
            this.lblSetBudgetEPS.Text = "Budget EPS :";
            // 
            // txbBudgetEPS
            // 
            this.txbBudgetEPS.Location = new System.Drawing.Point(250, 93);
            this.txbBudgetEPS.Name = "txbBudgetEPS";
            this.txbBudgetEPS.Size = new System.Drawing.Size(71, 20);
            this.txbBudgetEPS.TabIndex = 1;
            this.txbBudgetEPS.Visible = false;
            this.txbBudgetEPS.TextChanged += new System.EventHandler(this.txbBudgetEPS_TextChanged);
            // 
            // txbBudgetAS
            // 
            this.txbBudgetAS.Location = new System.Drawing.Point(250, 119);
            this.txbBudgetAS.Name = "txbBudgetAS";
            this.txbBudgetAS.Size = new System.Drawing.Size(71, 20);
            this.txbBudgetAS.TabIndex = 2;
            this.txbBudgetAS.Visible = false;
            this.txbBudgetAS.TextChanged += new System.EventHandler(this.txbBudgetAS_TextChanged);
            // 
            // lblTitreCompta
            // 
            this.lblTitreCompta.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCompta.Location = new System.Drawing.Point(12, 9);
            this.lblTitreCompta.Name = "lblTitreCompta";
            this.lblTitreCompta.Size = new System.Drawing.Size(1104, 64);
            this.lblTitreCompta.TabIndex = 4;
            this.lblTitreCompta.Text = "Comptabilité";
            this.lblTitreCompta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetBudgetEPS
            // 
            this.btnSetBudgetEPS.Location = new System.Drawing.Point(324, 93);
            this.btnSetBudgetEPS.Name = "btnSetBudgetEPS";
            this.btnSetBudgetEPS.Size = new System.Drawing.Size(75, 20);
            this.btnSetBudgetEPS.TabIndex = 6;
            this.btnSetBudgetEPS.Text = "Envoyer";
            this.btnSetBudgetEPS.UseVisualStyleBackColor = true;
            this.btnSetBudgetEPS.Click += new System.EventHandler(this.btnSetBudgetEPS_Click);
            // 
            // btnSetBudgetAS
            // 
            this.btnSetBudgetAS.Location = new System.Drawing.Point(324, 119);
            this.btnSetBudgetAS.Name = "btnSetBudgetAS";
            this.btnSetBudgetAS.Size = new System.Drawing.Size(75, 20);
            this.btnSetBudgetAS.TabIndex = 7;
            this.btnSetBudgetAS.Text = "Envoyer";
            this.btnSetBudgetAS.UseVisualStyleBackColor = true;
            this.btnSetBudgetAS.Visible = false;
            this.btnSetBudgetAS.Click += new System.EventHandler(this.btnSetBudgetAS_Click);
            // 
            // lblBudgetEPSInitial
            // 
            this.lblBudgetEPSInitial.AutoSize = true;
            this.lblBudgetEPSInitial.Location = new System.Drawing.Point(250, 97);
            this.lblBudgetEPSInitial.Name = "lblBudgetEPSInitial";
            this.lblBudgetEPSInitial.Size = new System.Drawing.Size(13, 13);
            this.lblBudgetEPSInitial.TabIndex = 8;
            this.lblBudgetEPSInitial.Text = "0";
            this.lblBudgetEPSInitial.TextChanged += new System.EventHandler(this.lblBudgetEPSInitial_TextChanged);
            // 
            // lblBudgetASInitial
            // 
            this.lblBudgetASInitial.AutoSize = true;
            this.lblBudgetASInitial.Location = new System.Drawing.Point(250, 123);
            this.lblBudgetASInitial.Name = "lblBudgetASInitial";
            this.lblBudgetASInitial.Size = new System.Drawing.Size(13, 13);
            this.lblBudgetASInitial.TabIndex = 9;
            this.lblBudgetASInitial.Text = "0";
            this.lblBudgetASInitial.TextChanged += new System.EventHandler(this.lblBudgetASInitial_TextChanged);
            // 
            // lblFiltreAdherant
            // 
            this.lblFiltreAdherant.AutoSize = true;
            this.lblFiltreAdherant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltreAdherant.Location = new System.Drawing.Point(12, 151);
            this.lblFiltreAdherant.Name = "lblFiltreAdherant";
            this.lblFiltreAdherant.Size = new System.Drawing.Size(182, 25);
            this.lblFiltreAdherant.TabIndex = 10;
            this.lblFiltreAdherant.Text = "Filtre Adherant :";
            // 
            // tbxRechercheNomPrenom
            // 
            this.tbxRechercheNomPrenom.Location = new System.Drawing.Point(73, 188);
            this.tbxRechercheNomPrenom.Name = "tbxRechercheNomPrenom";
            this.tbxRechercheNomPrenom.Size = new System.Drawing.Size(134, 20);
            this.tbxRechercheNomPrenom.TabIndex = 12;
            this.tbxRechercheNomPrenom.TextChanged += new System.EventHandler(this.tbxRechercheNomPrenom_TextChanged);
            // 
            // lblFiltreClasse
            // 
            this.lblFiltreClasse.AutoSize = true;
            this.lblFiltreClasse.Location = new System.Drawing.Point(20, 232);
            this.lblFiltreClasse.Name = "lblFiltreClasse";
            this.lblFiltreClasse.Size = new System.Drawing.Size(44, 13);
            this.lblFiltreClasse.TabIndex = 12;
            this.lblFiltreClasse.Text = "Classe :";
            // 
            // lsbClasse
            // 
            this.lsbClasse.FormattingEnabled = true;
            this.lsbClasse.Location = new System.Drawing.Point(73, 216);
            this.lsbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.lsbClasse.Name = "lsbClasse";
            this.lsbClasse.Size = new System.Drawing.Size(134, 43);
            this.lsbClasse.TabIndex = 13;
            this.lsbClasse.SelectedIndexChanged += new System.EventHandler(this.lsbClasse_SelectedIndexChanged);
            // 
            // lblFiltrePrelevementAutorise
            // 
            this.lblFiltrePrelevementAutorise.AutoSize = true;
            this.lblFiltrePrelevementAutorise.Location = new System.Drawing.Point(3, 6);
            this.lblFiltrePrelevementAutorise.Name = "lblFiltrePrelevementAutorise";
            this.lblFiltrePrelevementAutorise.Size = new System.Drawing.Size(66, 26);
            this.lblFiltrePrelevementAutorise.TabIndex = 14;
            this.lblFiltrePrelevementAutorise.Text = "Prélèvement\r\nautorisé :";
            // 
            // lblFiltreSweetPris
            // 
            this.lblFiltreSweetPris.AutoSize = true;
            this.lblFiltreSweetPris.Location = new System.Drawing.Point(3, 14);
            this.lblFiltreSweetPris.Name = "lblFiltreSweetPris";
            this.lblFiltreSweetPris.Size = new System.Drawing.Size(62, 13);
            this.lblFiltreSweetPris.TabIndex = 15;
            this.lblFiltreSweetPris.Text = "Sweet pris :";
            // 
            // rdbPrelevementAutoriseOui
            // 
            this.rdbPrelevementAutoriseOui.AutoSize = true;
            this.rdbPrelevementAutoriseOui.Location = new System.Drawing.Point(75, 11);
            this.rdbPrelevementAutoriseOui.Name = "rdbPrelevementAutoriseOui";
            this.rdbPrelevementAutoriseOui.Size = new System.Drawing.Size(41, 17);
            this.rdbPrelevementAutoriseOui.TabIndex = 14;
            this.rdbPrelevementAutoriseOui.TabStop = true;
            this.rdbPrelevementAutoriseOui.Text = "Oui";
            this.rdbPrelevementAutoriseOui.UseVisualStyleBackColor = true;
            // 
            // rdbPrelevementAutoriseNon
            // 
            this.rdbPrelevementAutoriseNon.AutoSize = true;
            this.rdbPrelevementAutoriseNon.Location = new System.Drawing.Point(122, 11);
            this.rdbPrelevementAutoriseNon.Name = "rdbPrelevementAutoriseNon";
            this.rdbPrelevementAutoriseNon.Size = new System.Drawing.Size(45, 17);
            this.rdbPrelevementAutoriseNon.TabIndex = 15;
            this.rdbPrelevementAutoriseNon.TabStop = true;
            this.rdbPrelevementAutoriseNon.Text = "Non";
            this.rdbPrelevementAutoriseNon.UseVisualStyleBackColor = true;
            // 
            // rdbSweetPrisNon
            // 
            this.rdbSweetPrisNon.AutoSize = true;
            this.rdbSweetPrisNon.Location = new System.Drawing.Point(122, 13);
            this.rdbSweetPrisNon.Name = "rdbSweetPrisNon";
            this.rdbSweetPrisNon.Size = new System.Drawing.Size(45, 17);
            this.rdbSweetPrisNon.TabIndex = 17;
            this.rdbSweetPrisNon.TabStop = true;
            this.rdbSweetPrisNon.Text = "Non";
            this.rdbSweetPrisNon.UseVisualStyleBackColor = true;
            // 
            // rdbSweetPrisOui
            // 
            this.rdbSweetPrisOui.AutoSize = true;
            this.rdbSweetPrisOui.Location = new System.Drawing.Point(74, 13);
            this.rdbSweetPrisOui.Name = "rdbSweetPrisOui";
            this.rdbSweetPrisOui.Size = new System.Drawing.Size(41, 17);
            this.rdbSweetPrisOui.TabIndex = 16;
            this.rdbSweetPrisOui.TabStop = true;
            this.rdbSweetPrisOui.Text = "Oui";
            this.rdbSweetPrisOui.UseVisualStyleBackColor = true;
            // 
            // lblInformations
            // 
            this.lblInformations.AutoSize = true;
            this.lblInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformations.Location = new System.Drawing.Point(12, 329);
            this.lblInformations.Name = "lblInformations";
            this.lblInformations.Size = new System.Drawing.Size(155, 25);
            this.lblInformations.TabIndex = 20;
            this.lblInformations.Text = "Informations :";
            // 
            // dtgDebit
            // 
            this.dtgDebit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDebit.Location = new System.Drawing.Point(656, 142);
            this.dtgDebit.Name = "dtgDebit";
            this.dtgDebit.ReadOnly = true;
            this.dtgDebit.Size = new System.Drawing.Size(440, 200);
            this.dtgDebit.TabIndex = 21;
            this.dtgDebit.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDebit_CellEnter);
            // 
            // lblDebit
            // 
            this.lblDebit.AutoSize = true;
            this.lblDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebit.Location = new System.Drawing.Point(651, 109);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(109, 25);
            this.lblDebit.TabIndex = 22;
            this.lblDebit.Text = "Débit(s) :";
            // 
            // dtgCredit
            // 
            this.dtgCredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCredit.Location = new System.Drawing.Point(656, 388);
            this.dtgCredit.Name = "dtgCredit";
            this.dtgCredit.ReadOnly = true;
            this.dtgCredit.Size = new System.Drawing.Size(440, 200);
            this.dtgCredit.TabIndex = 23;
            this.dtgCredit.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCredit_CellEnter);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(651, 357);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(117, 25);
            this.lblCredit.TabIndex = 24;
            this.lblCredit.Text = "Crédit(s) :";
            // 
            // dtgFiltres
            // 
            this.dtgFiltres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFiltres.Location = new System.Drawing.Point(247, 189);
            this.dtgFiltres.Name = "dtgFiltres";
            this.dtgFiltres.Size = new System.Drawing.Size(244, 130);
            this.dtgFiltres.TabIndex = 25;
            this.dtgFiltres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFiltres_CellEnter);
            this.dtgFiltres.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFiltres_CellEnter);
            this.dtgFiltres.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFiltres_CellEnter);
            // 
            // lblResultats
            // 
            this.lblResultats.AutoSize = true;
            this.lblResultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultats.Location = new System.Drawing.Point(242, 151);
            this.lblResultats.Name = "lblResultats";
            this.lblResultats.Size = new System.Drawing.Size(125, 25);
            this.lblResultats.TabIndex = 26;
            this.lblResultats.Text = "Résultats :";
            // 
            // btnFluxAjouter
            // 
            this.btnFluxAjouter.Location = new System.Drawing.Point(540, 142);
            this.btnFluxAjouter.Name = "btnFluxAjouter";
            this.btnFluxAjouter.Size = new System.Drawing.Size(110, 20);
            this.btnFluxAjouter.TabIndex = 9;
            this.btnFluxAjouter.Text = "Ajouter un flux";
            this.btnFluxAjouter.UseVisualStyleBackColor = true;
            this.btnFluxAjouter.Click += new System.EventHandler(this.btnFluxAjouter_Click);
            // 
            // btnFluxModifier
            // 
            this.btnFluxModifier.Enabled = false;
            this.btnFluxModifier.Location = new System.Drawing.Point(540, 168);
            this.btnFluxModifier.Name = "btnFluxModifier";
            this.btnFluxModifier.Size = new System.Drawing.Size(110, 20);
            this.btnFluxModifier.TabIndex = 10;
            this.btnFluxModifier.Text = "Modifier le flux";
            this.btnFluxModifier.UseVisualStyleBackColor = true;
            this.btnFluxModifier.Click += new System.EventHandler(this.btnFluxModifier_Click);
            // 
            // btnFluxSupprimer
            // 
            this.btnFluxSupprimer.Enabled = false;
            this.btnFluxSupprimer.Location = new System.Drawing.Point(540, 194);
            this.btnFluxSupprimer.Name = "btnFluxSupprimer";
            this.btnFluxSupprimer.Size = new System.Drawing.Size(110, 20);
            this.btnFluxSupprimer.TabIndex = 11;
            this.btnFluxSupprimer.Text = "Supprimer le flux";
            this.btnFluxSupprimer.UseVisualStyleBackColor = true;
            this.btnFluxSupprimer.Click += new System.EventHandler(this.btnFluxSupprimer_Click);
            // 
            // dtgFluxAdherant
            // 
            this.dtgFluxAdherant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFluxAdherant.Location = new System.Drawing.Point(247, 365);
            this.dtgFluxAdherant.Name = "dtgFluxAdherant";
            this.dtgFluxAdherant.Size = new System.Drawing.Size(287, 223);
            this.dtgFluxAdherant.TabIndex = 33;
            // 
            // lblFluxAdherant
            // 
            this.lblFluxAdherant.AutoSize = true;
            this.lblFluxAdherant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFluxAdherant.Location = new System.Drawing.Point(242, 329);
            this.lblFluxAdherant.Name = "lblFluxAdherant";
            this.lblFluxAdherant.Size = new System.Drawing.Size(173, 25);
            this.lblFluxAdherant.TabIndex = 34;
            this.lblFluxAdherant.Text = "Flux Adhérant :";
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.Location = new System.Drawing.Point(13, 65);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(93, 25);
            this.lblAnnee.TabIndex = 35;
            this.lblAnnee.Text = "Année :";
            // 
            // gbxInfoAdherant
            // 
            this.gbxInfoAdherant.Controls.Add(this.lblDateNaissance);
            this.gbxInfoAdherant.Controls.Add(this.lblMail);
            this.gbxInfoAdherant.Controls.Add(this.lblTelParent);
            this.gbxInfoAdherant.Controls.Add(this.lblTel);
            this.gbxInfoAdherant.Controls.Add(this.lblClasse);
            this.gbxInfoAdherant.Controls.Add(this.lblPrenom);
            this.gbxInfoAdherant.Controls.Add(this.lblNom);
            this.gbxInfoAdherant.Controls.Add(this.lblMontantPrelevement);
            this.gbxInfoAdherant.Controls.Add(this.lblPrelevementAutorise);
            this.gbxInfoAdherant.Controls.Add(this.lblSweet);
            this.gbxInfoAdherant.Controls.Add(this.lblClasseAdherant);
            this.gbxInfoAdherant.Controls.Add(this.lblPrenomAdherant);
            this.gbxInfoAdherant.Controls.Add(this.lblNomAdherant);
            this.gbxInfoAdherant.Location = new System.Drawing.Point(17, 365);
            this.gbxInfoAdherant.Name = "gbxInfoAdherant";
            this.gbxInfoAdherant.Size = new System.Drawing.Size(208, 223);
            this.gbxInfoAdherant.TabIndex = 36;
            this.gbxInfoAdherant.TabStop = false;
            this.gbxInfoAdherant.Text = "Info Adherant";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(112, 215);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(0, 13);
            this.lblDateNaissance.TabIndex = 13;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(84, 183);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(0, 13);
            this.lblMail.TabIndex = 12;
            // 
            // lblTelParent
            // 
            this.lblTelParent.AutoSize = true;
            this.lblTelParent.Location = new System.Drawing.Point(150, 151);
            this.lblTelParent.Name = "lblTelParent";
            this.lblTelParent.Size = new System.Drawing.Size(0, 13);
            this.lblTelParent.TabIndex = 11;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(112, 117);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(0, 13);
            this.lblTel.TabIndex = 10;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(56, 87);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(0, 13);
            this.lblClasse.TabIndex = 9;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(61, 55);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(0, 13);
            this.lblPrenom.TabIndex = 8;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(48, 24);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(0, 13);
            this.lblNom.TabIndex = 7;
            // 
            // lblMontantPrelevement
            // 
            this.lblMontantPrelevement.AutoSize = true;
            this.lblMontantPrelevement.Location = new System.Drawing.Point(6, 183);
            this.lblMontantPrelevement.Name = "lblMontantPrelevement";
            this.lblMontantPrelevement.Size = new System.Drawing.Size(113, 13);
            this.lblMontantPrelevement.TabIndex = 5;
            this.lblMontantPrelevement.Text = "Montant prélèvement :";
            // 
            // lblPrelevementAutorise
            // 
            this.lblPrelevementAutorise.AutoSize = true;
            this.lblPrelevementAutorise.Location = new System.Drawing.Point(6, 117);
            this.lblPrelevementAutorise.Name = "lblPrelevementAutorise";
            this.lblPrelevementAutorise.Size = new System.Drawing.Size(112, 13);
            this.lblPrelevementAutorise.TabIndex = 4;
            this.lblPrelevementAutorise.Text = "Prélèvement autorisé :";
            // 
            // lblSweet
            // 
            this.lblSweet.AutoSize = true;
            this.lblSweet.Location = new System.Drawing.Point(6, 151);
            this.lblSweet.Name = "lblSweet";
            this.lblSweet.Size = new System.Drawing.Size(43, 13);
            this.lblSweet.TabIndex = 3;
            this.lblSweet.Text = "Sweet :";
            // 
            // lblClasseAdherant
            // 
            this.lblClasseAdherant.AutoSize = true;
            this.lblClasseAdherant.Location = new System.Drawing.Point(6, 87);
            this.lblClasseAdherant.Name = "lblClasseAdherant";
            this.lblClasseAdherant.Size = new System.Drawing.Size(44, 13);
            this.lblClasseAdherant.TabIndex = 2;
            this.lblClasseAdherant.Text = "Classe :";
            // 
            // lblPrenomAdherant
            // 
            this.lblPrenomAdherant.AutoSize = true;
            this.lblPrenomAdherant.Location = new System.Drawing.Point(6, 55);
            this.lblPrenomAdherant.Name = "lblPrenomAdherant";
            this.lblPrenomAdherant.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomAdherant.TabIndex = 1;
            this.lblPrenomAdherant.Text = "Prénom :";
            // 
            // lblNomAdherant
            // 
            this.lblNomAdherant.AutoSize = true;
            this.lblNomAdherant.Location = new System.Drawing.Point(6, 24);
            this.lblNomAdherant.Name = "lblNomAdherant";
            this.lblNomAdherant.Size = new System.Drawing.Size(35, 13);
            this.lblNomAdherant.TabIndex = 0;
            this.lblNomAdherant.Text = "Nom :";
            // 
            // btnModifierBudgetEPS
            // 
            this.btnModifierBudgetEPS.Location = new System.Drawing.Point(325, 93);
            this.btnModifierBudgetEPS.Name = "btnModifierBudgetEPS";
            this.btnModifierBudgetEPS.Size = new System.Drawing.Size(75, 20);
            this.btnModifierBudgetEPS.TabIndex = 7;
            this.btnModifierBudgetEPS.Text = "Modifier";
            this.btnModifierBudgetEPS.UseVisualStyleBackColor = true;
            this.btnModifierBudgetEPS.Visible = false;
            this.btnModifierBudgetEPS.Click += new System.EventHandler(this.btnModifierBudgetEPS_Click);
            // 
            // btnModifierBudgetAS
            // 
            this.btnModifierBudgetAS.Location = new System.Drawing.Point(325, 118);
            this.btnModifierBudgetAS.Name = "btnModifierBudgetAS";
            this.btnModifierBudgetAS.Size = new System.Drawing.Size(75, 20);
            this.btnModifierBudgetAS.TabIndex = 8;
            this.btnModifierBudgetAS.Text = "Modifier";
            this.btnModifierBudgetAS.UseVisualStyleBackColor = true;
            this.btnModifierBudgetAS.Visible = false;
            this.btnModifierBudgetAS.Click += new System.EventHandler(this.btnModifierBudgetAS_Click);
            // 
            // btnEnvoyerModifEPS
            // 
            this.btnEnvoyerModifEPS.Location = new System.Drawing.Point(325, 93);
            this.btnEnvoyerModifEPS.Name = "btnEnvoyerModifEPS";
            this.btnEnvoyerModifEPS.Size = new System.Drawing.Size(75, 20);
            this.btnEnvoyerModifEPS.TabIndex = 3;
            this.btnEnvoyerModifEPS.Text = "Envoyer";
            this.btnEnvoyerModifEPS.UseVisualStyleBackColor = true;
            this.btnEnvoyerModifEPS.Visible = false;
            this.btnEnvoyerModifEPS.Click += new System.EventHandler(this.btnEnvoyerModifEPS_Click);
            // 
            // btnAnnulerModifEPS
            // 
            this.btnAnnulerModifEPS.Location = new System.Drawing.Point(405, 93);
            this.btnAnnulerModifEPS.Name = "btnAnnulerModifEPS";
            this.btnAnnulerModifEPS.Size = new System.Drawing.Size(75, 20);
            this.btnAnnulerModifEPS.TabIndex = 4;
            this.btnAnnulerModifEPS.Text = "Annuler";
            this.btnAnnulerModifEPS.UseVisualStyleBackColor = true;
            this.btnAnnulerModifEPS.Visible = false;
            this.btnAnnulerModifEPS.Click += new System.EventHandler(this.btnAnnulerModifEPS_Click);
            // 
            // btnEnvoyerModifAS
            // 
            this.btnEnvoyerModifAS.Location = new System.Drawing.Point(325, 118);
            this.btnEnvoyerModifAS.Name = "btnEnvoyerModifAS";
            this.btnEnvoyerModifAS.Size = new System.Drawing.Size(75, 20);
            this.btnEnvoyerModifAS.TabIndex = 5;
            this.btnEnvoyerModifAS.Text = "Envoyer";
            this.btnEnvoyerModifAS.UseVisualStyleBackColor = true;
            this.btnEnvoyerModifAS.Visible = false;
            this.btnEnvoyerModifAS.Click += new System.EventHandler(this.btnEnvoyerModifAS_Click);
            // 
            // btnAnnulerModifAS
            // 
            this.btnAnnulerModifAS.Location = new System.Drawing.Point(405, 118);
            this.btnAnnulerModifAS.Name = "btnAnnulerModifAS";
            this.btnAnnulerModifAS.Size = new System.Drawing.Size(75, 20);
            this.btnAnnulerModifAS.TabIndex = 6;
            this.btnAnnulerModifAS.Text = "Annuler";
            this.btnAnnulerModifAS.UseVisualStyleBackColor = true;
            this.btnAnnulerModifAS.Visible = false;
            this.btnAnnulerModifAS.Click += new System.EventHandler(this.btnAnnulerModifAS_Click);
            // 
            // lblSetBudgetEPSInitial
            // 
            this.lblSetBudgetEPSInitial.AutoSize = true;
            this.lblSetBudgetEPSInitial.Location = new System.Drawing.Point(147, 98);
            this.lblSetBudgetEPSInitial.Name = "lblSetBudgetEPSInitial";
            this.lblSetBudgetEPSInitial.Size = new System.Drawing.Size(97, 13);
            this.lblSetBudgetEPSInitial.TabIndex = 44;
            this.lblSetBudgetEPSInitial.Text = "Budget EPS initial :";
            // 
            // lblSetBudgetASInitial
            // 
            this.lblSetBudgetASInitial.AutoSize = true;
            this.lblSetBudgetASInitial.Location = new System.Drawing.Point(147, 123);
            this.lblSetBudgetASInitial.Name = "lblSetBudgetASInitial";
            this.lblSetBudgetASInitial.Size = new System.Drawing.Size(90, 13);
            this.lblSetBudgetASInitial.TabIndex = 43;
            this.lblSetBudgetASInitial.Text = "Budget AS initial :";
            // 
            // lblBudgetAS
            // 
            this.lblBudgetAS.AutoSize = true;
            this.lblBudgetAS.Location = new System.Drawing.Point(88, 123);
            this.lblBudgetAS.Name = "lblBudgetAS";
            this.lblBudgetAS.Size = new System.Drawing.Size(13, 13);
            this.lblBudgetAS.TabIndex = 46;
            this.lblBudgetAS.Text = "0";
            this.lblBudgetAS.TextChanged += new System.EventHandler(this.lblBudgetAS_TextChanged);
            // 
            // lblBudgetEPS
            // 
            this.lblBudgetEPS.AutoSize = true;
            this.lblBudgetEPS.Location = new System.Drawing.Point(88, 99);
            this.lblBudgetEPS.Name = "lblBudgetEPS";
            this.lblBudgetEPS.Size = new System.Drawing.Size(13, 13);
            this.lblBudgetEPS.TabIndex = 45;
            this.lblBudgetEPS.Text = "0";
            this.lblBudgetEPS.TextChanged += new System.EventHandler(this.lblBudgetEPS_TextChanged);
            // 
            // pnlPrelevementAutorise
            // 
            this.pnlPrelevementAutorise.Controls.Add(this.lblFiltrePrelevementAutorise);
            this.pnlPrelevementAutorise.Controls.Add(this.rdbPrelevementAutoriseOui);
            this.pnlPrelevementAutorise.Controls.Add(this.rdbPrelevementAutoriseNon);
            this.pnlPrelevementAutorise.Location = new System.Drawing.Point(16, 264);
            this.pnlPrelevementAutorise.Name = "pnlPrelevementAutorise";
            this.pnlPrelevementAutorise.Size = new System.Drawing.Size(191, 37);
            this.pnlPrelevementAutorise.TabIndex = 47;
            // 
            // pnlSweetPris
            // 
            this.pnlSweetPris.Controls.Add(this.lblFiltreSweetPris);
            this.pnlSweetPris.Controls.Add(this.rdbSweetPrisOui);
            this.pnlSweetPris.Controls.Add(this.rdbSweetPrisNon);
            this.pnlSweetPris.Location = new System.Drawing.Point(16, 295);
            this.pnlSweetPris.Name = "pnlSweetPris";
            this.pnlSweetPris.Size = new System.Drawing.Size(191, 36);
            this.pnlSweetPris.TabIndex = 48;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(19, 184);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(49, 26);
            this.lblNomPrenom.TabIndex = 49;
            this.lblNomPrenom.Text = "Nom et\r\nPrénom :";
            // 
            // FormComptabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 600);
            this.Controls.Add(this.lblNomPrenom);
            this.Controls.Add(this.pnlSweetPris);
            this.Controls.Add(this.pnlPrelevementAutorise);
            this.Controls.Add(this.lblBudgetAS);
            this.Controls.Add(this.lblBudgetEPS);
            this.Controls.Add(this.lblSetBudgetEPSInitial);
            this.Controls.Add(this.lblSetBudgetASInitial);
            this.Controls.Add(this.btnAnnulerModifAS);
            this.Controls.Add(this.btnEnvoyerModifAS);
            this.Controls.Add(this.btnAnnulerModifEPS);
            this.Controls.Add(this.btnEnvoyerModifEPS);
            this.Controls.Add(this.btnModifierBudgetAS);
            this.Controls.Add(this.btnModifierBudgetEPS);
            this.Controls.Add(this.gbxInfoAdherant);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblFluxAdherant);
            this.Controls.Add(this.dtgFluxAdherant);
            this.Controls.Add(this.btnFluxSupprimer);
            this.Controls.Add(this.btnFluxModifier);
            this.Controls.Add(this.btnFluxAjouter);
            this.Controls.Add(this.lblResultats);
            this.Controls.Add(this.dtgFiltres);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.dtgCredit);
            this.Controls.Add(this.lblDebit);
            this.Controls.Add(this.dtgDebit);
            this.Controls.Add(this.lblInformations);
            this.Controls.Add(this.lsbClasse);
            this.Controls.Add(this.lblFiltreClasse);
            this.Controls.Add(this.tbxRechercheNomPrenom);
            this.Controls.Add(this.lblFiltreAdherant);
            this.Controls.Add(this.lblBudgetASInitial);
            this.Controls.Add(this.lblBudgetEPSInitial);
            this.Controls.Add(this.btnSetBudgetAS);
            this.Controls.Add(this.btnSetBudgetEPS);
            this.Controls.Add(this.lblTitreCompta);
            this.Controls.Add(this.txbBudgetAS);
            this.Controls.Add(this.txbBudgetEPS);
            this.Controls.Add(this.lblSetBudgetEPS);
            this.Controls.Add(this.lblSetBudgetAS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormComptabilite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comptabilité";
            this.Load += new System.EventHandler(this.FormComptabilite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDebit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiltres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFluxAdherant)).EndInit();
            this.gbxInfoAdherant.ResumeLayout(false);
            this.gbxInfoAdherant.PerformLayout();
            this.pnlPrelevementAutorise.ResumeLayout(false);
            this.pnlPrelevementAutorise.PerformLayout();
            this.pnlSweetPris.ResumeLayout(false);
            this.pnlSweetPris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetBudgetAS;
        private System.Windows.Forms.Label lblSetBudgetEPS;
        private System.Windows.Forms.TextBox txbBudgetEPS;
        private System.Windows.Forms.TextBox txbBudgetAS;
        private System.Windows.Forms.Label lblTitreCompta;
        private System.Windows.Forms.Button btnSetBudgetEPS;
        private System.Windows.Forms.Button btnSetBudgetAS;
        private System.Windows.Forms.Label lblBudgetEPSInitial;
        private System.Windows.Forms.Label lblBudgetASInitial;
        private System.Windows.Forms.Label lblFiltreAdherant;
        private System.Windows.Forms.TextBox tbxRechercheNomPrenom;
        private System.Windows.Forms.Label lblFiltreClasse;
        protected System.Windows.Forms.ListBox lsbClasse;
        private System.Windows.Forms.Label lblFiltrePrelevementAutorise;
        private System.Windows.Forms.Label lblFiltreSweetPris;
        private System.Windows.Forms.RadioButton rdbPrelevementAutoriseOui;
        private System.Windows.Forms.RadioButton rdbPrelevementAutoriseNon;
        private System.Windows.Forms.RadioButton rdbSweetPrisNon;
        private System.Windows.Forms.RadioButton rdbSweetPrisOui;
        private System.Windows.Forms.Label lblInformations;
        private System.Windows.Forms.DataGridView dtgDebit;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.DataGridView dtgCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.DataGridView dtgFiltres;
        private System.Windows.Forms.Label lblResultats;
        private System.Windows.Forms.Button btnFluxAjouter;
        private System.Windows.Forms.Button btnFluxModifier;
        private System.Windows.Forms.Button btnFluxSupprimer;
        private System.Windows.Forms.DataGridView dtgFluxAdherant;
        private System.Windows.Forms.Label lblFluxAdherant;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.GroupBox gbxInfoAdherant;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelParent;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMontantPrelevement;
        private System.Windows.Forms.Label lblPrelevementAutorise;
        private System.Windows.Forms.Label lblSweet;
        private System.Windows.Forms.Label lblClasseAdherant;
        private System.Windows.Forms.Label lblPrenomAdherant;
        private System.Windows.Forms.Label lblNomAdherant;
        private System.Windows.Forms.Button btnModifierBudgetEPS;
        private System.Windows.Forms.Button btnModifierBudgetAS;
        private System.Windows.Forms.Button btnEnvoyerModifEPS;
        private System.Windows.Forms.Button btnAnnulerModifEPS;
        private System.Windows.Forms.Button btnEnvoyerModifAS;
        private System.Windows.Forms.Button btnAnnulerModifAS;
        private System.Windows.Forms.Label lblSetBudgetEPSInitial;
        private System.Windows.Forms.Label lblSetBudgetASInitial;
        private System.Windows.Forms.Label lblBudgetAS;
        private System.Windows.Forms.Label lblBudgetEPS;
        private System.Windows.Forms.Panel pnlPrelevementAutorise;
        private System.Windows.Forms.Panel pnlSweetPris;
        private System.Windows.Forms.Label lblNomPrenom;
    }
}