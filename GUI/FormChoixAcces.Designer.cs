namespace GUI
{
    partial class FormChoixAcces
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
            this.labelAccesTitre = new System.Windows.Forms.Label();
            this.buttonAccesCompta = new System.Windows.Forms.Button();
            this.buttonAccesAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAccesTitre
            // 
            this.labelAccesTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccesTitre.Location = new System.Drawing.Point(11, 25);
            this.labelAccesTitre.Name = "labelAccesTitre";
            this.labelAccesTitre.Size = new System.Drawing.Size(416, 42);
            this.labelAccesTitre.TabIndex = 5;
            this.labelAccesTitre.Text = "Accès";
            this.labelAccesTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAccesCompta
            // 
            this.buttonAccesCompta.Location = new System.Drawing.Point(124, 171);
            this.buttonAccesCompta.Name = "buttonAccesCompta";
            this.buttonAccesCompta.Size = new System.Drawing.Size(190, 54);
            this.buttonAccesCompta.TabIndex = 4;
            this.buttonAccesCompta.Text = "Accès Comptabilité";
            this.buttonAccesCompta.UseVisualStyleBackColor = true;
            this.buttonAccesCompta.Click += new System.EventHandler(this.buttonAccesCompta_Click);
            // 
            // buttonAccesAdmin
            // 
            this.buttonAccesAdmin.Location = new System.Drawing.Point(124, 95);
            this.buttonAccesAdmin.Name = "buttonAccesAdmin";
            this.buttonAccesAdmin.Size = new System.Drawing.Size(190, 54);
            this.buttonAccesAdmin.TabIndex = 3;
            this.buttonAccesAdmin.Text = "Accès Administration";
            this.buttonAccesAdmin.UseVisualStyleBackColor = true;
            this.buttonAccesAdmin.Click += new System.EventHandler(this.buttonAccesAdmin_Click);
            // 
            // FormChoixAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 250);
            this.Controls.Add(this.labelAccesTitre);
            this.Controls.Add(this.buttonAccesCompta);
            this.Controls.Add(this.buttonAccesAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormChoixAcces";
            this.Text = "Choix Accès";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAccesTitre;
        private System.Windows.Forms.Button buttonAccesCompta;
        private System.Windows.Forms.Button buttonAccesAdmin;
    }
}