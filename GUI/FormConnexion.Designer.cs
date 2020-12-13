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
            this.lblConnexionMessage = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblProblemeDroit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConnexionMessage
            // 
            this.lblConnexionMessage.Location = new System.Drawing.Point(16, 313);
            this.lblConnexionMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnexionMessage.Name = "lblConnexionMessage";
            this.lblConnexionMessage.Size = new System.Drawing.Size(857, 53);
            this.lblConnexionMessage.TabIndex = 13;
            this.lblConnexionMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(349, 198);
            this.lblMdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(101, 17);
            this.lblMdp.TabIndex = 12;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(349, 130);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 17);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "Login :";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(349, 273);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(189, 28);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(349, 153);
            this.tbxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(188, 22);
            this.tbxLogin.TabIndex = 1;
            this.tbxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLogin_KeyPress);
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(349, 218);
            this.tbxMdp.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.PasswordChar = '*';
            this.tbxMdp.Size = new System.Drawing.Size(188, 22);
            this.tbxMdp.TabIndex = 2;
            this.tbxMdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxMdp_KeyPress);
            // 
            // lblConnexion
            // 
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(37, 31);
            this.lblConnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(815, 85);
            this.lblConnexion.TabIndex = 7;
            this.lblConnexion.Text = "Connexion";
            this.lblConnexion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProblemeDroit
            // 
            this.lblProblemeDroit.Location = new System.Drawing.Point(16, 374);
            this.lblProblemeDroit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProblemeDroit.Name = "lblProblemeDroit";
            this.lblProblemeDroit.Size = new System.Drawing.Size(857, 32);
            this.lblProblemeDroit.TabIndex = 14;
            this.lblProblemeDroit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.btnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 411);
            this.Controls.Add(this.lblProblemeDroit);
            this.Controls.Add(this.lblConnexionMessage);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.lblConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexionMessage;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Label lblProblemeDroit;
    }
}

