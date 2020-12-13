using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChoixAcces : Form
    {
        public FormChoixAcces()
        {
            InitializeComponent();
        }

        private void btnAccesAdmin_Click(object sender, EventArgs e)
        {
            FormAdministrateur newAdmin;
            this.Hide();
            newAdmin = new FormAdministrateur();
            newAdmin.ShowDialog();
            this.Show();
        }

        private void btnAccesCompta_Click(object sender, EventArgs e)
        {
            FormComptabilite newCompta;
            this.Hide();
            newCompta = new FormComptabilite();
            newCompta.ShowDialog();
            this.Show();
        }
    }
}
