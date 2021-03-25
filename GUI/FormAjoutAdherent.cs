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
        private Utilisateur leUtilisateur;
        private FormAdministrateur formAdmin;

        public FormAjoutAdherent(Utilisateur unUtilisateur, Form leFormAdmin)
        {
            formAdmin = leFormAdmin as FormAdministrateur;
            leUtilisateur = unUtilisateur;
            InitializeComponent();
        }

        virtual protected void btnValider_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            bool finRecherche = false;
            Timer t = new Timer();
            List<TextBox> lesTextBox = new List<TextBox>();
            List<ListBox> lesListBox = new List<ListBox>();
            List<DataGridView> dgvAdmin = new List<DataGridView>();

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
            }

            while (erreur == false && finRecherche == false)
            {
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
                Adherent unAdherent = new Adherent(tbxNom.Text.Trim(), tbxPrenom.Text.Trim(), dtpDn.Value, lsbSexe.GetItemText(lsbSexe.SelectedItem), tbxLogin.Text, tbxMdp.Text, tbxNumTel.Text, tbxEmail.Text, tbxNumTelParent.Text, leUtilisateur, new Classe(Int32.Parse(lsbClasse.SelectedValue.ToString())));

                try
                {
                    AdherentBLL.AddAdherent(unAdherent);
                    dgvAdmin[0].DataSource = AdherentBLL.GetInfoBaseAdherents();
                    lblErreur.ForeColor = Color.Green;
                    if (unAdherent.Sexe == "Femme")
                    {
                        lblErreur.Text = "Adhérente " + unAdherent.Nom + " " + unAdherent.Prenom + " ajoutée avec succès!";
                    }
                    else
                    {
                        lblErreur.Text = "Adhérent " + unAdherent.Nom + " " + unAdherent.Prenom + " ajouté avec succès!";
                    }
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        t.Stop();
                    };
                    t.Start();
                    foreach (TextBox tb in lesTextBox)
                    {
                        tb.Text = "";
                    }
                    foreach (ListBox lb in lesListBox)
                    {
                        lb.SelectedIndex = -1;
                    }
                }
                catch (Exception)
                {
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Erreur lors de l'exécution.";
                }
            }
        }

        private void FormAdherent_Load(object sender, EventArgs e)
        {
            try
            {
                this.lsbClasse.ValueMember = "id";
                this.lsbClasse.DisplayMember = "libelle";
                this.lsbClasse.DataSource = ClasseBLL.GetClasses();
            }
            catch (Exception)
            {
                
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

            if (AdherentBLL.LoginExiste(tbxLogin.Text))
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
        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {
            AdherentMin unAdherent = new AdherentMin(tbxNom.Text.Trim(), tbxPrenom.Text.Trim());

            if (AdherentBLL.AdherentExiste(unAdherent))
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
        }

        private void tbxPrenom_TextChanged(object sender, EventArgs e)
        {
            AdherentMin unAdherent = new AdherentMin(tbxNom.Text.Trim(), tbxPrenom.Text.Trim());

            if (AdherentBLL.AdherentExiste(unAdherent))
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
        }
    }
}
