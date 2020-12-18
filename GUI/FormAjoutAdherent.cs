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
    public partial class FormAjoutAdherent : Form
    {
        public FormAjoutAdherent()
        {
            InitializeComponent();
        }

        virtual protected void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajout effectué (c'est faux)");
        }

        private void FormAdherent_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Classe uneClasse in ClasseBLL.GetClasses())
                {
                    this.lsbClasse.Items.Add(uneClasse.Libelle);
                }
            }
            catch (Exception)
            {
                //Fix pour le designer je ne comprend pas pourquoi il fait la gueule
            }
        }

        private void btnValider_Click_1(object sender, EventArgs e)
        {
            // TODO : Référencer une classe existante depuis une liste & ajouter l'admin qui utilise actuellement l'application
            Utilisateur unUtilisateur = new Utilisateur(1, "Lythis", "admin", "admin");
            Classe uneClasse = new Classe(1, lsbClasse.GetItemText(lsbClasse.SelectedItem));
            Adherent unAdherent = new Adherent(tbxNom.Text, tbxPrenom.Text, dtpDn.Value, lsbSexe.GetItemText(lsbSexe.SelectedItem), tbxLogin.Text, tbxMdp.Text, tbxNumTel.Text, tbxEmail.Text, tbxNumTelParent.Text, unUtilisateur, uneClasse);

            try
            {
                AdherentBLL.AddAdherent(unAdherent);
                
                ActiveForm.Close();
            }
            catch(Exception erreur)
            {
                lblErreur.ForeColor = Color.Red;
                lblErreur.Text = "Erreur : " + erreur;
            }
        }
    }
}
