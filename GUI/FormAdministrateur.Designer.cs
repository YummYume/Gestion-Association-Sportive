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
            this.labelTitreAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitreAdmin
            // 
            this.labelTitreAdmin.AutoSize = true;
            this.labelTitreAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreAdmin.Location = new System.Drawing.Point(218, 87);
            this.labelTitreAdmin.Name = "labelTitreAdmin";
            this.labelTitreAdmin.Size = new System.Drawing.Size(393, 64);
            this.labelTitreAdmin.TabIndex = 0;
            this.labelTitreAdmin.Text = "Administrateur";
            // 
            // FormAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitreAdmin);
            this.Name = "FormAdministrateur";
            this.Text = "Administrateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitreAdmin;
    }
}