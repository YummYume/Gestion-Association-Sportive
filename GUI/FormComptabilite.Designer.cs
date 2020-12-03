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
            this.labelTitreCompta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitreCompta
            // 
            this.labelTitreCompta.AutoSize = true;
            this.labelTitreCompta.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreCompta.Location = new System.Drawing.Point(224, 100);
            this.labelTitreCompta.Name = "labelTitreCompta";
            this.labelTitreCompta.Size = new System.Drawing.Size(278, 64);
            this.labelTitreCompta.TabIndex = 0;
            this.labelTitreCompta.Text = "1 + 1 = 11";
            // 
            // FormComptabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitreCompta);
            this.Name = "FormComptabilite";
            this.Text = "FormComptabilite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitreCompta;
    }
}