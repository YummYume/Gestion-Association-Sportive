namespace GUI
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelConnectionFailed = new System.Windows.Forms.Label();
            this.labelMdp = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.labelConnexion = new System.Windows.Forms.Label();
            this.labelProblemeDroit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelConnectionFailed
            // 
            this.labelConnectionFailed.Location = new System.Drawing.Point(12, 254);
            this.labelConnectionFailed.Name = "labelConnectionFailed";
            this.labelConnectionFailed.Size = new System.Drawing.Size(643, 43);
            this.labelConnectionFailed.TabIndex = 13;
            this.labelConnectionFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(262, 161);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(77, 13);
            this.labelMdp.TabIndex = 12;
            this.labelMdp.Text = "Mot de passe :";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(262, 106);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(39, 13);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "Login :";
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(262, 222);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(142, 23);
            this.buttonConnection.TabIndex = 3;
            this.buttonConnection.Text = "Connection";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(262, 124);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(142, 20);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(262, 177);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.PasswordChar = '*';
            this.textBoxMdp.Size = new System.Drawing.Size(142, 20);
            this.textBoxMdp.TabIndex = 2;
            this.textBoxMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMdp_KeyPress);
            // 
            // labelConnexion
            // 
            this.labelConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.Location = new System.Drawing.Point(28, 25);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(611, 69);
            this.labelConnexion.TabIndex = 7;
            this.labelConnexion.Text = "Connexion";
            this.labelConnexion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelProblemeDroit
            // 
            this.labelProblemeDroit.Location = new System.Drawing.Point(12, 304);
            this.labelProblemeDroit.Name = "labelProblemeDroit";
            this.labelProblemeDroit.Size = new System.Drawing.Size(643, 26);
            this.labelProblemeDroit.TabIndex = 14;
            this.labelProblemeDroit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.buttonConnection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 334);
            this.Controls.Add(this.labelProblemeDroit);
            this.Controls.Add(this.labelConnectionFailed);
            this.Controls.Add(this.labelMdp);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.labelConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConnectionFailed;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Label labelProblemeDroit;
    }
}

