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
            this.lblAccesTitre = new System.Windows.Forms.Label();
            this.btnAccesCompta = new System.Windows.Forms.Button();
            this.btnAccesAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccesTitre
            // 
            this.lblAccesTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesTitre.Location = new System.Drawing.Point(15, 31);
            this.lblAccesTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccesTitre.Name = "lblAccesTitre";
            this.lblAccesTitre.Size = new System.Drawing.Size(555, 52);
            this.lblAccesTitre.TabIndex = 5;
            this.lblAccesTitre.Text = "Accès";
            this.lblAccesTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccesCompta
            // 
            this.btnAccesCompta.Location = new System.Drawing.Point(165, 210);
            this.btnAccesCompta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccesCompta.Name = "btnAccesCompta";
            this.btnAccesCompta.Size = new System.Drawing.Size(253, 66);
            this.btnAccesCompta.TabIndex = 4;
            this.btnAccesCompta.Text = "Accès Comptabilité";
            this.btnAccesCompta.UseVisualStyleBackColor = true;
            this.btnAccesCompta.Click += new System.EventHandler(this.btnAccesCompta_Click);
            // 
            // btnAccesAdmin
            // 
            this.btnAccesAdmin.Location = new System.Drawing.Point(165, 117);
            this.btnAccesAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccesAdmin.Name = "btnAccesAdmin";
            this.btnAccesAdmin.Size = new System.Drawing.Size(253, 66);
            this.btnAccesAdmin.TabIndex = 3;
            this.btnAccesAdmin.Text = "Accès Administration";
            this.btnAccesAdmin.UseVisualStyleBackColor = true;
            this.btnAccesAdmin.Click += new System.EventHandler(this.btnAccesAdmin_Click);
            // 
            // FormChoixAcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 308);
            this.Controls.Add(this.lblAccesTitre);
            this.Controls.Add(this.btnAccesCompta);
            this.Controls.Add(this.btnAccesAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormChoixAcces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choix Accès";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAccesTitre;
        private System.Windows.Forms.Button btnAccesCompta;
        private System.Windows.Forms.Button btnAccesAdmin;
    }
}