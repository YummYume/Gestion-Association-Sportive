
namespace GUI
{
    partial class FormAjoutFlux
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
            this.cbxPrelevementEFF = new System.Windows.Forms.CheckBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDnd = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.tbxMontant = new System.Windows.Forms.TextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lsbBudget = new System.Windows.Forms.ListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbAdherant = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbEvenement = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbxPrelevementEFF
            // 
            this.cbxPrelevementEFF.AutoSize = true;
            this.cbxPrelevementEFF.Location = new System.Drawing.Point(35, 120);
            this.cbxPrelevementEFF.Name = "cbxPrelevementEFF";
            this.cbxPrelevementEFF.Size = new System.Drawing.Size(149, 17);
            this.cbxPrelevementEFF.TabIndex = 58;
            this.cbxPrelevementEFF.Text = "Prélèvement EFF effectué";
            this.cbxPrelevementEFF.UseVisualStyleBackColor = true;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(71, 16);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbxNom.MaxLength = 50;
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(95, 20);
            this.tbxNom.TabIndex = 50;
            // 
            // lblErreur
            // 
            this.lblErreur.Location = new System.Drawing.Point(32, 308);
            this.lblErreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(237, 28);
            this.lblErreur.TabIndex = 72;
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(32, 19);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 62;
            this.lblNom.Text = "Nom :";
            // 
            // lblDnd
            // 
            this.lblDnd.AutoSize = true;
            this.lblDnd.Location = new System.Drawing.Point(32, 53);
            this.lblDnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDnd.Name = "lblDnd";
            this.lblDnd.Size = new System.Drawing.Size(39, 13);
            this.lblDnd.TabIndex = 64;
            this.lblDnd.Text = "Date  :";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(75, 51);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(91, 20);
            this.dtpDate.TabIndex = 52;
            this.dtpDate.Value = new System.DateTime(2020, 12, 14, 0, 0, 0, 0);
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(29, 91);
            this.lblNumTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(52, 13);
            this.lblNumTel.TabIndex = 66;
            this.lblNumTel.Text = "Montant :";
            // 
            // tbxMontant
            // 
            this.tbxMontant.Location = new System.Drawing.Point(85, 88);
            this.tbxMontant.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMontant.MaxLength = 50;
            this.tbxMontant.Name = "tbxMontant";
            this.tbxMontant.Size = new System.Drawing.Size(106, 20);
            this.tbxMontant.TabIndex = 54;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(34, 276);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(47, 13);
            this.lblClasse.TabIndex = 69;
            this.lblClasse.Text = "Budget :";
            // 
            // lsbBudget
            // 
            this.lsbBudget.FormattingEnabled = true;
            this.lsbBudget.Location = new System.Drawing.Point(85, 270);
            this.lsbBudget.Margin = new System.Windows.Forms.Padding(2);
            this.lsbBudget.Name = "lsbBudget";
            this.lsbBudget.Size = new System.Drawing.Size(88, 30);
            this.lsbBudget.TabIndex = 60;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(32, 343);
            this.btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(237, 56);
            this.btnValider.TabIndex = 61;
            this.btnValider.Text = "Ajouter le flux";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Adherant :";
            // 
            // lsbAdherant
            // 
            this.lsbAdherant.FormattingEnabled = true;
            this.lsbAdherant.Location = new System.Drawing.Point(92, 190);
            this.lsbAdherant.Margin = new System.Windows.Forms.Padding(2);
            this.lsbAdherant.Name = "lsbAdherant";
            this.lsbAdherant.Size = new System.Drawing.Size(134, 69);
            this.lsbAdherant.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Evenement :";
            // 
            // lsbEvenement
            // 
            this.lsbEvenement.FormattingEnabled = true;
            this.lsbEvenement.Location = new System.Drawing.Point(105, 149);
            this.lsbEvenement.Margin = new System.Windows.Forms.Padding(2);
            this.lsbEvenement.Name = "lsbEvenement";
            this.lsbEvenement.Size = new System.Drawing.Size(121, 30);
            this.lsbEvenement.TabIndex = 75;
            // 
            // FormAjoutFlux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbEvenement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbAdherant);
            this.Controls.Add(this.cbxPrelevementEFF);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblDnd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.tbxMontant);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lsbBudget);
            this.Controls.Add(this.btnValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAjoutFlux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Flux";
            this.Load += new System.EventHandler(this.FormAjoutFlux_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPrelevementEFF;
        protected System.Windows.Forms.TextBox tbxNom;
        protected System.Windows.Forms.Label lblErreur;
        protected System.Windows.Forms.Label lblNom;
        protected System.Windows.Forms.Label lblDnd;
        protected System.Windows.Forms.DateTimePicker dtpDate;
        protected System.Windows.Forms.Label lblNumTel;
        protected System.Windows.Forms.TextBox tbxMontant;
        protected System.Windows.Forms.Label lblClasse;
        protected System.Windows.Forms.ListBox lsbBudget;
        protected System.Windows.Forms.Button btnValider;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ListBox lsbAdherant;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ListBox lsbEvenement;
    }
}