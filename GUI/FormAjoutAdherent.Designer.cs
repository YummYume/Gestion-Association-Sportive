
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
            this.cbxAfficherMdp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(114, 18);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 28;
            this.lblNom.Text = "Nom :";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(153, 15);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(76, 20);
            this.tbxNom.TabIndex = 1;
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(114, 52);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 30;
            this.lblPrenom.Text = "Prenom :";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(167, 49);
            this.tbxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(76, 20);
            this.tbxPrenom.TabIndex = 2;
            this.tbxPrenom.TextChanged += new System.EventHandler(this.tbxPrenom_TextChanged);
            // 
            // lblDnd
            // 
            this.lblDnd.AutoSize = true;
            this.lblDnd.Location = new System.Drawing.Point(114, 83);
            this.lblDnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDnd.Name = "lblDnd";
            this.lblDnd.Size = new System.Drawing.Size(102, 13);
            this.lblDnd.TabIndex = 32;
            this.lblDnd.Text = "Date de naissance :";
            // 
            // dtpDn
            // 
            this.dtpDn.CustomFormat = "dd/MM/yyyy";
            this.dtpDn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDn.Location = new System.Drawing.Point(220, 81);
            this.dtpDn.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDn.Name = "dtpDn";
            this.dtpDn.Size = new System.Drawing.Size(83, 20);
            this.dtpDn.TabIndex = 3;
            this.dtpDn.Value = new System.DateTime(2020, 12, 14, 0, 0, 0, 0);
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(114, 119);
            this.lblSexe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(42, 13);
            this.lblSexe.TabIndex = 33;
            this.lblSexe.Text = "Genre :";
            // 
            // lsbSexe
            // 
            this.lsbSexe.FormattingEnabled = true;
            this.lsbSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme",
            "Autre"});
            this.lsbSexe.Location = new System.Drawing.Point(160, 114);
            this.lsbSexe.Margin = new System.Windows.Forms.Padding(2);
            this.lsbSexe.Name = "lsbSexe";
            this.lsbSexe.Size = new System.Drawing.Size(62, 30);
            this.lsbSexe.TabIndex = 4;
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(114, 157);
            this.lblNumTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(115, 13);
            this.lblNumTel.TabIndex = 34;
            this.lblNumTel.Text = "Numéro de téléphone :";
            // 
            // tbxNumTel
            // 
            this.tbxNumTel.Location = new System.Drawing.Point(233, 157);
            this.tbxNumTel.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNumTel.Name = "tbxNumTel";
            this.tbxNumTel.Size = new System.Drawing.Size(106, 20);
            this.tbxNumTel.TabIndex = 5;
            this.tbxNumTel.TextChanged += new System.EventHandler(this.tbxNumTel_TextChanged);
            this.tbxNumTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumTel_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(114, 187);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email :";
            // 
            // tbxEmail
            // 
            this.tbxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbxEmail.Location = new System.Drawing.Point(156, 184);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(76, 20);
            this.tbxEmail.TabIndex = 6;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            this.tbxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmail_KeyPress);
            // 
            // lblNumTelParent
            // 
            this.lblNumTelParent.AutoSize = true;
            this.lblNumTelParent.Location = new System.Drawing.Point(114, 283);
            this.lblNumTelParent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTelParent.Name = "lblNumTelParent";
            this.lblNumTelParent.Size = new System.Drawing.Size(148, 13);
            this.lblNumTelParent.TabIndex = 38;
            this.lblNumTelParent.Text = "Numéro de téléphone parent :";
            // 
            // tbxNumTelParent
            // 
            this.tbxNumTelParent.Location = new System.Drawing.Point(266, 280);
            this.tbxNumTelParent.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNumTelParent.Name = "tbxNumTelParent";
            this.tbxNumTelParent.Size = new System.Drawing.Size(106, 20);
            this.tbxNumTelParent.TabIndex = 10;
            this.tbxNumTelParent.TextChanged += new System.EventHandler(this.tbxNumTelParent_TextChanged);
            this.tbxNumTelParent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumTelParent_KeyPress);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(114, 321);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(44, 13);
            this.lblClasse.TabIndex = 40;
            this.lblClasse.Text = "Classe :";
            // 
            // lsbClasse
            // 
            this.lsbClasse.FormattingEnabled = true;
            this.lsbClasse.Location = new System.Drawing.Point(160, 314);
            this.lsbClasse.Margin = new System.Windows.Forms.Padding(2);
            this.lsbClasse.Name = "lsbClasse";
            this.lsbClasse.Size = new System.Drawing.Size(62, 30);
            this.lsbClasse.TabIndex = 11;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(114, 377);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(237, 56);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Ajouter l\'adhérent";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(114, 220);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 45;
            this.lblLogin.Text = "Login :";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(157, 217);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(76, 20);
            this.tbxLogin.TabIndex = 7;
            this.tbxLogin.TextChanged += new System.EventHandler(this.tbxLogin_TextChanged);
            this.tbxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLogin_KeyPress);
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(114, 252);
            this.lblMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 47;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(195, 249);
            this.tbxMdp.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(90, 20);
            this.tbxMdp.TabIndex = 8;
            this.tbxMdp.TextChanged += new System.EventHandler(this.tbxMdp_TextChanged);
            this.tbxMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMdp_KeyPress);
            // 
            // lblErreur
            // 
            this.lblErreur.Location = new System.Drawing.Point(114, 346);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(237, 28);
            this.lblErreur.TabIndex = 49;
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxAfficherMdp
            // 
            this.cbxAfficherMdp.AutoSize = true;
            this.cbxAfficherMdp.Location = new System.Drawing.Point(290, 251);
            this.cbxAfficherMdp.Name = "cbxAfficherMdp";
            this.cbxAfficherMdp.Size = new System.Drawing.Size(137, 17);
            this.cbxAfficherMdp.TabIndex = 9;
            this.cbxAfficherMdp.Text = "Cacher le mot de passe";
            this.cbxAfficherMdp.UseVisualStyleBackColor = true;
            this.cbxAfficherMdp.CheckedChanged += new System.EventHandler(this.cbxAfficherMdp_CheckedChanged);
            // 
            // FormAjoutAdherent
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 442);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormAjoutAdherent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un adhérent";
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
        private System.Windows.Forms.CheckBox cbxAfficherMdp;
    }
}