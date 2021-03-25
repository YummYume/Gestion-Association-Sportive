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

        public FormAjoutFlux(Utilisateur leUtilisateur, Form leFormCompta)
        {
            formCompta = leFormCompta as FormComptabilite;
            this.leUtilisateur = leUtilisateur;
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            TypeFlux typeFlux;

            if (Int32.Parse(tbxMontant.Text) < 0)
            {
                typeFlux = new TypeFlux(1, "Débit");
            }
            else
            {
                typeFlux = new TypeFlux(2, "Crédit");
            }

            Flux leFlux = new Flux(0, tbxNom.Text, dtpDate.Value, float.Parse(tbxMontant.Text), cbxPrelevementEFF.Checked.ToString(), new Adherent(Int32.Parse(lsbAdherant.SelectedValue.ToString())), typeFlux, new Evenement(Int32.Parse(lsbEvenement.SelectedValue.ToString())), new Budget(Int32.Parse(lsbBudget.SelectedValue.ToString())));
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
                this.lsbBudget.SelectedIndex = -1;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
