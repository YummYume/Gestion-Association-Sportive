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
    public class AdherentBLL
    {
        private static AdherentBLL unAdherentBLL;

        public static AdherentBLL GetAdherentBLL()
        {
            if (AdherentBLL.unAdherentBLL == null)
            {
                AdherentBLL.unAdherentBLL = new AdherentBLL();
            }
            return AdherentBLL.unAdherentBLL;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static List<AdherentMin> GetInfoBaseAdherents()
        {
            return AdherentDAO.GetInfoBaseAdherents();
        }

        public static List<Adherent> GetFullInfoAdherents()
        {
            return AdherentDAO.GetFullInfoAdherents();
        }

        public static void RemoveAdherent(AdherentMin unAdherent)
        {
            AdherentDAO.RemoveAdherent(unAdherent);
        }

        public static void AddAdherent(Adherent unAdherent)
        {
            AdherentDAO.AddAdherent(unAdherent);
        }

        public static bool AdherentExiste(AdherentMin unAdherent)
        {
            return AdherentDAO.AdherentExiste(unAdherent);
        }
    }
}
