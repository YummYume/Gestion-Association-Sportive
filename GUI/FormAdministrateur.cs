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
    public partial class FormAdministrateur : Form
    {
        public FormAdministrateur()
        {
            InitializeComponent();
        }

        private void FormAdministrateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'pPEDataSet.ADHERENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.aDHERENTTableAdapter.Fill(this.pPEDataSet.ADHERENT);

        }
    }
}
