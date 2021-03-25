using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BO;
using System.Data;

namespace DAL
{
    public class EvenementDAO
    {
        public static List<Evenement> GetEvenement()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            List<Evenement> listeEvenements = new List<Evenement>();

            return listeEvenements;
        }
    }
}
