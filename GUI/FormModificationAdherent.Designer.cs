
namespace GUI
{
    partial class FormModificationAdherent
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
            this.cbxAfficherMdp = new System.Windows.Forms.CheckBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
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
            this.lblNomModif = new System.Windows.Forms.Label();
            this.lblPrenomModif = new System.Windows.Forms.Label();
            this.lblDdnModif = new System.Windows.Forms.Label();
            this.lblGenreModif = new System.Windows.Forms.Label();
            this.lblNumModif = new System.Windows.Forms.Label();
            this.lblEmailModif = new System.Windows.Forms.Label();
            this.lblLoginModif = new System.Windows.Forms.Label();
            this.lblMdpModif = new System.Windows.Forms.Label();
            this.lblNumParentModif = new System.Windows.Forms.Label();
            this.lblClasseModif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxAfficherMdp
            // 
            this.cbxAfficherMdp.AutoSize = true;
            this.cbxAfficherMdp.Location = new System.Drawing.Point(297, 252);
            this.cbxAfficherMdp.Name = "cbxAfficherMdp";
            this.cbxAfficherMdp.Size = new System.Drawing.Size(137, 17);
            this.cbxAfficherMdp.TabIndex = 58;
            this.cbxAfficherMdp.Text = "Cacher le mot de passe";
            this.cbxAfficherMdp.UseVisualStyleBackColor = true;
            this.cbxAfficherMdp.CheckedChanged += new System.EventHandler(this.cbxAfficherMdp_CheckedChanged);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(160, 16);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNom.MaxLength = 50;
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(95, 20);
            this.tbxNom.TabIndex = 50;
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            // 
            // lblErreur
            // 
            this.lblErreur.Location = new System.Drawing.Point(121, 347);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(237, 28);
            this.lblErreur.TabIndex = 72;
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(202, 250);
            this.tbxMdp.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMdp.MaxLength = 50;
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(90, 20);
            this.tbxMdp.TabIndex = 57;
            this.tbxMdp.TextChanged += new System.EventHandler(this.tbxMdp_TextChanged);
            this.tbxMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMdp_KeyPress);
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(121, 253);
            this.lblMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 71;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(164, 218);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLogin.MaxLength = 50;
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(94, 20);
            this.tbxLogin.TabIndex = 56;
            this.tbxLogin.TextChanged += new System.EventHandler(this.tbxLogin_TextChanged);
            this.tbxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLogin_KeyPress);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(121, 221);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 70;
            this.lblLogin.Text = "Login :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(121, 19);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 62;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(121, 53);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 63;
            this.lblPrenom.Text = "Prenom :";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(174, 50);
            this.tbxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPrenom.MaxLength = 50;
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(95, 20);
            this.tbxPrenom.TabIndex = 51;
            this.tbxPrenom.TextChanged += new System.EventHandler(this.tbxPrenom_TextChanged);
            // 
            // lblDnd
            // 
            this.lblDnd.AutoSize = true;
            this.lblDnd.Location = new System.Drawing.Point(121, 84);
            this.lblDnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDnd.Name = "lblDnd";
            this.lblDnd.Size = new System.Drawing.Size(102, 13);
            this.lblDnd.TabIndex = 64;
            this.lblDnd.Text = "Date de naissance :";
            // 
            // dtpDn
            // 
            this.dtpDn.CustomFormat = "dd/MM/yyyy";
            this.dtpDn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDn.Location = new System.Drawing.Point(227, 82);
            this.dtpDn.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDn.Name = "dtpDn";
            this.dtpDn.Size = new System.Drawing.Size(83, 20);
            this.dtpDn.TabIndex = 52;
            this.dtpDn.Value = new System.DateTime(2020, 12, 14, 0, 0, 0, 0);
            this.dtpDn.ValueChanged += new System.EventHandler(this.dtpDn_ValueChanged);
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(121, 120);
            this.lblSexe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(42, 13);
            this.lblSexe.TabIndex = 65;
            this.lblSexe.Text = "Genre :";
            // 
            // lsbSexe
            // 
            this.lsbSexe.FormattingEnabled = true;
            this.lsbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Autre"});
            this.lsbSexe.Location = new System.Drawing.Point(167, 115);
            this.lsbSexe.Margin = new System.Windows.Forms.Padding(2);
            this.lsbSexe.Name = "lsbSexe";
            this.lsbSexe.Size = new System.Drawing.Size(62, 30);
            this.lsbSexe.TabIndex = 53;
            this.lsbSexe.SelectedIndexChanged += new System.EventHandler(this.lsbSexe_SelectedIndexChanged);
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(121, 158);
            this.lblNumTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(115, 13);
            this.lblNumTel.TabIndex = 66;
            this.lblNumTel.Text = "Numéro de téléphone :";
            // 
            // tbxNumTel
            // 
            this.tbxNumTel.Location = new System.Drawing.Point(240, 158);
            this.tbxNumTel.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNumTel.MaxLength = 50;
            this.tbxNumTel.Name = "tbxNumTel";
            this.tbxNumTel.Size = new System.Drawing.Size(106, 20);
            this.tbxNumTel.TabIndex = 54;
            this.tbxNumTel.TextChanged += new System.EventHandler(this.tbxNumTel_TextChanged);
            this.tbxNumTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumTel_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(121, 188);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 67;
            this.lblEmail.Text = "Email :";
            // 
            // tbxEmail
            // 
            this.tbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbxEmail.Location = new System.Drawing.Point(163, 185);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmail.MaxLength = 50;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(129, 20);
            this.tbxEmail.TabIndex = 55;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            this.tbxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmail_KeyPress);
            // 
            // lblNumTelParent
            // 
            this.lblNumTelParent.AutoSize = true;
            this.lblNumTelParent.Location = new System.Drawing.Point(121, 284);
            this.lblNumTelParent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTelParent.Name = "lblNumTelParent";
            this.lblNumTelParent.Size = new System.Drawing.Size(148, 13);
            this.lblNumTelParent.TabIndex = 68;
            this.lblNumTelParent.Text = "Numéro de téléphone parent :";
            // 
            // tbxNumTelParent
            // 
            this.tbxNumTelParent.Location = new System.Drawing.Point(273, 281);
            this.tbxNumTelParent.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNumTelParent.MaxLength = 50;
            this.tbxNumTelParent.Name = "tbxNumTelParent";
            this.tbxNumTelParent.Size = new System.Drawing.Size(106, 20);
            this.tbxNumTelParent.TabIndex = 59;
            this.tbxNumTelParent.TextChanged += new System.EventHandler(this.tbxNumTelParent_TextChanged);
            this.tbxNumTelParent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumTelParent_KeyPress);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(121, 322);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(44, 13);
            this.lblClasse.TabIndex = 69;
            this.lblClasse.Text = "Classe :";
            // 
            // lsbClasse
            // 
            this.lsbClasse.FormattingEnabled = true;
            this.lsbClasse.Location = new System.Drawing.Point(167, 315);
            this.lsbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.lsbClasse.Name = "lsbClasse";
            this.lsbClasse.Size = new System.Drawing.Size(88, 30);
            this.lsbClasse.TabIndex = 60;
            this.lsbClasse.SelectedIndexChanged += new System.EventHandler(this.lsbClasse_SelectedIndexChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(121, 378);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(237, 56);
            this.btnValider.TabIndex = 61;
            this.btnValider.Text = "Modifier l\'adhérent";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblNomModif
            // 
            this.lblNomModif.AutoSize = true;
            this.lblNomModif.Location = new System.Drawing.Point(81, 19);
            this.lblNomModif.Name = "lblNomModif";
            this.lblNomModif.Size = new System.Drawing.Size(0, 13);
            this.lblNomModif.TabIndex = 73;
            // 
            // lblPrenomModif
            // 
            this.lblPrenomModif.AutoSize = true;
            this.lblPrenomModif.Location = new System.Drawing.Point(81, 53);
            this.lblPrenomModif.Name = "lblPrenomModif";
            this.lblPrenomModif.Size = new System.Drawing.Size(0, 13);
            this.lblPrenomModif.TabIndex = 74;
            // 
            // lblDdnModif
            // 
            this.lblDdnModif.AutoSize = true;
            this.lblDdnModif.Location = new System.Drawing.Point(81, 84);
            this.lblDdnModif.Name = "lblDdnModif";
            this.lblDdnModif.Size = new System.Drawing.Size(0, 13);
            this.lblDdnModif.TabIndex = 75;
            // 
            // lblGenreModif
            // 
            this.lblGenreModif.AutoSize = true;
            this.lblGenreModif.Location = new System.Drawing.Point(81, 120);
            this.lblGenreModif.Name = "lblGenreModif";
            this.lblGenreModif.Size = new System.Drawing.Size(0, 13);
            this.lblGenreModif.TabIndex = 76;
            // 
            // lblNumModif
            // 
            this.lblNumModif.AutoSize = true;
            this.lblNumModif.Location = new System.Drawing.Point(81, 158);
            this.lblNumModif.Name = "lblNumModif";
            this.lblNumModif.Size = new System.Drawing.Size(0, 13);
            this.lblNumModif.TabIndex = 77;
            // 
            // lblEmailModif
            // 
            this.lblEmailModif.AutoSize = true;
            this.lblEmailModif.Location = new System.Drawing.Point(81, 188);
            this.lblEmailModif.Name = "lblEmailModif";
            this.lblEmailModif.Size = new System.Drawing.Size(0, 13);
            this.lblEmailModif.TabIndex = 78;
            // 
            // lblLoginModif
            // 
            this.lblLoginModif.AutoSize = true;
            this.lblLoginModif.Location = new System.Drawing.Point(81, 221);
            this.lblLoginModif.Name = "lblLoginModif";
            this.lblLoginModif.Size = new System.Drawing.Size(0, 13);
            this.lblLoginModif.TabIndex = 79;
            // 
            // lblMdpModif
            // 
            this.lblMdpModif.AutoSize = true;
            this.lblMdpModif.Location = new System.Drawing.Point(81, 252);
            this.lblMdpModif.Name = "lblMdpModif";
            this.lblMdpModif.Size = new System.Drawing.Size(0, 13);
            this.lblMdpModif.TabIndex = 80;
            // 
            // lblNumParentModif
            // 
            this.lblNumParentModif.AutoSize = true;
            this.lblNumParentModif.Location = new System.Drawing.Point(81, 284);
            this.lblNumParentModif.Name = "lblNumParentModif";
            this.lblNumParentModif.Size = new System.Drawing.Size(0, 13);
            this.lblNumParentModif.TabIndex = 81;
            // 
            // lblClasseModif
            // 
            this.lblClasseModif.AutoSize = true;
            this.lblClasseModif.Location = new System.Drawing.Point(81, 322);
            this.lblClasseModif.Name = "lblClasseModif";
            this.lblClasseModif.Size = new System.Drawing.Size(0, 13);
            this.lblClasseModif.TabIndex = 82;
            // 
            // FormModificationAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 442);
            this.Controls.Add(this.lblClasseModif);
            this.Controls.Add(this.lblNumParentModif);
            this.Controls.Add(this.lblMdpModif);
            this.Controls.Add(this.lblLoginModif);
            this.Controls.Add(this.lblEmailModif);
            this.Controls.Add(this.lblNumModif);
            this.Controls.Add(this.lblGenreModif);
            this.Controls.Add(this.lblDdnModif);
            this.Controls.Add(this.lblPrenomModif);
            this.Controls.Add(this.lblNomModif);
            this.Controls.Add(this.cbxAfficherMdp);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNom);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormModificationAdherent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier un Adhérent";
            this.Load += new System.EventHandler(this.FormModificationAdherent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxAfficherMdp;
        protected System.Windows.Forms.TextBox tbxNom;
        protected System.Windows.Forms.Label lblErreur;
        protected System.Windows.Forms.TextBox tbxMdp;
        protected System.Windows.Forms.Label lblMdp;
        protected System.Windows.Forms.TextBox tbxLogin;
        protected System.Windows.Forms.Label lblLogin;
        protected System.Windows.Forms.Label lblNom;
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
        private System.Windows.Forms.Label lblNomModif;
        private System.Windows.Forms.Label lblPrenomModif;
        private System.Windows.Forms.Label lblDdnModif;
        private System.Windows.Forms.Label lblGenreModif;
        private System.Windows.Forms.Label lblNumModif;
        private System.Windows.Forms.Label lblEmailModif;
        private System.Windows.Forms.Label lblLoginModif;
        private System.Windows.Forms.Label lblMdpModif;
        private System.Windows.Forms.Label lblNumParentModif;
        private System.Windows.Forms.Label lblClasseModif;
    }
}