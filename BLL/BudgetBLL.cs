using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class BudgetBLL
    {
        private static BudgetBLL unBudgetBLL;

        public static BudgetBLL GetBudgetBLL()
        {
            if (BudgetBLL.unBudgetBLL == null)
            {
                BudgetBLL.unBudgetBLL = new BudgetBLL();
            }
            return BudgetBLL.unBudgetBLL;
        }

        public static Budget GetBudgetAS(string year)
        {
            return BudgetDAO.getBudgetAS(year);
        }

        public static Budget GetBudgetEPS(string year)
        {
            return BudgetDAO.getBudgetEPS(year);
        }

        public static Budget GetBudgetTotal(string year, Budget budget)
        {
            List<Flux> fluxDebit = FluxBLL.GetFluxDebit(year, null, budget);
            List<Flux> fluxCredit = FluxBLL.GetFluxCredit(year, null, budget);

            foreach (Flux flux in fluxDebit)
            {
                budget.MontantInitial -= flux.Montant;
            }
            foreach (Flux flux in fluxCredit)
            {
                budget.MontantInitial += flux.Montant;
            }

            return budget;
        }

        public static void AddBudget(Budget unBudget)
        {
            BudgetDAO.AddBudget(unBudget);
        }

        public static void ModifierBudget(Budget unBudget)
        {
            BudgetDAO.ModifierBudget(unBudget);
        }
    }
}
