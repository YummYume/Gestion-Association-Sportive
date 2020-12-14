using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BO;
using BLL;

namespace GUI
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
            UtilisateurBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["VM"]);
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            string msgErreur = UtilisateurBLL.VerificationConnexion(this.tbxLogin.Text, this.tbxMdp.Text);
            Timer t = new Timer();

            if (msgErreur != "")
            {
                this.lblConnexionMessage.Text = msgErreur;
                this.lblConnexionMessage.ForeColor = Color.Red;
                t.Interval = 3000; // 3 secondes
                t.Tick += (s, error) =>
                {
                    this.lblConnexionMessage.Text = "";
                    t.Stop();
                };
                t.Start();
            }
            else
            {
                this.tbxMdp.Clear();
                this.lblConnexionMessage.Text = "Connexion Réussie!\nBienvenue, " + this.tbxLogin.Text + ".";
                this.lblConnexionMessage.ForeColor = Color.Green;
                t.Interval = 3000; // 3 secondes
                t.Tick += (s, error) =>
                {
                    this.lblConnexionMessage.Text = "";
                    t.Stop();
                };
                t.Start();
                string droitUtilisateur = UtilisateurBLL.GetDroit(this.tbxLogin.Text);

                switch (droitUtilisateur)
                {
                    case "admin":
                        FormChoixAcces newAcces;
                        this.Hide();
                        newAcces = new FormChoixAcces();
                        newAcces.ShowDialog();
                        this.Show();
                        break;
                    case "compta":
                        FormComptabilite newCompta;
                        this.Hide();
                        newCompta = new FormComptabilite();
                        newCompta.ShowDialog();
                        this.Show();
                        break;
                    default:
                        Timer tAccesRefuse = new Timer();
                        this.lblProblemeDroit.ForeColor = Color.Red;
                        this.lblProblemeDroit.Text += "\nAccès refusé.";
                        tAccesRefuse.Interval = 3000; // 3 secondes
                        tAccesRefuse.Tick += (s, error) =>
                        {
                            this.lblProblemeDroit.Text = "";
                            tAccesRefuse.Stop();
                        };
                        tAccesRefuse.Start();
                        break;
                }
            }
        }

        private void tbxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbxMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
