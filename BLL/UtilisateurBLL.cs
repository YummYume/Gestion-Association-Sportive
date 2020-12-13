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
            if (UtilisateurBLL.unUtilisateurBLL == null)
            {
                UtilisateurBLL.unUtilisateurBLL = new UtilisateurBLL();
            }
            return UtilisateurBLL.unUtilisateurBLL;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static string VerificationConnexion(string login, string mdp)
        {
            // Vérifier si le compte existe // le mot de passe correspond
            if (!UtilisateurDAO.UtilisateurExiste(login))
            {
                return "Utilisateur inconnu";
            }
            else
            {
                if (!UtilisateurDAO.VerifierMotDePasse(login, mdp))
                {
                    return "Mot de passe invalide";
                }
            }
            return "";
        }

        public static string GetDroit(string login)
        {
            return UtilisateurDAO.GetDroit(login);
        }
    }
}
