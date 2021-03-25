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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT ID_evenement as id, Libelle_evenement AS libelle, Date_evenement AS date, Lieu_evenement AS lieu FROM EVENEMENT";
            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.HasRows)
            {
                while (monReader.Read())
                {
                    Evenement evenement = new Evenement((int)monReader["id"], (string)monReader["libelle"], (DateTime)monReader["date"], (string)monReader["lieu"]);

                    listeEvenements.Add(evenement);
                }
            }

            monReader.Close();
            return listeEvenements;
        }
    }
}
