using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;

namespace GUI
{
    public partial class FormChoixAcces : Form
    {
        private Utilisateur unUtilisateur;

        public FormChoixAcces(Utilisateur unUtilisateur)
        {
            this.unUtilisateur = unUtilisateur;
            InitializeComponent();
        }

        private void btnAccesAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdministrateur newAdmin = new FormAdministrateur(unUtilisateur);
            newAdmin.ShowDialog();
            this.Show();
        }

        private void btnAccesCompta_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormComptabilite newCompta = new FormComptabilite(unUtilisateur);
            newCompta.ShowDialog();
            this.Show();
        }
    }
}
