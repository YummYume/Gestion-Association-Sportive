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
using DAL;
using BO;
using BLL;

namespace GUI
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
            UtilisateurBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string mdp = textBoxMdp.Text;
            string msgErreur = "Erreur :";
            bool erreur = false;

            // Vérifier si le compte existe // le mot de passe correspond
            if (!UtilisateurDAO.UtilisateurExiste(login))
            {
                msgErreur += "\nUtilisateur inconnu";
                erreur = true;
            }
            else
            {
                if (!UtilisateurDAO.VerifierMotDePasse(login, mdp))
                {
                    msgErreur += "\nMot de passe invalide";
                    erreur = true;
                }
            }

            if (erreur == true)
            {
                labelConnectionFailed.Text = msgErreur;
                labelConnectionFailed.ForeColor = Color.Red;
            }
            else
            {
                labelConnectionFailed.Text = "Connexion Réussie!\nBienvenue, " + textBoxLogin.Text + ".";
                labelConnectionFailed.ForeColor = Color.Green;
                string droitUtilisateur = UtilisateurDAO.GetDroit(login);
                switch (droitUtilisateur)
                {
                    case "admin":
                        FormChoixAcces newAcces;
                        newAcces = new FormChoixAcces();
                        newAcces.Show();
                        break;
                    case "compta":
                        FormComptabilite newCompta;
                        newCompta = new FormComptabilite();
                        newCompta.Show();
                        break;
                    default:
                        labelProblemeDroit.ForeColor = Color.Red;
                        labelProblemeDroit.Text += "\nProblème d'accès.";
                        var t = new Timer();
                        t.Interval = 3000; // 3 secondes
                        t.Tick += (s, error) =>
                        {
                            labelProblemeDroit.Text = "";
                            t.Stop();
                        };
                        t.Start();
                        break;
                }
            }
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBoxMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
