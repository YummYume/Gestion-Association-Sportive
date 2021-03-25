﻿using System;
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
    public partial class FormComptabilite : Form
    {
        private Utilisateur leUtilisateur;
        private Budget budgetAS;
        private Budget budgetEPS;
        private Budget budgetASInitial;
        private Budget budgetEPSInitial;
        private DateTime currentDate = DateTime.Now;
        private int currentYear = DateTime.Now.Year;

        public FormComptabilite(Utilisateur unUtilisateur)
        {
            leUtilisateur = unUtilisateur;
            InitializeComponent();
        }

        private void FormComptabilite_Load(object sender, EventArgs e)
        {
            lblAnnee.Text += " " + currentYear;

            budgetAS = BLL.BudgetBLL.GetBudgetTotal(DateTime.Now.Year.ToString(), BLL.BudgetBLL.GetBudgetAS(currentYear.ToString()));
            budgetEPS = BLL.BudgetBLL.GetBudgetTotal(DateTime.Now.Year.ToString(), BLL.BudgetBLL.GetBudgetEPS(currentYear.ToString()));
            budgetASInitial = BLL.BudgetBLL.GetBudgetAS(currentYear.ToString());
            budgetEPSInitial = BLL.BudgetBLL.GetBudgetEPS(currentYear.ToString());
            lblBudgetAS.Text = budgetAS.MontantInitial.ToString()+ "€";
            lblBudgetEPS.Text = budgetEPS.MontantInitial.ToString() + "€";
            lblBudgetASInitial.Text = budgetASInitial.MontantInitial.ToString() + "€";
            lblBudgetEPSInitial.Text = budgetEPSInitial.MontantInitial.ToString() + "€";

            if (budgetAS.Id == 0)
            {
                btnSetBudgetAS.Visible = true;
                btnModifierBudgetAS.Visible = false;
                txbBudgetAS.Visible = true;
                lblBudgetASInitial.Visible = false;
            }
            else
            {
                btnSetBudgetAS.Visible = false;
                btnModifierBudgetAS.Visible = true;
                txbBudgetAS.Visible = false;
                lblBudgetASInitial.Visible = true;
            }

            if (budgetEPS.Id == 0)
            {
                btnModifierBudgetEPS.Visible = true;
                btnModifierBudgetEPS.Visible = false;
                txbBudgetEPS.Visible = true;
                lblBudgetEPSInitial.Visible = false;
            }
            else
            {
                btnSetBudgetEPS.Visible = false;
                btnModifierBudgetEPS.Visible = true;
                txbBudgetEPS.Visible = false;
                lblBudgetEPSInitial.Visible = true;
            }

            this.dtgCredit.DataSource = FluxBLL.GetBaseFluxInfo(new TypeFlux(2, "Crédit"), currentYear.ToString());
            if (this.dtgCredit.Rows.Count > 0)
            {
                this.dtgCredit.Rows[0].Selected = false;
                this.dtgCredit.CurrentCell = null;
                this.dtgCredit.Columns["ID"].Visible = false;
            }

            this.dtgDebit.DataSource = FluxBLL.GetBaseFluxInfo(new TypeFlux(1, "Débit"), currentYear.ToString());
            if (this.dtgDebit.Rows.Count > 0)
            {
                this.dtgDebit.Rows[0].Selected = false;
                this.dtgDebit.CurrentCell = null;
                this.dtgDebit.Columns["ID"].Visible = false;
            }
        }

        private void btnModifierBudgetEPS_Click(object sender, EventArgs e)
        {
            btnModifierBudgetEPS.Visible = false;
            btnEnvoyerModifEPS.Visible = true;
            btnAnnulerModifEPS.Visible = true;
            lblBudgetEPSInitial.Visible = false;
            txbBudgetEPS.Visible = true;

            txbBudgetEPS.Text = BLL.BudgetBLL.GetBudgetEPS(currentYear.ToString()).MontantInitial.ToString();
        }

        private void btnModifierBudgetAS_Click(object sender, EventArgs e)
        {
            btnModifierBudgetAS.Visible = false;
            btnEnvoyerModifAS.Visible = true;
            btnAnnulerModifAS.Visible = true;
            lblBudgetASInitial.Visible = false;
            txbBudgetAS.Visible = true;

            txbBudgetAS.Text = BLL.BudgetBLL.GetBudgetAS(currentYear.ToString()).MontantInitial.ToString();
        }

        private void btnEnvoyerModifEPS_Click(object sender, EventArgs e)
        {
            Budget newBudgetEPS = budgetEPSInitial;
            newBudgetEPS.MontantInitial = float.Parse(txbBudgetEPS.Text);
            BLL.BudgetBLL.ModifierBudget(newBudgetEPS);

            budgetEPS = BLL.BudgetBLL.GetBudgetTotal(currentYear.ToString(), BLL.BudgetBLL.GetBudgetEPS(currentYear.ToString()));
            lblBudgetEPS.Text = budgetEPS.MontantInitial.ToString() + "€";
            budgetEPSInitial = BLL.BudgetBLL.GetBudgetEPS(currentYear.ToString());
            lblBudgetEPSInitial.Text = budgetEPSInitial.MontantInitial.ToString() + "€";

            btnModifierBudgetEPS.Visible = true;
            btnEnvoyerModifEPS.Visible = false;
            btnAnnulerModifEPS.Visible = false;
            lblBudgetEPSInitial.Visible = true;
            txbBudgetEPS.Visible = false;
        }

        private void btnAnnulerModifEPS_Click(object sender, EventArgs e)
        {
            btnModifierBudgetEPS.Visible = true;
            btnEnvoyerModifEPS.Visible = false;
            btnAnnulerModifEPS.Visible = false;
            lblBudgetEPSInitial.Visible = true;
            txbBudgetEPS.Visible = false;
        }

        private void btnSetBudgetAS_Click(object sender, EventArgs e)
        {
            BLL.BudgetBLL.AddBudget(new Budget("AS", Int32.Parse(txbBudgetAS.Text), currentDate));

            budgetAS = BLL.BudgetBLL.GetBudgetTotal(DateTime.Now.Year.ToString(), BLL.BudgetBLL.GetBudgetAS(currentYear.ToString()));
            lblBudgetASInitial.Text = budgetAS.MontantInitial.ToString();

            btnSetBudgetAS.Visible = false;
            btnModifierBudgetAS.Visible = true;
            txbBudgetAS.Visible = false;
            lblBudgetASInitial.Visible = true;
            btnFluxAjouter.Enabled = true;
            btnFluxModifier.Enabled = true;
            btnFluxSupprimer.Enabled = true;
        }

        private void btnSetBudgetEPS_Click(object sender, EventArgs e)
        {
            BLL.BudgetBLL.AddBudget(new Budget("EPS", Int32.Parse(txbBudgetEPS.Text), currentDate));

            budgetEPS = BLL.BudgetBLL.GetBudgetTotal(DateTime.Now.Year.ToString(), BLL.BudgetBLL.GetBudgetEPS(currentYear.ToString()));
            lblBudgetEPSInitial.Text = budgetEPS.MontantInitial.ToString();

            btnSetBudgetEPS.Visible = false;
            btnModifierBudgetEPS.Visible = true;
            txbBudgetEPS.Visible = false;
            lblBudgetEPSInitial.Visible = true;
            btnFluxAjouter.Enabled = true;
            btnFluxModifier.Enabled = true;
            btnFluxSupprimer.Enabled = true;
        }

        private void btnEnvoyerModifAS_Click(object sender, EventArgs e)
        {
            Budget newBudgetAS = budgetAS;
            newBudgetAS.MontantInitial = float.Parse(txbBudgetAS.Text);
            BLL.BudgetBLL.ModifierBudget(newBudgetAS);

            budgetAS = BLL.BudgetBLL.GetBudgetTotal(currentYear.ToString(), BLL.BudgetBLL.GetBudgetAS(currentYear.ToString()));
            lblBudgetAS.Text = budgetAS.MontantInitial.ToString() + "€";
            budgetASInitial = BLL.BudgetBLL.GetBudgetAS(currentYear.ToString());
            lblBudgetASInitial.Text = budgetASInitial.MontantInitial.ToString() + "€";

            btnModifierBudgetAS.Visible = true;
            btnEnvoyerModifAS.Visible = false;
            btnAnnulerModifAS.Visible = false;
            lblBudgetASInitial.Visible = true;
            txbBudgetAS.Visible = false;
        }

        private void btnAnnulerModifAS_Click(object sender, EventArgs e)
        {
            btnModifierBudgetAS.Visible = true;
            btnEnvoyerModifAS.Visible = false;
            btnAnnulerModifAS.Visible = false;
            lblBudgetASInitial.Visible = true;
            txbBudgetAS.Visible = false;
        }

        private void txbBudgetEPS_TextChanged(object sender, EventArgs e)
        {
            if (txbBudgetEPS.Text.Contains(" "))
            {
                txbBudgetEPS.Text.Replace(" ", "");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txbBudgetEPS.Text, "^[0-9]+(,[0-9]{1,2})?$"))
            {
                txbBudgetEPS.Text = System.Text.RegularExpressions.Regex.Replace(txbBudgetEPS.Text, "[^0-9,]", "");
            }
            else
            {
                btnEnvoyerModifEPS.Enabled = true;
                btnSetBudgetEPS.Enabled = true;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txbBudgetEPS.Text, "^[0-9]+(,[0-9]{1,2})?$"))
            {
                btnEnvoyerModifEPS.Enabled = false;
                btnSetBudgetEPS.Enabled = false;
            }
        }

        private void txbBudgetAS_TextChanged(object sender, EventArgs e)
        {
            if (txbBudgetAS.Text.Contains(" "))
            {
                txbBudgetAS.Text.Replace(" ", "");
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txbBudgetAS.Text, "^[0-9]+(,[0-9]{1,2})?$"))
            {
                txbBudgetAS.Text = System.Text.RegularExpressions.Regex.Replace(txbBudgetAS.Text, "[^0-9,]", "");
            }
            else
            {
                btnEnvoyerModifAS.Enabled = true;
                btnSetBudgetAS.Enabled = true;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txbBudgetAS.Text, "^[0-9]+(,[0-9]{1,2})?$"))
            {
                btnEnvoyerModifAS.Enabled = false;
                btnSetBudgetAS.Enabled = false;
            }
        }

        private void dtgDebit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtgDebit.SelectedCells.Count > 0)
            {
                this.dtgDebit.SelectedCells[0].OwningRow.Selected = true;
                btnFluxModifier.Enabled = true;
                btnFluxSupprimer.Enabled = true;
            }
            this.dtgCredit.ClearSelection();
        }

        private void dtgCredit_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtgCredit.SelectedCells.Count > 0)
            {
                this.dtgCredit.SelectedCells[0].OwningRow.Selected = true;
                btnFluxModifier.Enabled = true;
                btnFluxSupprimer.Enabled = true;
            }
            this.dtgDebit.ClearSelection();
        }

        private void btnFluxSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dtgCredit.SelectedRows.Count > 0)
            {
                string nom = dtgCredit.CurrentRow.Cells[0].Value.ToString();
                DateTime date = DateTime.Parse(dtgCredit.CurrentRow.Cells[1].Value.ToString());
                DialogResult reponseMsgBox;

                reponseMsgBox = MessageBox.Show("Voulez vous vraiment supprimer le flux " + nom + " du " + date + "?", "Suppression d'un flux", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (reponseMsgBox == DialogResult.Yes)
                {
                    FluxBLL.SupprimerFlux((FluxMin)this.dtgCredit.SelectedRows[0].DataBoundItem);
                    this.dtgCredit.DataSource = FluxBLL.GetBaseFluxInfo(new TypeFlux(2, "Crédit"), currentYear.ToString());
                }
            }
            else
            {
                if (this.dtgDebit.SelectedRows.Count > 0)
                {
                    string nom = dtgDebit.CurrentRow.Cells[0].Value.ToString();
                    DateTime date = DateTime.Parse(dtgDebit.CurrentRow.Cells[1].Value.ToString());
                    DialogResult reponseMsgBox;

                    reponseMsgBox = MessageBox.Show("Voulez vous vraiment supprimer le flux " + nom + " du " + date + "?", "Suppression d'un flux", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (reponseMsgBox == DialogResult.Yes)
                    {
                        FluxBLL.SupprimerFlux((FluxMin)this.dtgDebit.SelectedRows[0].DataBoundItem);
                        this.dtgDebit.DataSource = FluxBLL.GetBaseFluxInfo(new TypeFlux(1, "Débit"), currentYear.ToString());
                    }
                }
            }
        }

        private void btnFluxModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnFluxAjouter_Click(object sender, EventArgs e)
        {
            FormAjoutFlux newAjoutFlux;
            newAjoutFlux = new FormAjoutFlux(leUtilisateur, this);
            newAjoutFlux.ShowDialog();
        }
    }
}
