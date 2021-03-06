﻿using System;
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
        private Utilisateur leUtilisateur;

        public FormChoixAcces(Utilisateur unUtilisateur)
        {
            leUtilisateur = unUtilisateur;
            InitializeComponent();
        }

        private void btnAccesAdmin_Click(object sender, EventArgs e)
        {
            FormAdministrateur newAdmin;
            this.Hide();
            newAdmin = new FormAdministrateur(leUtilisateur);
            newAdmin.ShowDialog();
            this.Show();
        }

        private void btnAccesCompta_Click(object sender, EventArgs e)
        {
            FormComptabilite newCompta;
            this.Hide();
            newCompta = new FormComptabilite(leUtilisateur);
            newCompta.ShowDialog();
            this.Show();
        }
    }
}
