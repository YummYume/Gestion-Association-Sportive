using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BO;

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
            // TODO: cette ligne de code charge les données dans la table 'PPE.ADHERENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.dtgListeAdherants.DataSource = AdherentBLL.GetInfoBaseAdherents();
            if(this.dtgListeAdherants.Rows.Count > 0)
            {
                this.dtgListeAdherants.Rows[0].Selected = false;
            }
        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerEleve_Click(object sender, EventArgs e)
        {
            if (this.dtgListeAdherants.SelectedRows.Count > 0)
            {
                AdherentBLL.RemoveAdherent((AdherentMin)this.dtgListeAdherants.SelectedRows[0].DataBoundItem);
                this.FormAdministrateur_Load(this, new EventArgs());
            }
        }

        private void btnModifierEleve_Click(object sender, EventArgs e)
        {

        }

        private void dtgListeAdherants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtgListeAdherants.SelectedCells.Count > 0)
            {
                this.dtgListeAdherants.SelectedCells[0].OwningRow.Selected = true;
            }
            //TODO Afficher les infos complètes dans la barre latérale
        }
    }
}
