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

        private void buttonAccesAdmin_Click(object sender, EventArgs e)
        {
            FormAdministrateur newAdmin;
            newAdmin = new FormAdministrateur();
            newAdmin.Show();
        }

        private void buttonAccesCompta_Click(object sender, EventArgs e)
        {
            FormComptabilite newCompta;
            newCompta = new FormComptabilite();
            newCompta.Show();
        }
    }
}
