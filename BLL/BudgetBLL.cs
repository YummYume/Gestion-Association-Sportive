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
