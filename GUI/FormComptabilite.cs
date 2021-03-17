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
    public partial class FormComptabilite : Form
    {
        private Utilisateur leUtilisateur;

        public FormComptabilite(Utilisateur unUtilisateur)
        {
            leUtilisateur = unUtilisateur;
            InitializeComponent();
        }

        private void FormComptabilite_Load(object sender, EventArgs e)
        {

        }
    }
}
