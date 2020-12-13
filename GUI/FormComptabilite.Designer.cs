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
            this.lblTitreCompta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitreCompta
            // 
            this.lblTitreCompta.AutoSize = true;
            this.lblTitreCompta.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreCompta.Location = new System.Drawing.Point(299, 123);
            this.lblTitreCompta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreCompta.Name = "lblTitreCompta";
            this.lblTitreCompta.Size = new System.Drawing.Size(346, 80);
            this.lblTitreCompta.TabIndex = 0;
            this.lblTitreCompta.Text = "1 + 1 = 11";
            // 
            // FormComptabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTitreCompta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComptabilite";
            this.Text = "FormComptabilite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreCompta;
    }
}