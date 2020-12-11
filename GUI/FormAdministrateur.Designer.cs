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
            this.components = new System.ComponentModel.Container();
            this.labelTitreAdmin = new System.Windows.Forms.Label();
            this.dataGridViewListeAdherants = new System.Windows.Forms.DataGridView();
            this.pPEDataSet = new GUI.PPEDataSet();
            this.aDHERENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDHERENTTableAdapter = new GUI.PPEDataSetTableAdapters.ADHERENTTableAdapter();
            this.nomadherentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomadherentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAjoutEleve = new System.Windows.Forms.Button();
            this.buttonModifierEleve = new System.Windows.Forms.Button();
            this.buttonSupprimerEleve = new System.Windows.Forms.Button();
            this.groupBoxInfoAdherant = new System.Windows.Forms.GroupBox();
            this.labelNomAdherant = new System.Windows.Forms.Label();
            this.labelPrenomAdherant = new System.Windows.Forms.Label();
            this.labelClasseAdherant = new System.Windows.Forms.Label();
            this.labelNumParentAdherant = new System.Windows.Forms.Label();
            this.labelTelAdherant = new System.Windows.Forms.Label();
            this.labelMailAdherant = new System.Windows.Forms.Label();
            this.labelDateNaissanceAdherant = new System.Windows.Forms.Label();
            this.buttonAccesStatistique = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelClasse = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelTelParent = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelDateNaissance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeAdherants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource)).BeginInit();
            this.groupBoxInfoAdherant.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitreAdmin
            // 
            this.labelTitreAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreAdmin.Location = new System.Drawing.Point(12, 9);
            this.labelTitreAdmin.Name = "labelTitreAdmin";
            this.labelTitreAdmin.Size = new System.Drawing.Size(776, 64);
            this.labelTitreAdmin.TabIndex = 0;
            this.labelTitreAdmin.Text = "Administrateur";
            this.labelTitreAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewListeAdherants
            // 
            this.dataGridViewListeAdherants.AutoGenerateColumns = false;
            this.dataGridViewListeAdherants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeAdherants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomadherentDataGridViewTextBoxColumn,
            this.prenomadherentDataGridViewTextBoxColumn});
            this.dataGridViewListeAdherants.DataSource = this.aDHERENTBindingSource;
            this.dataGridViewListeAdherants.Location = new System.Drawing.Point(23, 76);
            this.dataGridViewListeAdherants.Name = "dataGridViewListeAdherants";
            this.dataGridViewListeAdherants.Size = new System.Drawing.Size(244, 298);
            this.dataGridViewListeAdherants.TabIndex = 1;
            // 
            // pPEDataSet
            // 
            this.pPEDataSet.DataSetName = "PPEDataSet";
            this.pPEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDHERENTBindingSource
            // 
            this.aDHERENTBindingSource.DataMember = "ADHERENT";
            this.aDHERENTBindingSource.DataSource = this.pPEDataSet;
            // 
            // aDHERENTTableAdapter
            // 
            this.aDHERENTTableAdapter.ClearBeforeFill = true;
            // 
            // nomadherentDataGridViewTextBoxColumn
            // 
            this.nomadherentDataGridViewTextBoxColumn.DataPropertyName = "Nom_adherent";
            this.nomadherentDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomadherentDataGridViewTextBoxColumn.Name = "nomadherentDataGridViewTextBoxColumn";
            // 
            // prenomadherentDataGridViewTextBoxColumn
            // 
            this.prenomadherentDataGridViewTextBoxColumn.DataPropertyName = "Prenom_adherent";
            this.prenomadherentDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomadherentDataGridViewTextBoxColumn.Name = "prenomadherentDataGridViewTextBoxColumn";
            // 
            // buttonAjoutEleve
            // 
            this.buttonAjoutEleve.Location = new System.Drawing.Point(23, 400);
            this.buttonAjoutEleve.Name = "buttonAjoutEleve";
            this.buttonAjoutEleve.Size = new System.Drawing.Size(102, 23);
            this.buttonAjoutEleve.TabIndex = 2;
            this.buttonAjoutEleve.Text = "Ajouter élève";
            this.buttonAjoutEleve.UseVisualStyleBackColor = true;
            // 
            // buttonModifierEleve
            // 
            this.buttonModifierEleve.Location = new System.Drawing.Point(239, 400);
            this.buttonModifierEleve.Name = "buttonModifierEleve";
            this.buttonModifierEleve.Size = new System.Drawing.Size(102, 23);
            this.buttonModifierEleve.TabIndex = 3;
            this.buttonModifierEleve.Text = "Modifier élève";
            this.buttonModifierEleve.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimerEleve
            // 
            this.buttonSupprimerEleve.Location = new System.Drawing.Point(131, 400);
            this.buttonSupprimerEleve.Name = "buttonSupprimerEleve";
            this.buttonSupprimerEleve.Size = new System.Drawing.Size(102, 23);
            this.buttonSupprimerEleve.TabIndex = 4;
            this.buttonSupprimerEleve.Text = "Supprimer élève";
            this.buttonSupprimerEleve.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfoAdherant
            // 
            this.groupBoxInfoAdherant.Controls.Add(this.labelDateNaissance);
            this.groupBoxInfoAdherant.Controls.Add(this.labelMail);
            this.groupBoxInfoAdherant.Controls.Add(this.labelTelParent);
            this.groupBoxInfoAdherant.Controls.Add(this.labelTel);
            this.groupBoxInfoAdherant.Controls.Add(this.labelClasse);
            this.groupBoxInfoAdherant.Controls.Add(this.labelPrenom);
            this.groupBoxInfoAdherant.Controls.Add(this.labelNom);
            this.groupBoxInfoAdherant.Controls.Add(this.labelDateNaissanceAdherant);
            this.groupBoxInfoAdherant.Controls.Add(this.labelMailAdherant);
            this.groupBoxInfoAdherant.Controls.Add(this.labelTelAdherant);
            this.groupBoxInfoAdherant.Controls.Add(this.labelNumParentAdherant);
            this.groupBoxInfoAdherant.Controls.Add(this.labelClasseAdherant);
            this.groupBoxInfoAdherant.Controls.Add(this.labelPrenomAdherant);
            this.groupBoxInfoAdherant.Controls.Add(this.labelNomAdherant);
            this.groupBoxInfoAdherant.Location = new System.Drawing.Point(321, 76);
            this.groupBoxInfoAdherant.Name = "groupBoxInfoAdherant";
            this.groupBoxInfoAdherant.Size = new System.Drawing.Size(449, 244);
            this.groupBoxInfoAdherant.TabIndex = 5;
            this.groupBoxInfoAdherant.TabStop = false;
            this.groupBoxInfoAdherant.Text = "Info Adherant";
            // 
            // labelNomAdherant
            // 
            this.labelNomAdherant.AutoSize = true;
            this.labelNomAdherant.Location = new System.Drawing.Point(6, 24);
            this.labelNomAdherant.Name = "labelNomAdherant";
            this.labelNomAdherant.Size = new System.Drawing.Size(35, 13);
            this.labelNomAdherant.TabIndex = 0;
            this.labelNomAdherant.Text = "Nom :";
            // 
            // labelPrenomAdherant
            // 
            this.labelPrenomAdherant.AutoSize = true;
            this.labelPrenomAdherant.Location = new System.Drawing.Point(6, 55);
            this.labelPrenomAdherant.Name = "labelPrenomAdherant";
            this.labelPrenomAdherant.Size = new System.Drawing.Size(49, 13);
            this.labelPrenomAdherant.TabIndex = 1;
            this.labelPrenomAdherant.Text = "Prénom :";
            // 
            // labelClasseAdherant
            // 
            this.labelClasseAdherant.AutoSize = true;
            this.labelClasseAdherant.Location = new System.Drawing.Point(6, 87);
            this.labelClasseAdherant.Name = "labelClasseAdherant";
            this.labelClasseAdherant.Size = new System.Drawing.Size(44, 13);
            this.labelClasseAdherant.TabIndex = 2;
            this.labelClasseAdherant.Text = "Classe :";
            // 
            // labelNumParentAdherant
            // 
            this.labelNumParentAdherant.AutoSize = true;
            this.labelNumParentAdherant.Location = new System.Drawing.Point(6, 151);
            this.labelNumParentAdherant.Name = "labelNumParentAdherant";
            this.labelNumParentAdherant.Size = new System.Drawing.Size(138, 13);
            this.labelNumParentAdherant.TabIndex = 3;
            this.labelNumParentAdherant.Text = "Numéro téléphone parents :";
            // 
            // labelTelAdherant
            // 
            this.labelTelAdherant.AutoSize = true;
            this.labelTelAdherant.Location = new System.Drawing.Point(6, 117);
            this.labelTelAdherant.Name = "labelTelAdherant";
            this.labelTelAdherant.Size = new System.Drawing.Size(100, 13);
            this.labelTelAdherant.TabIndex = 4;
            this.labelTelAdherant.Text = "Numéro téléphone :";
            // 
            // labelMailAdherant
            // 
            this.labelMailAdherant.AutoSize = true;
            this.labelMailAdherant.Location = new System.Drawing.Point(6, 183);
            this.labelMailAdherant.Name = "labelMailAdherant";
            this.labelMailAdherant.Size = new System.Drawing.Size(72, 13);
            this.labelMailAdherant.TabIndex = 5;
            this.labelMailAdherant.Text = "Adresse mail :";
            // 
            // labelDateNaissanceAdherant
            // 
            this.labelDateNaissanceAdherant.AutoSize = true;
            this.labelDateNaissanceAdherant.Location = new System.Drawing.Point(6, 215);
            this.labelDateNaissanceAdherant.Name = "labelDateNaissanceAdherant";
            this.labelDateNaissanceAdherant.Size = new System.Drawing.Size(102, 13);
            this.labelDateNaissanceAdherant.TabIndex = 6;
            this.labelDateNaissanceAdherant.Text = "Date de naissance :";
            // 
            // buttonAccesStatistique
            // 
            this.buttonAccesStatistique.Location = new System.Drawing.Point(321, 326);
            this.buttonAccesStatistique.Name = "buttonAccesStatistique";
            this.buttonAccesStatistique.Size = new System.Drawing.Size(449, 48);
            this.buttonAccesStatistique.TabIndex = 6;
            this.buttonAccesStatistique.Text = "Accès statistique";
            this.buttonAccesStatistique.UseVisualStyleBackColor = true;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(48, 24);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(0, 13);
            this.labelNom.TabIndex = 7;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(61, 55);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(0, 13);
            this.labelPrenom.TabIndex = 8;
            // 
            // labelClasse
            // 
            this.labelClasse.AutoSize = true;
            this.labelClasse.Location = new System.Drawing.Point(56, 87);
            this.labelClasse.Name = "labelClasse";
            this.labelClasse.Size = new System.Drawing.Size(0, 13);
            this.labelClasse.TabIndex = 9;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(112, 117);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(0, 13);
            this.labelTel.TabIndex = 10;
            // 
            // labelTelParent
            // 
            this.labelTelParent.AutoSize = true;
            this.labelTelParent.Location = new System.Drawing.Point(150, 151);
            this.labelTelParent.Name = "labelTelParent";
            this.labelTelParent.Size = new System.Drawing.Size(0, 13);
            this.labelTelParent.TabIndex = 11;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(84, 183);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(0, 13);
            this.labelMail.TabIndex = 12;
            // 
            // labelDateNaissance
            // 
            this.labelDateNaissance.AutoSize = true;
            this.labelDateNaissance.Location = new System.Drawing.Point(112, 215);
            this.labelDateNaissance.Name = "labelDateNaissance";
            this.labelDateNaissance.Size = new System.Drawing.Size(0, 13);
            this.labelDateNaissance.TabIndex = 13;
            // 
            // FormAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAccesStatistique);
            this.Controls.Add(this.groupBoxInfoAdherant);
            this.Controls.Add(this.buttonSupprimerEleve);
            this.Controls.Add(this.buttonModifierEleve);
            this.Controls.Add(this.buttonAjoutEleve);
            this.Controls.Add(this.dataGridViewListeAdherants);
            this.Controls.Add(this.labelTitreAdmin);
            this.Name = "FormAdministrateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrateur";
            this.Load += new System.EventHandler(this.FormAdministrateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeAdherants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDHERENTBindingSource)).EndInit();
            this.groupBoxInfoAdherant.ResumeLayout(false);
            this.groupBoxInfoAdherant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitreAdmin;
        private System.Windows.Forms.DataGridView dataGridViewListeAdherants;
        private PPEDataSet pPEDataSet;
        private System.Windows.Forms.BindingSource aDHERENTBindingSource;
        private PPEDataSetTableAdapters.ADHERENTTableAdapter aDHERENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomadherentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomadherentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAjoutEleve;
        private System.Windows.Forms.Button buttonModifierEleve;
        private System.Windows.Forms.Button buttonSupprimerEleve;
        private System.Windows.Forms.GroupBox groupBoxInfoAdherant;
        private System.Windows.Forms.Label labelDateNaissanceAdherant;
        private System.Windows.Forms.Label labelMailAdherant;
        private System.Windows.Forms.Label labelTelAdherant;
        private System.Windows.Forms.Label labelNumParentAdherant;
        private System.Windows.Forms.Label labelClasseAdherant;
        private System.Windows.Forms.Label labelPrenomAdherant;
        private System.Windows.Forms.Label labelNomAdherant;
        private System.Windows.Forms.Button buttonAccesStatistique;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelParent;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelClasse;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
    }
}