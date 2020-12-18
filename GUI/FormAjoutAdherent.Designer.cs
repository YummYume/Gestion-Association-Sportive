
namespace GUI
{
    partial class FormAjoutAdherent
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
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.lblDnd = new System.Windows.Forms.Label();
            this.dtpDn = new System.Windows.Forms.DateTimePicker();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lsbSexe = new System.Windows.Forms.ListBox();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.tbxNumTel = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblNumTelParent = new System.Windows.Forms.Label();
            this.tbxNumTelParent = new System.Windows.Forms.TextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lsbClasse = new System.Windows.Forms.ListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(182, 22);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 28;
            this.lblNom.Text = "Nom";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(217, 19);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(76, 20);
            this.tbxNom.TabIndex = 29;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(182, 58);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 30;
            this.lblPrenom.Text = "Prenom";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(232, 58);
            this.tbxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(76, 20);
            this.tbxPrenom.TabIndex = 31;
            // 
            // lblDnd
            // 
            this.lblDnd.AutoSize = true;
            this.lblDnd.Location = new System.Drawing.Point(182, 94);
            this.lblDnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDnd.Name = "lblDnd";
            this.lblDnd.Size = new System.Drawing.Size(96, 13);
            this.lblDnd.TabIndex = 32;
            this.lblDnd.Text = "Date de naissance";
            // 
            // dtpDn
            // 
            this.dtpDn.CustomFormat = "dd/MM/yyyy";
            this.dtpDn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDn.Location = new System.Drawing.Point(283, 91);
            this.dtpDn.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDn.Name = "dtpDn";
            this.dtpDn.Size = new System.Drawing.Size(83, 20);
            this.dtpDn.TabIndex = 41;
            this.dtpDn.Value = new System.DateTime(2020, 12, 14, 0, 0, 0, 0);
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(182, 127);
            this.lblSexe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(31, 13);
            this.lblSexe.TabIndex = 33;
            this.lblSexe.Text = "Sexe";
            // 
            // lsbSexe
            // 
            this.lsbSexe.FormattingEnabled = true;
            this.lsbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Autre"});
            this.lsbSexe.Location = new System.Drawing.Point(219, 127);
            this.lsbSexe.Margin = new System.Windows.Forms.Padding(2);
            this.lsbSexe.Name = "lsbSexe";
            this.lsbSexe.Size = new System.Drawing.Size(62, 17);
            this.lsbSexe.TabIndex = 42;
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(182, 159);
            this.lblNumTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(155, 13);
            this.lblNumTel.TabIndex = 34;
            this.lblNumTel.Text = "Numéro de téléphone Adherent";
            // 
            // tbxNumTel
            // 
            this.tbxNumTel.Location = new System.Drawing.Point(341, 156);
            this.tbxNumTel.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNumTel.Name = "tbxNumTel";
            this.tbxNumTel.Size = new System.Drawing.Size(106, 20);
            this.tbxNumTel.TabIndex = 35;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(182, 187);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(218, 184);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(76, 20);
            this.tbxEmail.TabIndex = 37;
            // 
            // lblNumTelParent
            // 
            this.lblNumTelParent.AutoSize = true;
            this.lblNumTelParent.Location = new System.Drawing.Point(182, 278);
            this.lblNumTelParent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTelParent.Name = "lblNumTelParent";
            this.lblNumTelParent.Size = new System.Drawing.Size(143, 13);
            this.lblNumTelParent.TabIndex = 38;
            this.lblNumTelParent.Text = "Numéro de téléphone Parent";
            // 
            // tbxNumTelParent
            // 
            this.tbxNumTelParent.Location = new System.Drawing.Point(329, 275);
            this.tbxNumTelParent.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNumTelParent.Name = "tbxNumTelParent";
            this.tbxNumTelParent.Size = new System.Drawing.Size(106, 20);
            this.tbxNumTelParent.TabIndex = 39;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(182, 312);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(38, 13);
            this.lblClasse.TabIndex = 40;
            this.lblClasse.Text = "Classe";
            // 
            // lsbClasse
            // 
            this.lsbClasse.FormattingEnabled = true;
            this.lsbClasse.Location = new System.Drawing.Point(224, 311);
            this.lsbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.lsbClasse.Name = "lsbClasse";
            this.lsbClasse.Size = new System.Drawing.Size(62, 17);
            this.lsbClasse.TabIndex = 43;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(182, 360);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(237, 56);
            this.btnValider.TabIndex = 44;
            this.btnValider.Text = "Ajouter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click_1);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(182, 216);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 45;
            this.lblLogin.Text = "Login";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(219, 216);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(76, 20);
            this.tbxLogin.TabIndex = 46;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(182, 248);
            this.lblMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(71, 13);
            this.lblMdp.TabIndex = 47;
            this.lblMdp.Text = "Mot de passe";
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(257, 245);
            this.tbxMdp.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(76, 20);
            this.tbxMdp.TabIndex = 48;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Location = new System.Drawing.Point(280, 345);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(0, 13);
            this.lblErreur.TabIndex = 49;
            // 
            // FormAjoutAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 423);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.lblDnd);
            this.Controls.Add(this.dtpDn);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.lsbSexe);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.tbxNumTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblNumTelParent);
            this.Controls.Add(this.tbxNumTelParent);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lsbClasse);
            this.Controls.Add(this.btnValider);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAjoutAdherent";
            this.Text = "Ajout Adherent";
            this.Load += new System.EventHandler(this.FormAdherent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblNom;
        protected System.Windows.Forms.TextBox tbxNom;
        protected System.Windows.Forms.Label lblPrenom;
        protected System.Windows.Forms.TextBox tbxPrenom;
        protected System.Windows.Forms.Label lblDnd;
        protected System.Windows.Forms.DateTimePicker dtpDn;
        protected System.Windows.Forms.Label lblSexe;
        protected System.Windows.Forms.ListBox lsbSexe;
        protected System.Windows.Forms.Label lblNumTel;
        protected System.Windows.Forms.TextBox tbxNumTel;
        protected System.Windows.Forms.Label lblEmail;
        protected System.Windows.Forms.TextBox tbxEmail;
        protected System.Windows.Forms.Label lblNumTelParent;
        protected System.Windows.Forms.TextBox tbxNumTelParent;
        protected System.Windows.Forms.Label lblClasse;
        protected System.Windows.Forms.ListBox lsbClasse;
        protected System.Windows.Forms.Button btnValider;
        protected System.Windows.Forms.Label lblLogin;
        protected System.Windows.Forms.TextBox tbxLogin;
        protected System.Windows.Forms.Label lblMdp;
        protected System.Windows.Forms.TextBox tbxMdp;
        protected System.Windows.Forms.Label lblErreur;
    }
}