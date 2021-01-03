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
        private Utilisateur leUtilisateur;

        public FormAdministrateur(Utilisateur unUtilisateur)
        {
            leUtilisateur = unUtilisateur;
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

            lblLoginAdministrateur.Text = leUtilisateur.Login;
        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {
            FormAjoutAdherent newAjoutAdherent;
            newAjoutAdherent = new FormAjoutAdherent(leUtilisateur, this);
            newAjoutAdherent.ShowDialog();
        }

        private void btnSupprimerEleve_Click(object sender, EventArgs e)
        {
            if (this.dtgListeAdherants.SelectedRows.Count > 0)
            {
                string nom = dtgListeAdherants.CurrentRow.Cells[0].Value.ToString();
                string prenom = dtgListeAdherants.CurrentRow.Cells[1].Value.ToString();
                DialogResult reponseMsgBox;

                reponseMsgBox = MessageBox.Show("Voulez vous vraiment supprimer l'adhérent " + nom + " " + prenom + "?", "Suppression d'un adhérent", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (reponseMsgBox == DialogResult.Yes)
                {
                    AdherentBLL.RemoveAdherent((AdherentMin)this.dtgListeAdherants.SelectedRows[0].DataBoundItem);
                    this.FormAdministrateur_Load(this, new EventArgs());
                }
            }
        }

        private void btnModifierEleve_Click(object sender, EventArgs e)
        {
            List<Adherent> lesAdherents = new List<Adherent>(AdherentBLL.GetFullInfoAdherents());
            string nom = dtgListeAdherants.CurrentRow.Cells[0].Value.ToString();
            string prenom = dtgListeAdherants.CurrentRow.Cells[1].Value.ToString();

            Adherent leAdherent = lesAdherents.Find(Adherent => Adherent.Nom == nom && Adherent.Prenom == prenom);

            FormModificationAdherent newModificationAdherent;
            newModificationAdherent = new FormModificationAdherent(leUtilisateur, leAdherent, this);
            newModificationAdherent.ShowDialog();
        }

        private void dtgListeAdherants_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtgListeAdherants.SelectedCells.Count > 0)
            {
                this.dtgListeAdherants.SelectedCells[0].OwningRow.Selected = true;
            }
            List<Adherent> lesAdherents = new List<Adherent>(AdherentBLL.GetFullInfoAdherents());
            string nom = dtgListeAdherants.CurrentRow.Cells[0].Value.ToString();
            string prenom = dtgListeAdherants.CurrentRow.Cells[1].Value.ToString();

            Adherent leAdherent = lesAdherents.Find(Adherent => Adherent.Nom == nom && Adherent.Prenom == prenom);
            lblNom.Text = leAdherent.Nom;
            lblPrenom.Text = leAdherent.Prenom;
            lblClasse.Text = leAdherent.Classe.Libelle;
            lblTel.Text = leAdherent.NumTel;
            lblTelParent.Text = leAdherent.NumTelParent;
            lblMail.Text = leAdherent.Email;
            lblDateNaissance.Text = leAdherent.DateDeNaissance.GetDateTimeFormats('d')[0];
        }
    }
}
