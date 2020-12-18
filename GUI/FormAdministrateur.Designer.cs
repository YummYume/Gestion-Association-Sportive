namespace GUI
{
    partial class FormAdministrateur
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
            this.lblTitreAdmin = new System.Windows.Forms.Label();
            this.dtgListeAdherants = new System.Windows.Forms.DataGridView();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.btnModifierEleve = new System.Windows.Forms.Button();
            this.btnSupprimerEleve = new System.Windows.Forms.Button();
            this.gbxInfoAdherant = new System.Windows.Forms.GroupBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelParent = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDateNaissanceAdherant = new System.Windows.Forms.Label();
            this.lblMailAdherant = new System.Windows.Forms.Label();
            this.lblTelAdherant = new System.Windows.Forms.Label();
            this.lblNumParentAdherant = new System.Windows.Forms.Label();
            this.lblClasseAdherant = new System.Windows.Forms.Label();
            this.lblPrenomAdherant = new System.Windows.Forms.Label();
            this.lblNomAdherant = new System.Windows.Forms.Label();
            this.btnAccesStatistique = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeAdherants)).BeginInit();
            this.gbxInfoAdherant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitreAdmin
            // 
            this.lblTitreAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAdmin.Location = new System.Drawing.Point(12, 9);
            this.lblTitreAdmin.Name = "lblTitreAdmin";
            this.lblTitreAdmin.Size = new System.Drawing.Size(776, 64);
            this.lblTitreAdmin.TabIndex = 0;
            this.lblTitreAdmin.Text = "Administrateur";
            this.lblTitreAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgListeAdherants
            // 
            this.dtgListeAdherants.AllowUserToAddRows = false;
            this.dtgListeAdherants.AllowUserToDeleteRows = false;
            this.dtgListeAdherants.AllowUserToResizeColumns = false;
            this.dtgListeAdherants.AllowUserToResizeRows = false;
            this.dtgListeAdherants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListeAdherants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgListeAdherants.Location = new System.Drawing.Point(32, 76);
            this.dtgListeAdherants.MultiSelect = false;
            this.dtgListeAdherants.Name = "dtgListeAdherants";
            this.dtgListeAdherants.ReadOnly = true;
            this.dtgListeAdherants.RowHeadersWidth = 51;
            this.dtgListeAdherants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgListeAdherants.Size = new System.Drawing.Size(252, 298);
            this.dtgListeAdherants.TabIndex = 1;
            this.dtgListeAdherants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListeAdherants_CellEnter);
            this.dtgListeAdherants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListeAdherants_CellEnter);
            this.dtgListeAdherants.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListeAdherants_CellEnter);
            // 
            // btnAjoutEleve
            // 
            this.btnAjoutEleve.Location = new System.Drawing.Point(23, 400);
            this.btnAjoutEleve.Name = "btnAjoutEleve";
            this.btnAjoutEleve.Size = new System.Drawing.Size(102, 23);
            this.btnAjoutEleve.TabIndex = 2;
            this.btnAjoutEleve.Text = "Ajouter élève";
            this.btnAjoutEleve.UseVisualStyleBackColor = true;
            this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
            // 
            // btnModifierEleve
            // 
            this.btnModifierEleve.Location = new System.Drawing.Point(239, 400);
            this.btnModifierEleve.Name = "btnModifierEleve";
            this.btnModifierEleve.Size = new System.Drawing.Size(102, 23);
            this.btnModifierEleve.TabIndex = 4;
            this.btnModifierEleve.Text = "Modifier élève";
            this.btnModifierEleve.UseVisualStyleBackColor = true;
            this.btnModifierEleve.Click += new System.EventHandler(this.btnModifierEleve_Click);
            // 
            // btnSupprimerEleve
            // 
            this.btnSupprimerEleve.Location = new System.Drawing.Point(131, 400);
            this.btnSupprimerEleve.Name = "btnSupprimerEleve";
            this.btnSupprimerEleve.Size = new System.Drawing.Size(102, 23);
            this.btnSupprimerEleve.TabIndex = 3;
            this.btnSupprimerEleve.Text = "Supprimer élève";
            this.btnSupprimerEleve.UseVisualStyleBackColor = true;
            this.btnSupprimerEleve.Click += new System.EventHandler(this.btnSupprimerEleve_Click);
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
            this.gbxInfoAdherant.Controls.Add(this.lblDateNaissanceAdherant);
            this.gbxInfoAdherant.Controls.Add(this.lblMailAdherant);
            this.gbxInfoAdherant.Controls.Add(this.lblTelAdherant);
            this.gbxInfoAdherant.Controls.Add(this.lblNumParentAdherant);
            this.gbxInfoAdherant.Controls.Add(this.lblClasseAdherant);
            this.gbxInfoAdherant.Controls.Add(this.lblPrenomAdherant);
            this.gbxInfoAdherant.Controls.Add(this.lblNomAdherant);
            this.gbxInfoAdherant.Location = new System.Drawing.Point(321, 76);
            this.gbxInfoAdherant.Name = "gbxInfoAdherant";
            this.gbxInfoAdherant.Size = new System.Drawing.Size(449, 244);
            this.gbxInfoAdherant.TabIndex = 5;
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
            // lblDateNaissanceAdherant
            // 
            this.lblDateNaissanceAdherant.AutoSize = true;
            this.lblDateNaissanceAdherant.Location = new System.Drawing.Point(6, 215);
            this.lblDateNaissanceAdherant.Name = "lblDateNaissanceAdherant";
            this.lblDateNaissanceAdherant.Size = new System.Drawing.Size(102, 13);
            this.lblDateNaissanceAdherant.TabIndex = 6;
            this.lblDateNaissanceAdherant.Text = "Date de naissance :";
            // 
            // lblMailAdherant
            // 
            this.lblMailAdherant.AutoSize = true;
            this.lblMailAdherant.Location = new System.Drawing.Point(6, 183);
            this.lblMailAdherant.Name = "lblMailAdherant";
            this.lblMailAdherant.Size = new System.Drawing.Size(72, 13);
            this.lblMailAdherant.TabIndex = 5;
            this.lblMailAdherant.Text = "Adresse mail :";
            // 
            // lblTelAdherant
            // 
            this.lblTelAdherant.AutoSize = true;
            this.lblTelAdherant.Location = new System.Drawing.Point(6, 117);
            this.lblTelAdherant.Name = "lblTelAdherant";
            this.lblTelAdherant.Size = new System.Drawing.Size(100, 13);
            this.lblTelAdherant.TabIndex = 4;
            this.lblTelAdherant.Text = "Numéro téléphone :";
            // 
            // lblNumParentAdherant
            // 
            this.lblNumParentAdherant.AutoSize = true;
            this.lblNumParentAdherant.Location = new System.Drawing.Point(6, 151);
            this.lblNumParentAdherant.Name = "lblNumParentAdherant";
            this.lblNumParentAdherant.Size = new System.Drawing.Size(138, 13);
            this.lblNumParentAdherant.TabIndex = 3;
            this.lblNumParentAdherant.Text = "Numéro téléphone parents :";
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
            // btnAccesStatistique
            // 
            this.btnAccesStatistique.Location = new System.Drawing.Point(321, 326);
            this.btnAccesStatistique.Name = "btnAccesStatistique";
            this.btnAccesStatistique.Size = new System.Drawing.Size(449, 48);
            this.btnAccesStatistique.TabIndex = 5;
            this.btnAccesStatistique.Text = "Accès statistique";
            this.btnAccesStatistique.UseVisualStyleBackColor = true;
            // 
            // FormAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAccesStatistique);
            this.Controls.Add(this.gbxInfoAdherant);
            this.Controls.Add(this.btnSupprimerEleve);
            this.Controls.Add(this.btnModifierEleve);
            this.Controls.Add(this.btnAjoutEleve);
            this.Controls.Add(this.dtgListeAdherants);
            this.Controls.Add(this.lblTitreAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAdministrateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrateur";
            this.Load += new System.EventHandler(this.FormAdministrateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListeAdherants)).EndInit();
            this.gbxInfoAdherant.ResumeLayout(false);
            this.gbxInfoAdherant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitreAdmin;
        private System.Windows.Forms.DataGridView dtgListeAdherants;
        private System.Windows.Forms.Button btnAjoutEleve;
        private System.Windows.Forms.Button btnModifierEleve;
        private System.Windows.Forms.Button btnSupprimerEleve;
        private System.Windows.Forms.GroupBox gbxInfoAdherant;
        private System.Windows.Forms.Label lblDateNaissanceAdherant;
        private System.Windows.Forms.Label lblMailAdherant;
        private System.Windows.Forms.Label lblTelAdherant;
        private System.Windows.Forms.Label lblNumParentAdherant;
        private System.Windows.Forms.Label lblClasseAdherant;
        private System.Windows.Forms.Label lblPrenomAdherant;
        private System.Windows.Forms.Label lblNomAdherant;
        private System.Windows.Forms.Button btnAccesStatistique;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelParent;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
    }
}