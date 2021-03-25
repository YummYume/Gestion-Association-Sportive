using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class EvenementBLL
    {
        public static List<Evenement> GetEvenement()
        {
            return EvenementDAO.GetEvenement();
        }
    }
}
