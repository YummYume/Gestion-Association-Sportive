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

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static List<Classe> GetClasses()
        {
            return ClasseDAO.GetClasses();
        }
    }
}
