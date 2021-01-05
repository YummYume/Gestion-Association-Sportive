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
using BLL;

namespace GUI
{
    public partial class FormModificationAdherent : Form
    {
        private Utilisateur leUtilisateur;
        private Adherent leAdherent;
        private FormAdministrateur formAdmin;

        public FormModificationAdherent(Utilisateur unUtilisateur, Adherent unAdherent, Form leFormAdmin)
        {
            leUtilisateur = unUtilisateur;
            leAdherent = unAdherent;
            formAdmin = leFormAdmin as FormAdministrateur;
            InitializeComponent();
            tbxNom.Text = leAdherent.Nom;
            tbxPrenom.Text = leAdherent.Prenom;
            lsbSexe.SelectedItem = leAdherent.Sexe;
            dtpDn.Value = leAdherent.DateDeNaissance;
            tbxNumTel.Text = leAdherent.NumTel;
            tbxEmail.Text = leAdherent.Email;
            tbxLogin.Text = leAdherent.Login;
            tbxMdp.Text = leAdherent.MotDePasse;
            cbxAfficherMdp.Checked = true;
            tbxNumTelParent.Text = leAdherent.NumTelParent;
        }

        virtual protected void btnValider_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            bool finRecherche = false;
            Timer t = new Timer();
            List<TextBox> lesTextBox = new List<TextBox>();
            List<ListBox> lesListBox = new List<ListBox>();
            List<DataGridView> dgvAdmin = new List<DataGridView>();
            List<Label> lesLabels = new List<Label>();

            foreach (Control unGridView in formAdmin.Controls)
            {
                if (unGridView is DataGridView)
                {
                    dgvAdmin.Add((DataGridView)unGridView);
                }
            }
            foreach (Control leControle in this.Controls)
            {
                if (leControle is TextBox)
                {
                    lesTextBox.Add((TextBox)leControle);
                }

                if (leControle is ListBox)
                {
                    lesListBox.Add((ListBox)leControle);
                }

                if (leControle is Label)
                {
                    lesLabels.Add((Label)leControle);
                }
            }

            while (erreur == false && finRecherche == false)
            {
                string modifie = "";
                int nbLabels = 0;

                while (modifie != "Modifié" && nbLabels != lesLabels.Count())
                {
                    modifie = lesLabels[nbLabels].Text;
                    if (modifie != "Modifié")
                    {
                        nbLabels += 1;
                    }
                }

                if (modifie != "Modifié")
                {
                    erreur = true;
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Aucune modification détectée.";
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        t.Stop();
                    };
                    t.Start();
                }

                foreach (TextBox tb in lesTextBox)
                {
                    if (tb.Text == "" && erreur == false)
                    {
                        erreur = true;
                        tb.Focus();
                        tb.BackColor = Color.Red;
                        lblErreur.ForeColor = Color.Red;
                        lblErreur.Text = "Veuillez remplir tous les champs.";
                        t.Interval = 5000; // 5 secondes
                        t.Tick += (s, error) =>
                        {
                            this.lblErreur.Text = "";
                            tb.BackColor = Color.White;
                            t.Stop();
                        };
                        t.Start();
                    }
                }
                foreach (ListBox lb in lesListBox)
                {
                    if (lb.SelectedIndex == -1 && erreur == false)
                    {
                        erreur = true;
                        lb.Focus();
                        lb.BackColor = Color.Red;
                        lblErreur.ForeColor = Color.Red;
                        lblErreur.Text = "Veuillez sélectionner une option.";
                        t.Interval = 5000; // 5 secondes
                        t.Tick += (s, error) =>
                        {
                            this.lblErreur.Text = "";
                            lb.BackColor = Color.White;
                            t.Stop();
                        };
                        t.Start();
                    }
                }
                if (dtpDn.Value > DateTime.Now && erreur == false)
                {
                    erreur = true;
                    dtpDn.Focus();
                    dtpDn.BackColor = Color.Red;
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Veuillez sélectionner une date valide.";
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        dtpDn.BackColor = Color.White;
                        t.Stop();
                    };
                    t.Start();
                }
                if (!tbxEmail.Text.Contains("@") && erreur == false)
                {
                    erreur = true;
                    tbxEmail.Focus();
                    tbxEmail.BackColor = Color.Red;
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Veuillez rentrer un email valide.";
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        tbxEmail.BackColor = Color.White;
                        t.Stop();
                    };
                    t.Start();
                }
                if (tbxNumTel.Text.Length != 10 && erreur == false)
                {
                    erreur = true;
                    tbxNumTel.Focus();
                    tbxNumTel.BackColor = Color.Red;
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Veuillez rentrer un numéro valide à 10 chiffres.";
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        tbxNumTel.BackColor = Color.White;
                        t.Stop();
                    };
                    t.Start();
                }
                if (tbxNumTelParent.Text.Length != 10 && erreur == false)
                {
                    erreur = true;
                    tbxNumTelParent.Focus();
                    tbxNumTelParent.BackColor = Color.Red;
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Veuillez rentrer un numéro valide à 10 chiffres.";
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        tbxNumTelParent.BackColor = Color.White;
                        t.Stop();
                    };
                    t.Start();
                }

                finRecherche = true;
            }

            if (erreur == false)
            {
                int idClasse = 1;
                foreach (Classe laClasse in ClasseBLL.GetClasses())
                {
                    if (laClasse.Libelle == lsbClasse.GetItemText(lsbClasse.SelectedItem))
                    {
                        idClasse = laClasse.Id;
                    }
                }
                Classe uneClasse = new Classe(idClasse, lsbClasse.GetItemText(lsbClasse.SelectedItem));
                Adherent unAdherent = new Adherent(tbxNom.Text.Trim(), tbxPrenom.Text.Trim(), dtpDn.Value, lsbSexe.GetItemText(lsbSexe.SelectedItem), tbxLogin.Text, tbxMdp.Text, tbxNumTel.Text, tbxEmail.Text, tbxNumTelParent.Text, leUtilisateur, uneClasse);
                unAdherent.Id = leAdherent.Id;

                try
                {
                    AdherentBLL.ModifierAdherent(unAdherent);

                    // Refresh du dgv & Reposition du curseur
                    int currentRow = dgvAdmin[0].CurrentRow.Index;
                    dgvAdmin[0].DataSource = AdherentBLL.GetInfoBaseAdherents();
                    dgvAdmin[0].Rows[currentRow].Selected = true;
                    dgvAdmin[0].CurrentCell = dgvAdmin[0][0, currentRow];

                    lblErreur.ForeColor = Color.Green;
                    if (unAdherent.Sexe == "Femme")
                    {
                        lblErreur.Text = "Adhérente " + unAdherent.Nom + " " + unAdherent.Prenom + " modifiée avec succès!";
                    }
                    else
                    {
                        lblErreur.Text = "Adhérent " + unAdherent.Nom + " " + unAdherent.Prenom + " modifié avec succès!";
                    }
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        t.Stop();
                    };
                    t.Start();

                    leAdherent = unAdherent;
                    foreach (Label unLabel in lesLabels)
                    {
                        if (unLabel.Text == "Modifié")
                        {
                            unLabel.Text = "";
                        }
                    }
                }
                catch (Exception)
                {
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Erreur lors de l'exécution";
                }
            }
        }

        private void FormModificationAdherent_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Classe uneClasse in ClasseBLL.GetClasses())
                {
                    this.lsbClasse.Items.Add(uneClasse.Libelle);
                }
                lsbClasse.SelectedItem = leAdherent.Classe.Libelle;
            }
            catch (Exception)
            {
                //Fix pour le designer je ne comprend pas pourquoi il fait la gueule
            }
        }

        private void cbxAfficherMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAfficherMdp.Checked == true)
            {
                tbxMdp.PasswordChar = '●';
            }
            else
            {
                tbxMdp.PasswordChar = '\0';
            }
        }

        private void tbxNumTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbxMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbxNumTelParent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tbxNumTel_TextChanged(object sender, EventArgs e)
        {
            if (tbxNumTel.Text.Contains(" "))
            {
                tbxNumTel.Text.Replace(" ", "");
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxNumTel.Text, "[^0-9]"))
            {
                tbxNumTel.Text = System.Text.RegularExpressions.Regex.Replace(tbxNumTel.Text, "[^0-9.]", "");
            }

            if (leAdherent.NumTel != tbxNumTel.Text.Trim())
            {
                lblNumModif.Text = "Modifié";
                lblNumModif.ForeColor = Color.Red;
            }
            else
            {
                lblNumModif.Text = "";
            }
        }

        private void tbxNumTelParent_TextChanged(object sender, EventArgs e)
        {
            if (tbxNumTelParent.Text.Contains(" "))
            {
                tbxNumTelParent.Text.Replace(" ", "");
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxNumTelParent.Text, "[^0-9]"))
            {
                tbxNumTelParent.Text = System.Text.RegularExpressions.Regex.Replace(tbxNumTelParent.Text, "[^0-9.]", "");
            }

            if (leAdherent.NumTelParent != tbxNumTelParent.Text.Trim())
            {
                lblNumParentModif.Text = "Modifié";
                lblNumParentModif.ForeColor = Color.Red;
            }
            else
            {
                lblNumParentModif.Text = "";
            }
        }

        private void tbxLogin_TextChanged(object sender, EventArgs e)
        {
            if (tbxLogin.Text.Contains(" "))
            {
                tbxLogin.Text.Replace(" ", "");
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxLogin.Text, "[ ]"))
            {
                tbxLogin.Text = System.Text.RegularExpressions.Regex.Replace(tbxLogin.Text, "[ ]", "");
            }

            if (leAdherent.Login != tbxLogin.Text.Trim())
            {
                lblLoginModif.Text = "Modifié";
                lblLoginModif.ForeColor = Color.Red;
            }
            else
            {
                lblLoginModif.Text = "";
            }

            if (AdherentBLL.LoginExiste(tbxLogin.Text.Trim()) && tbxLogin.Text.Trim() != leAdherent.Login)
            {
                btnValider.Enabled = false;
                tbxLogin.BackColor = Color.Red;
                lblErreur.ForeColor = Color.Red;
                lblErreur.Text = "Le login '" + tbxLogin.Text + "' existe déjà!";
            }
            else
            {
                btnValider.Enabled = true;
                tbxLogin.BackColor = Color.White;
                lblErreur.Text = "";
            }
        }

        private void tbxMdp_TextChanged(object sender, EventArgs e)
        {
            if (tbxMdp.Text.Contains(" "))
            {
                tbxMdp.Text.Replace(" ", "");
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxMdp.Text, "[ ]"))
            {
                tbxMdp.Text = System.Text.RegularExpressions.Regex.Replace(tbxMdp.Text, "[ ]", "");
            }

            if (leAdherent.MotDePasse != tbxMdp.Text.Trim())
            {
                lblMdpModif.Text = "Modifié";
                lblMdpModif.ForeColor = Color.Red;
            }
            else
            {
                lblMdpModif.Text = "";
            }
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbxEmail.Text.Contains(" "))
            {
                tbxEmail.Text.Replace(" ", "");
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(tbxEmail.Text, "[ ]"))
            {
                tbxEmail.Text = System.Text.RegularExpressions.Regex.Replace(tbxEmail.Text, "[ ]", "");
            }

            if (leAdherent.Email != tbxEmail.Text.Trim())
            {
                lblEmailModif.Text = "Modifié";
                lblEmailModif.ForeColor = Color.Red;
            }
            else
            {
                lblEmailModif.Text = "";
            }
        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {
            AdherentMin unAdherent = new AdherentMin(tbxNom.Text.Trim(), tbxPrenom.Text.Trim());

            if (AdherentBLL.AdherentExiste(unAdherent) && leAdherent.Nom != unAdherent.Nom && leAdherent.Prenom != unAdherent.Prenom)
            {
                btnValider.Enabled = false;
                tbxNom.BackColor = Color.Red;
                tbxPrenom.BackColor = Color.Red;
                lblErreur.ForeColor = Color.Red;
                lblErreur.Text = "Adhérent(e) déjà éxistant(e)!";
            }
            else
            {
                btnValider.Enabled = true;
                tbxNom.BackColor = Color.White;
                tbxPrenom.BackColor = Color.White;
                lblErreur.Text = "";
            }

            if (leAdherent.Nom != tbxNom.Text.Trim())
            {
                lblNomModif.Text = "Modifié";
                lblNomModif.ForeColor = Color.Red;
            }
            else
            {
                lblNomModif.Text = "";
            }
        }

        private void tbxPrenom_TextChanged(object sender, EventArgs e)
        {
            AdherentMin unAdherent = new AdherentMin(tbxNom.Text.Trim(), tbxPrenom.Text.Trim());

            if (AdherentBLL.AdherentExiste(unAdherent) && leAdherent.Nom != unAdherent.Nom && leAdherent.Prenom != unAdherent.Prenom)
            {
                btnValider.Enabled = false;
                tbxNom.BackColor = Color.Red;
                tbxPrenom.BackColor = Color.Red;
                lblErreur.ForeColor = Color.Red;
                lblErreur.Text = "Adhérent(e) déjà éxistant(e)!";
            }
            else
            {
                btnValider.Enabled = true;
                tbxNom.BackColor = Color.White;
                tbxPrenom.BackColor = Color.White;
                lblErreur.Text = "";
            }

            if (leAdherent.Prenom != tbxPrenom.Text.Trim())
            {
                lblPrenomModif.Text = "Modifié";
                lblPrenomModif.ForeColor = Color.Red;
            }
            else
            {
                lblPrenomModif.Text = "";
            }
        }

        private void dtpDn_ValueChanged(object sender, EventArgs e)
        {
            if (leAdherent.DateDeNaissance != dtpDn.Value)
            {
                lblDdnModif.Text = "Modifié";
                lblDdnModif.ForeColor = Color.Red;
            }
            else
            {
                lblDdnModif.Text = "";
            }
        }

        private void lsbSexe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbSexe.SelectedIndex != -1 && leAdherent.Sexe != lsbSexe.SelectedItem.ToString())
            {
                lblGenreModif.Text = "Modifié";
                lblGenreModif.ForeColor = Color.Red;
            }
            else
            {
                lblGenreModif.Text = "";
            }
        }

        private void lsbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbClasse.SelectedIndex != -1 && leAdherent.Classe.Libelle != lsbClasse.SelectedItem.ToString())
            {
                lblClasseModif.Text = "Modifié";
                lblClasseModif.ForeColor = Color.Red;
            }
            else
            {
                lblClasseModif.Text = "";
            }
        }
    }
}
