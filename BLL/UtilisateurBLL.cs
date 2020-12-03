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
    public class UtilisateurBLL
    {
        private static UtilisateurBLL unUtilisateurBLL;

        public static UtilisateurBLL GetUtilisateurBLL()
        {
            if (unUtilisateurBLL == null)
            {
                unUtilisateurBLL = new UtilisateurBLL();
            }
            return unUtilisateurBLL;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
    }
}
