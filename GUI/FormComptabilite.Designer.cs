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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTitreCompta = new System.Windows.Forms.Label();
            this.btnSetBudgetEPS = new System.Windows.Forms.Button();
            this.btnSetBudgetAS = new System.Windows.Forms.Button();
            this.lblBudgetEPS = new System.Windows.Forms.Label();
            this.lblBudgetAS = new System.Windows.Forms.Label();
            this.lblFiltreAdherant = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblFiltreClasse = new System.Windows.Forms.Label();
            this.lsbClasse = new System.Windows.Forms.ListBox();
            this.lblFiltrePrelevementAutorise = new System.Windows.Forms.Label();
            this.lblFiltreSweetPris = new System.Windows.Forms.Label();
            this.rdbPrelevementAutoriseOui = new System.Windows.Forms.RadioButton();
            this.rdbPrelevementAutoriseNon = new System.Windows.Forms.RadioButton();
            this.rdbSweetPrisNon = new System.Windows.Forms.RadioButton();
            this.rdbSweetPrisOui = new System.Windows.Forms.RadioButton();
            this.lblInformations = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDebit = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblCredit = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblResultats = new System.Windows.Forms.Label();
            this.btnDebitAjouter = new System.Windows.Forms.Button();
            this.btnDebitModifier = new System.Windows.Forms.Button();
            this.btnDebitSupprimer = new System.Windows.Forms.Button();
            this.btnCreditSupprimer = new System.Windows.Forms.Button();
            this.btnCreditModifier = new System.Windows.Forms.Button();
            this.btnCreditAjouter = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.gbxInfoAdherant.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblTitreCompta
            // 
            this.lblTitreCompta.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCompta.Location = new System.Drawing.Point(12, 9);
            this.lblTitreCompta.Name = "lblTitreCompta";
            this.lblTitreCompta.Size = new System.Drawing.Size(1043, 64);
            this.lblTitreCompta.TabIndex = 4;
            this.lblTitreCompta.Text = "Comptabilité";
            this.lblTitreCompta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetBudgetEPS
            // 
            this.btnSetBudgetEPS.Location = new System.Drawing.Point(197, 93);
            this.btnSetBudgetEPS.Name = "btnSetBudgetEPS";
            this.btnSetBudgetEPS.Size = new System.Drawing.Size(75, 20);
            this.btnSetBudgetEPS.TabIndex = 6;
            this.btnSetBudgetEPS.Text = "Envoyer";
            this.btnSetBudgetEPS.UseVisualStyleBackColor = true;
            // 
            // btnSetBudgetAS
            // 
            this.btnSetBudgetAS.Location = new System.Drawing.Point(197, 119);
            this.btnSetBudgetAS.Name = "btnSetBudgetAS";
            this.btnSetBudgetAS.Size = new System.Drawing.Size(75, 20);
            this.btnSetBudgetAS.TabIndex = 7;
            this.btnSetBudgetAS.Text = "Envoyer";
            this.btnSetBudgetAS.UseVisualStyleBackColor = true;
            // 
            // lblBudgetEPS
            // 
            this.lblBudgetEPS.AutoSize = true;
            this.lblBudgetEPS.Location = new System.Drawing.Point(91, 100);
            this.lblBudgetEPS.Name = "lblBudgetEPS";
            this.lblBudgetEPS.Size = new System.Drawing.Size(13, 13);
            this.lblBudgetEPS.TabIndex = 8;
            this.lblBudgetEPS.Text = "0";
            // 
            // lblBudgetAS
            // 
            this.lblBudgetAS.AutoSize = true;
            this.lblBudgetAS.Location = new System.Drawing.Point(91, 123);
            this.lblBudgetAS.Name = "lblBudgetAS";
            this.lblBudgetAS.Size = new System.Drawing.Size(13, 13);
            this.lblBudgetAS.TabIndex = 9;
            this.lblBudgetAS.Text = "0";
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 11;
            // 
            // lblFiltreClasse
            // 
            this.lblFiltreClasse.AutoSize = true;
            this.lblFiltreClasse.Location = new System.Drawing.Point(20, 224);
            this.lblFiltreClasse.Name = "lblFiltreClasse";
            this.lblFiltreClasse.Size = new System.Drawing.Size(44, 13);
            this.lblFiltreClasse.TabIndex = 12;
            this.lblFiltreClasse.Text = "Classe :";
            // 
            // lsbClasse
            // 
            this.lsbClasse.FormattingEnabled = true;
            this.lsbClasse.Location = new System.Drawing.Point(69, 216);
            this.lsbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.lsbClasse.Name = "lsbClasse";
            this.lsbClasse.Size = new System.Drawing.Size(114, 30);
            this.lsbClasse.TabIndex = 13;
            // 
            // lblFiltrePrelevementAutorise
            // 
            this.lblFiltrePrelevementAutorise.AutoSize = true;
            this.lblFiltrePrelevementAutorise.Location = new System.Drawing.Point(20, 254);
            this.lblFiltrePrelevementAutorise.Name = "lblFiltrePrelevementAutorise";
            this.lblFiltrePrelevementAutorise.Size = new System.Drawing.Size(66, 26);
            this.lblFiltrePrelevementAutorise.TabIndex = 14;
            this.lblFiltrePrelevementAutorise.Text = "Prélèvement\r\nautorisé :";
            // 
            // lblFiltreSweetPris
            // 
            this.lblFiltreSweetPris.AutoSize = true;
            this.lblFiltreSweetPris.Location = new System.Drawing.Point(20, 294);
            this.lblFiltreSweetPris.Name = "lblFiltreSweetPris";
            this.lblFiltreSweetPris.Size = new System.Drawing.Size(62, 13);
            this.lblFiltreSweetPris.TabIndex = 15;
            this.lblFiltreSweetPris.Text = "Sweet pris :";
            // 
            // rdbPrelevementAutoriseOui
            // 
            this.rdbPrelevementAutoriseOui.AutoSize = true;
            this.rdbPrelevementAutoriseOui.Location = new System.Drawing.Point(92, 263);
            this.rdbPrelevementAutoriseOui.Name = "rdbPrelevementAutoriseOui";
            this.rdbPrelevementAutoriseOui.Size = new System.Drawing.Size(41, 17);
            this.rdbPrelevementAutoriseOui.TabIndex = 16;
            this.rdbPrelevementAutoriseOui.TabStop = true;
            this.rdbPrelevementAutoriseOui.Text = "Oui";
            this.rdbPrelevementAutoriseOui.UseVisualStyleBackColor = true;
            // 
            // rdbPrelevementAutoriseNon
            // 
            this.rdbPrelevementAutoriseNon.AutoSize = true;
            this.rdbPrelevementAutoriseNon.Location = new System.Drawing.Point(139, 263);
            this.rdbPrelevementAutoriseNon.Name = "rdbPrelevementAutoriseNon";
            this.rdbPrelevementAutoriseNon.Size = new System.Drawing.Size(45, 17);
            this.rdbPrelevementAutoriseNon.TabIndex = 17;
            this.rdbPrelevementAutoriseNon.TabStop = true;
            this.rdbPrelevementAutoriseNon.Text = "Non";
            this.rdbPrelevementAutoriseNon.UseVisualStyleBackColor = true;
            // 
            // rdbSweetPrisNon
            // 
            this.rdbSweetPrisNon.AutoSize = true;
            this.rdbSweetPrisNon.Location = new System.Drawing.Point(138, 294);
            this.rdbSweetPrisNon.Name = "rdbSweetPrisNon";
            this.rdbSweetPrisNon.Size = new System.Drawing.Size(45, 17);
            this.rdbSweetPrisNon.TabIndex = 19;
            this.rdbSweetPrisNon.TabStop = true;
            this.rdbSweetPrisNon.Text = "Non";
            this.rdbSweetPrisNon.UseVisualStyleBackColor = true;
            // 
            // rdbSweetPrisOui
            // 
            this.rdbSweetPrisOui.AutoSize = true;
            this.rdbSweetPrisOui.Location = new System.Drawing.Point(91, 294);
            this.rdbSweetPrisOui.Name = "rdbSweetPrisOui";
            this.rdbSweetPrisOui.Size = new System.Drawing.Size(41, 17);
            this.rdbSweetPrisOui.TabIndex = 18;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(656, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 200);
            this.dataGridView1.TabIndex = 21;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(656, 388);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(399, 200);
            this.dataGridView2.TabIndex = 23;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(651, 360);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(117, 25);
            this.lblCredit.TabIndex = 24;
            this.lblCredit.Text = "Crédit(s) :";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(247, 189);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(322, 130);
            this.dataGridView3.TabIndex = 25;
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
            // btnDebitAjouter
            // 
            this.btnDebitAjouter.Location = new System.Drawing.Point(575, 142);
            this.btnDebitAjouter.Name = "btnDebitAjouter";
            this.btnDebitAjouter.Size = new System.Drawing.Size(75, 20);
            this.btnDebitAjouter.TabIndex = 27;
            this.btnDebitAjouter.Text = "Ajouter";
            this.btnDebitAjouter.UseVisualStyleBackColor = true;
            // 
            // btnDebitModifier
            // 
            this.btnDebitModifier.Location = new System.Drawing.Point(575, 168);
            this.btnDebitModifier.Name = "btnDebitModifier";
            this.btnDebitModifier.Size = new System.Drawing.Size(75, 20);
            this.btnDebitModifier.TabIndex = 28;
            this.btnDebitModifier.Text = "Modifier";
            this.btnDebitModifier.UseVisualStyleBackColor = true;
            // 
            // btnDebitSupprimer
            // 
            this.btnDebitSupprimer.Location = new System.Drawing.Point(575, 194);
            this.btnDebitSupprimer.Name = "btnDebitSupprimer";
            this.btnDebitSupprimer.Size = new System.Drawing.Size(75, 20);
            this.btnDebitSupprimer.TabIndex = 29;
            this.btnDebitSupprimer.Text = "Supprimer";
            this.btnDebitSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnCreditSupprimer
            // 
            this.btnCreditSupprimer.Location = new System.Drawing.Point(575, 440);
            this.btnCreditSupprimer.Name = "btnCreditSupprimer";
            this.btnCreditSupprimer.Size = new System.Drawing.Size(75, 20);
            this.btnCreditSupprimer.TabIndex = 32;
            this.btnCreditSupprimer.Text = "Supprimer";
            this.btnCreditSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnCreditModifier
            // 
            this.btnCreditModifier.Location = new System.Drawing.Point(575, 414);
            this.btnCreditModifier.Name = "btnCreditModifier";
            this.btnCreditModifier.Size = new System.Drawing.Size(75, 20);
            this.btnCreditModifier.TabIndex = 31;
            this.btnCreditModifier.Text = "Modifier";
            this.btnCreditModifier.UseVisualStyleBackColor = true;
            // 
            // btnCreditAjouter
            // 
            this.btnCreditAjouter.Location = new System.Drawing.Point(575, 388);
            this.btnCreditAjouter.Name = "btnCreditAjouter";
            this.btnCreditAjouter.Size = new System.Drawing.Size(75, 20);
            this.btnCreditAjouter.TabIndex = 30;
            this.btnCreditAjouter.Text = "Ajouter";
            this.btnCreditAjouter.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(247, 365);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(322, 223);
            this.dataGridView4.TabIndex = 33;
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
            this.btnModifierBudgetEPS.Location = new System.Drawing.Point(198, 93);
            this.btnModifierBudgetEPS.Name = "btnModifierBudgetEPS";
            this.btnModifierBudgetEPS.Size = new System.Drawing.Size(75, 20);
            this.btnModifierBudgetEPS.TabIndex = 37;
            this.btnModifierBudgetEPS.Text = "Modifier";
            this.btnModifierBudgetEPS.UseVisualStyleBackColor = true;
            this.btnModifierBudgetEPS.Visible = false;
            // 
            // btnModifierBudgetAS
            // 
            this.btnModifierBudgetAS.Location = new System.Drawing.Point(198, 118);
            this.btnModifierBudgetAS.Name = "btnModifierBudgetAS";
            this.btnModifierBudgetAS.Size = new System.Drawing.Size(75, 20);
            this.btnModifierBudgetAS.TabIndex = 38;
            this.btnModifierBudgetAS.Text = "Modifier";
            this.btnModifierBudgetAS.UseVisualStyleBackColor = true;
            this.btnModifierBudgetAS.Visible = false;
            // 
            // FormComptabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 600);
            this.Controls.Add(this.btnModifierBudgetAS);
            this.Controls.Add(this.btnModifierBudgetEPS);
            this.Controls.Add(this.gbxInfoAdherant);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblFluxAdherant);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.btnCreditSupprimer);
            this.Controls.Add(this.btnCreditModifier);
            this.Controls.Add(this.btnCreditAjouter);
            this.Controls.Add(this.btnDebitSupprimer);
            this.Controls.Add(this.btnDebitModifier);
            this.Controls.Add(this.btnDebitAjouter);
            this.Controls.Add(this.lblResultats);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblDebit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblInformations);
            this.Controls.Add(this.rdbSweetPrisNon);
            this.Controls.Add(this.rdbSweetPrisOui);
            this.Controls.Add(this.rdbPrelevementAutoriseNon);
            this.Controls.Add(this.rdbPrelevementAutoriseOui);
            this.Controls.Add(this.lblFiltreSweetPris);
            this.Controls.Add(this.lblFiltrePrelevementAutorise);
            this.Controls.Add(this.lsbClasse);
            this.Controls.Add(this.lblFiltreClasse);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblFiltreAdherant);
            this.Controls.Add(this.lblBudgetAS);
            this.Controls.Add(this.lblBudgetEPS);
            this.Controls.Add(this.btnSetBudgetAS);
            this.Controls.Add(this.btnSetBudgetEPS);
            this.Controls.Add(this.lblTitreCompta);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSetBudgetEPS);
            this.Controls.Add(this.lblSetBudgetAS);
            this.Name = "FormComptabilite";
            this.Text = "FormComptabilite";
            this.Load += new System.EventHandler(this.FormComptabilite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.gbxInfoAdherant.ResumeLayout(false);
            this.gbxInfoAdherant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetBudgetAS;
        private System.Windows.Forms.Label lblSetBudgetEPS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTitreCompta;
        private System.Windows.Forms.Button btnSetBudgetEPS;
        private System.Windows.Forms.Button btnSetBudgetAS;
        private System.Windows.Forms.Label lblBudgetEPS;
        private System.Windows.Forms.Label lblBudgetAS;
        private System.Windows.Forms.Label lblFiltreAdherant;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblFiltreClasse;
        protected System.Windows.Forms.ListBox lsbClasse;
        private System.Windows.Forms.Label lblFiltrePrelevementAutorise;
        private System.Windows.Forms.Label lblFiltreSweetPris;
        private System.Windows.Forms.RadioButton rdbPrelevementAutoriseOui;
        private System.Windows.Forms.RadioButton rdbPrelevementAutoriseNon;
        private System.Windows.Forms.RadioButton rdbSweetPrisNon;
        private System.Windows.Forms.RadioButton rdbSweetPrisOui;
        private System.Windows.Forms.Label lblInformations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lblResultats;
        private System.Windows.Forms.Button btnDebitAjouter;
        private System.Windows.Forms.Button btnDebitModifier;
        private System.Windows.Forms.Button btnDebitSupprimer;
        private System.Windows.Forms.Button btnCreditSupprimer;
        private System.Windows.Forms.Button btnCreditModifier;
        private System.Windows.Forms.Button btnCreditAjouter;
        private System.Windows.Forms.DataGridView dataGridView4;
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
    }
}