using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BO;
using DAL;

namespace BLL
{
    public class ClasseBLL
    {
        private static ClasseBLL uneClasseBLL;

        public static ClasseBLL GetClasseBLL()
        {
            if (ClasseBLL.uneClasseBLL == null)
            {
                ClasseBLL.uneClasseBLL = new ClasseBLL();
            }
            return ClasseBLL.uneClasseBLL;
        }

        public static List<Classe> GetClasses()
        {
            return ClasseDAO.GetClasses();
        }
    }
}
