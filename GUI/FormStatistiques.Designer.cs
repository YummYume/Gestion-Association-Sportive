
namespace GUI
{
    partial class FormStatistiques
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
            this.lblTitreStatistiques = new System.Windows.Forms.Label();
            this.lblNbAdherents = new System.Windows.Forms.Label();
            this.lblNbFilles = new System.Windows.Forms.Label();
            this.lblNbGarcons = new System.Windows.Forms.Label();
            this.dtgDdn = new System.Windows.Forms.DataGridView();
            this.dtgEvenements = new System.Windows.Forms.DataGridView();
            this.dtgAdherents = new System.Windows.Forms.DataGridView();
            this.lblNombreAdherents = new System.Windows.Forms.Label();
            this.lblFilles = new System.Windows.Forms.Label();
            this.lblGarcons = new System.Windows.Forms.Label();
            this.lblDdn = new System.Windows.Forms.Label();
            this.lblEvenements = new System.Windows.Forms.Label();
            this.lblAdherents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvenements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdherents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreStatistiques
            // 
            this.lblTitreStatistiques.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreStatistiques.Location = new System.Drawing.Point(12, 9);
            this.lblTitreStatistiques.Name = "lblTitreStatistiques";
            this.lblTitreStatistiques.Size = new System.Drawing.Size(718, 64);
            this.lblTitreStatistiques.TabIndex = 5;
            this.lblTitreStatistiques.Text = "Statistiques";
            this.lblTitreStatistiques.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNbAdherents
            // 
            this.lblNbAdherents.AutoSize = true;
            this.lblNbAdherents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbAdherents.Location = new System.Drawing.Point(45, 139);
            this.lblNbAdherents.Name = "lblNbAdherents";
            this.lblNbAdherents.Size = new System.Drawing.Size(161, 20);
            this.lblNbAdherents.TabIndex = 6;
            this.lblNbAdherents.Text = "Nombre d\'adhérents :";
            // 
            // lblNbFilles
            // 
            this.lblNbFilles.AutoSize = true;
            this.lblNbFilles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbFilles.Location = new System.Drawing.Point(45, 179);
            this.lblNbFilles.Name = "lblNbFilles";
            this.lblNbFilles.Size = new System.Drawing.Size(53, 20);
            this.lblNbFilles.TabIndex = 7;
            this.lblNbFilles.Text = "Filles :";
            // 
            // lblNbGarcons
            // 
            this.lblNbGarcons.AutoSize = true;
            this.lblNbGarcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbGarcons.Location = new System.Drawing.Point(45, 216);
            this.lblNbGarcons.Name = "lblNbGarcons";
            this.lblNbGarcons.Size = new System.Drawing.Size(78, 20);
            this.lblNbGarcons.TabIndex = 8;
            this.lblNbGarcons.Text = "Garçons :";
            // 
            // dtgDdn
            // 
            this.dtgDdn.AllowUserToAddRows = false;
            this.dtgDdn.AllowUserToDeleteRows = false;
            this.dtgDdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDdn.Location = new System.Drawing.Point(43, 408);
            this.dtgDdn.Name = "dtgDdn";
            this.dtgDdn.ReadOnly = true;
            this.dtgDdn.Size = new System.Drawing.Size(251, 173);
            this.dtgDdn.TabIndex = 9;
            // 
            // dtgEvenements
            // 
            this.dtgEvenements.AllowUserToAddRows = false;
            this.dtgEvenements.AllowUserToDeleteRows = false;
            this.dtgEvenements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEvenements.Location = new System.Drawing.Point(447, 154);
            this.dtgEvenements.Name = "dtgEvenements";
            this.dtgEvenements.ReadOnly = true;
            this.dtgEvenements.Size = new System.Drawing.Size(251, 173);
            this.dtgEvenements.TabIndex = 10;
            // 
            // dtgAdherents
            // 
            this.dtgAdherents.AllowUserToAddRows = false;
            this.dtgAdherents.AllowUserToDeleteRows = false;
            this.dtgAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAdherents.Location = new System.Drawing.Point(447, 410);
            this.dtgAdherents.Name = "dtgAdherents";
            this.dtgAdherents.ReadOnly = true;
            this.dtgAdherents.Size = new System.Drawing.Size(251, 173);
            this.dtgAdherents.TabIndex = 11;
            // 
            // lblNombreAdherents
            // 
            this.lblNombreAdherents.AutoSize = true;
            this.lblNombreAdherents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAdherents.Location = new System.Drawing.Point(206, 141);
            this.lblNombreAdherents.Name = "lblNombreAdherents";
            this.lblNombreAdherents.Size = new System.Drawing.Size(0, 20);
            this.lblNombreAdherents.TabIndex = 12;
            // 
            // lblFilles
            // 
            this.lblFilles.AutoSize = true;
            this.lblFilles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilles.Location = new System.Drawing.Point(98, 181);
            this.lblFilles.Name = "lblFilles";
            this.lblFilles.Size = new System.Drawing.Size(0, 20);
            this.lblFilles.TabIndex = 13;
            // 
            // lblGarcons
            // 
            this.lblGarcons.AutoSize = true;
            this.lblGarcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarcons.Location = new System.Drawing.Point(124, 218);
            this.lblGarcons.Name = "lblGarcons";
            this.lblGarcons.Size = new System.Drawing.Size(0, 20);
            this.lblGarcons.TabIndex = 14;
            // 
            // lblDdn
            // 
            this.lblDdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDdn.Location = new System.Drawing.Point(43, 325);
            this.lblDdn.Name = "lblDdn";
            this.lblDdn.Size = new System.Drawing.Size(251, 80);
            this.lblDdn.TabIndex = 25;
            this.lblDdn.Text = "Nombre d\'adhérents par année de naissance :";
            // 
            // lblEvenements
            // 
            this.lblEvenements.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenements.Location = new System.Drawing.Point(449, 73);
            this.lblEvenements.Name = "lblEvenements";
            this.lblEvenements.Size = new System.Drawing.Size(249, 80);
            this.lblEvenements.TabIndex = 26;
            this.lblEvenements.Text = "Nombre d\'adhérents pour chaque évenements :";
            // 
            // lblAdherents
            // 
            this.lblAdherents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherents.Location = new System.Drawing.Point(449, 348);
            this.lblAdherents.Name = "lblAdherents";
            this.lblAdherents.Size = new System.Drawing.Size(249, 59);
            this.lblAdherents.TabIndex = 27;
            this.lblAdherents.Text = "Nombre d\'évenements par adhérent :";
            // 
            // FormStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 593);
            this.Controls.Add(this.lblAdherents);
            this.Controls.Add(this.lblEvenements);
            this.Controls.Add(this.lblDdn);
            this.Controls.Add(this.lblGarcons);
            this.Controls.Add(this.lblFilles);
            this.Controls.Add(this.lblNombreAdherents);
            this.Controls.Add(this.dtgAdherents);
            this.Controls.Add(this.dtgEvenements);
            this.Controls.Add(this.dtgDdn);
            this.Controls.Add(this.lblNbGarcons);
            this.Controls.Add(this.lblNbFilles);
            this.Controls.Add(this.lblNbAdherents);
            this.Controls.Add(this.lblTitreStatistiques);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormStatistiques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.FormStatistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEvenements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAdherents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreStatistiques;
        private System.Windows.Forms.Label lblNbAdherents;
        private System.Windows.Forms.Label lblNbFilles;
        private System.Windows.Forms.Label lblNbGarcons;
        private System.Windows.Forms.DataGridView dtgDdn;
        private System.Windows.Forms.DataGridView dtgEvenements;
        private System.Windows.Forms.DataGridView dtgAdherents;
        private System.Windows.Forms.Label lblNombreAdherents;
        private System.Windows.Forms.Label lblFilles;
        private System.Windows.Forms.Label lblGarcons;
        private System.Windows.Forms.Label lblDdn;
        private System.Windows.Forms.Label lblEvenements;
        private System.Windows.Forms.Label lblAdherents;
    }
}