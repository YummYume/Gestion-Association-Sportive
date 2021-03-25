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
    public partial class FormAjoutFlux : Form
    {
        private Utilisateur leUtilisateur;
        private FormComptabilite formCompta;
        private Budget budgetAS;
        private Budget budgetEPS;
        private Budget budgetASInitial;
        private Budget budgetEPSInitial;
        private DateTime currentDate = DateTime.Now;
        private int currentYear = DateTime.Now.Year;

        public FormAjoutFlux(Utilisateur leUtilisateur, Form leFormCompta, Budget budgetASInitial, Budget budgetEPSInitial)
        {
            formCompta = leFormCompta as FormComptabilite;
            this.leUtilisateur = leUtilisateur;
            this.budgetASInitial = budgetASInitial;
            this.budgetEPSInitial = budgetEPSInitial;
            InitializeComponent();
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

            foreach (Control unGridView in formCompta.Controls)
            {
                if (unGridView is DataGridView)
                {
                    dgvCompta.Add((DataGridView)unGridView);
                }
            }

            foreach (Control unLabel in formCompta.Controls)
            {
                if (unLabel is Label && unLabel.Name == "lblBudgetEPS" || unLabel.Name == "lblBudgetAS" || unLabel.Name == "lblBudgetEPSInitial" || unLabel.Name == "lblBudgetASInitial")
                {
                    lblCompta.Add((Label)unLabel);
                }
            }

            if (Int32.Parse(tbxMontant.Text) < 0)
            {
                typeFlux = new TypeFlux(1, "Débit");
            }
            else
            {
                typeFlux = new TypeFlux(2, "Crédit");
            }

            if (erreur == false)
            {
                Flux leFlux = new Flux(0, tbxNom.Text, dtpDate.Value, float.Parse(tbxMontant.Text), cbxPrelevementEFF.Checked, new Adherent(Int32.Parse(lsbAdherant.SelectedValue.ToString())), typeFlux, new Evenement(Int32.Parse(lsbEvenement.SelectedValue.ToString())), new Budget(Int32.Parse(lsbBudget.SelectedValue.ToString())));

                try
                {
                    FluxBLL.AddFlux(leFlux);
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
                    lblErreur.Text = "Flux " + leFlux.Libelle + " ajouté avec succès!";
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

        private void FormAjoutFlux_Load(object sender, EventArgs e)
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

                this.lsbBudget.ValueMember = "id";
                this.lsbBudget.DisplayMember = "libelle";
                this.lsbBudget.DataSource = BudgetBLL.GetBudget(DateTime.Now.Year.ToString());
                this.lsbBudget.SelectedIndex = -1;

                this.lsbEvenement.ValueMember = "id";
                this.lsbEvenement.DisplayMember = "libelle";
                this.lsbEvenement.DataSource = EvenementBLL.GetEvenement();
                this.lsbEvenement.SelectedIndex = -1;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
