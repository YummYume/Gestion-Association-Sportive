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

        public static List<List<string>> GetNombreAdherentsEvenements()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            List<List<string>> lesEvenements = new List<List<string>>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT EVENEMENT.ID_evenement, EVENEMENT.Libelle_evenement as libelleEvenement, COUNT(*) as nombreInscription FROM EVENEMENT, FLUX WHERE FLUX.Libelle_flux = 'Inscription' GROUP BY EVENEMENT.ID_evenement, EVENEMENT.Libelle_evenement";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                List<string> unEvenement = new List<string>();
                unEvenement.Add(monReader["libelleEvenement"].ToString());
                unEvenement.Add(monReader["nombreInscription"].ToString());
                lesEvenements.Add(unEvenement);
            }

            monReader.Close();
            return lesEvenements;
        }
    }
}
