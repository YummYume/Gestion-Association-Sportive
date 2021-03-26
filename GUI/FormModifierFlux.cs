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
    public partial class FormModifierFlux : Form
    {
        private Utilisateur leUtilisateur;
        private FormComptabilite formCompta;
        private Budget budgetAS;
        private Budget budgetEPS;
        private Budget budgetASInitial;
        private Budget budgetEPSInitial;
        private Flux leFlux;
        private DateTime currentDate = DateTime.Now;
        private int currentYear = DateTime.Now.Year;

        public FormModifierFlux(Utilisateur leUtilisateur, Form leFormCompta, Budget budgetASInitial, Budget budgetEPSInitial, Flux leFlux)
        {
            formCompta = leFormCompta as FormComptabilite;
            this.leUtilisateur = leUtilisateur;
            this.budgetASInitial = budgetASInitial;
            this.budgetEPSInitial = budgetEPSInitial;
            this.leFlux = leFlux;
            InitializeComponent();
            tbxNom.Text = leFlux.Libelle;
            dtpDate.Value = leFlux.Date;
            float montant = leFlux.Montant;
            if (leFlux.TypeFlux.Id == 1)
            {
                montant *= -1;
            }
            tbxMontant.Text = montant.ToString();
            cbxPrelevementEFF.Checked = leFlux.PrelevementEff;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            bool finRecherche = false;
            TypeFlux typeFlux;
            Timer t = new Timer();
            List<TextBox> lesTextBox = new List<TextBox>();
            List<ListBox> lesListBox = new List<ListBox>();
            List<DataGridView> dgvCompta = new List<DataGridView>();
            List<Label> lblCompta = new List<Label>();
            float montant = 0;

            foreach (Control unGridView in formCompta.Controls)
            {
                if (unGridView is DataGridView)
                {
                    dgvCompta.Add((DataGridView)unGridView);
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

            foreach (Control unLabel in formCompta.Controls)
            {
                if (unLabel is Label && unLabel.Name == "lblBudgetEPS" || unLabel.Name == "lblBudgetAS" || unLabel.Name == "lblBudgetEPSInitial" || unLabel.Name == "lblBudgetASInitial")
                {
                    lblCompta.Add((Label)unLabel);
                }
            }

            if (Int32.TryParse(tbxMontant.Text, out int verifMontant) && verifMontant < 0)
            {
                float.TryParse(tbxMontant.Text, out montant);
                montant *= -1;
                typeFlux = new TypeFlux(1, "Débit");
            }
            else
            {
                float.TryParse(tbxMontant.Text, out montant);
                typeFlux = new TypeFlux(2, "Crédit");
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
                if (dtpDate.Value.Year != DateTime.Now.Year && erreur == false)
                {
                    erreur = true;
                    dtpDate.Focus();
                    dtpDate.BackColor = Color.Red;
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Veuillez sélectionner une date valide.";
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        dtpDate.BackColor = Color.White;
                        t.Stop();
                    };
                    t.Start();
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(tbxMontant.Text, "^(-)?[0-9]+(,[0-9]{1,2})?$") && erreur == false)
                {
                    erreur = true;
                    tbxMontant.Focus();
                    tbxMontant.BackColor = Color.Red;
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Veuillez entrer un montant valide.";
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        tbxMontant.BackColor = Color.White;
                        t.Stop();
                    };
                    t.Start();
                }

                finRecherche = true;
            }

            if (erreur == false)
            {
                leFlux.Libelle = tbxNom.Text;
                leFlux.Date = dtpDate.Value;
                leFlux.Montant = montant;
                leFlux.PrelevementEff = cbxPrelevementEFF.Checked;
                leFlux.Adherent = new Adherent(Int32.Parse(lsbAdherant.SelectedValue.ToString()));
                leFlux.TypeFlux = typeFlux;
                leFlux.Evenement = new Evenement(Int32.Parse(lsbEvenement.SelectedValue.ToString()));
                leFlux.Budget = new Budget(Int32.Parse(lsbBudget.SelectedValue.ToString()));

                try
                {
                    FluxBLL.ModifierFlux(leFlux);
                    dgvCompta[2].DataSource = FluxBLL.GetBaseFluxInfo(new TypeFlux(2, "Crédit"), DateTime.Now.Year.ToString());
                    dgvCompta[2].Columns["ID"].Visible = false;
                    dgvCompta[3].DataSource = FluxBLL.GetBaseFluxInfo(new TypeFlux(1, "Débit"), DateTime.Now.Year.ToString());
                    dgvCompta[3].Columns["ID"].Visible = false;
                    // TODO : dgvCompta[1];

                    budgetAS = BLL.BudgetBLL.GetBudgetTotal(DateTime.Now.Year.ToString(), BLL.BudgetBLL.GetBudgetAS(currentYear.ToString()));
                    budgetEPS = BLL.BudgetBLL.GetBudgetTotal(DateTime.Now.Year.ToString(), BLL.BudgetBLL.GetBudgetEPS(currentYear.ToString()));
                    budgetASInitial = BLL.BudgetBLL.GetBudgetAS(currentYear.ToString());
                    budgetEPSInitial = BLL.BudgetBLL.GetBudgetEPS(currentYear.ToString());
                    lblCompta[0].Text = budgetAS.MontantInitial.ToString() + "€";
                    lblCompta[1].Text = budgetEPS.MontantInitial.ToString() + "€";
                    lblCompta[2].Text = budgetASInitial.MontantInitial.ToString() + "€";
                    lblCompta[3].Text = budgetEPSInitial.MontantInitial.ToString() + "€";

                    lblErreur.ForeColor = Color.Green;
                    lblErreur.Text = "Flux " + leFlux.Libelle + " modifié avec succès!";
                    t.Interval = 5000; // 5 secondes
                    t.Tick += (s, error) =>
                    {
                        this.lblErreur.Text = "";
                        t.Stop();
                    };
                    t.Start();
                }
                catch (Exception)
                {
                    lblErreur.ForeColor = Color.Red;
                    lblErreur.Text = "Erreur lors de l'exécution.";
                }
            }
        }

        private void FormModifierFlux_Load(object sender, EventArgs e)
        {
            DateTime minDate = new DateTime(DateTime.Now.Year, 01, 01);
            DateTime maxDate = new DateTime(DateTime.Now.Year, 12, 31);
            dtpDate.MinDate = minDate;
            dtpDate.MaxDate = maxDate;

            try
            {
                this.lsbAdherant.ValueMember = "id";
                this.lsbAdherant.DisplayMember = "nomComplet";
                this.lsbAdherant.DataSource = AdherentBLL.GetFullInfoAdherents();
                this.lsbAdherant.SelectedIndex = -1;
                this.lsbAdherant.SelectedValue = leFlux.Adherent.Id;

                this.lsbBudget.ValueMember = "id";
                this.lsbBudget.DisplayMember = "libelle";
                this.lsbBudget.DataSource = BudgetBLL.GetBudget(DateTime.Now.Year.ToString());
                this.lsbBudget.SelectedIndex = -1;
                this.lsbBudget.SelectedValue = leFlux.Budget.Id;

                this.lsbEvenement.ValueMember = "id";
                this.lsbEvenement.DisplayMember = "libelle";
                this.lsbEvenement.DataSource = EvenementBLL.GetEvenement();
                this.lsbEvenement.SelectedIndex = -1;
                this.lsbEvenement.SelectedValue = leFlux.Evenement.Id;
            }
            catch (Exception)
            {

            }
        }

        private void tbxMontant_TextChanged(object sender, EventArgs e)
        {
            if (tbxMontant.Text.Contains(" "))
            {
                tbxMontant.Text.Replace(" ", "");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(tbxMontant.Text, "^(-)?[0-9]+(,[0-9]{1,2})?$"))
            {
                tbxMontant.Text = System.Text.RegularExpressions.Regex.Replace(tbxMontant.Text, "[^0-9,-]", "");
            }
        }

        private void tbxMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
