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
    public partial class FormModificationAdherent : FormAjoutAdherent
    {
        private Adherent adherentNonModif;
        private Adherent adherentModif;

        public FormModificationAdherent(Adherent unAdherent, FormAdministrateur leFormAdmin) :base(leFormAdmin)
        {
            InitializeComponent();
            this.btnValider.Text = "Modifier";
            this.adherentNonModif = unAdherent;
            this.adherentModif = unAdherent.Clone();
            this.tbxNom.Text = unAdherent.Nom;
            this.tbxPrenom.Text = unAdherent.Prenom;
            this.dtpDn.Value = unAdherent.DateDeNaissance;
            this.lsbSexe.SelectedIndex = this.lsbSexe.Items.Cast<string>().ToList().FindIndex(sexe => sexe == unAdherent.Sexe);
            this.tbxNumTel.Text = unAdherent.NumTel.ToString();
            this.tbxEmail.Text = unAdherent.Email;
            this.tbxNumTelParent.Text = unAdherent.NumTelParent.ToString();
            this.lsbClasse.SelectedIndex = this.lsbClasse.Items.Cast<string>().ToList().FindIndex(classe => classe == unAdherent.Classe.Libelle);
        }

        override protected void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modif effectuée (c'est faux)");
            this.Close();
        }
    }
}
