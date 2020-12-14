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
    public class AdherentDAO
    {
        public static List<AdherentMin> GetInfoBaseAdherents()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            List<AdherentMin> lesAdherents = new List<AdherentMin>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Nom_adherent AS nom, Prenom_adherent AS prenom FROM ADHERENT";
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                AdherentMin unAdherent = new AdherentMin(monReader["nom"].ToString(), monReader["prenom"].ToString());
                lesAdherents.Add(unAdherent);
            }

            monReader.Close();
            return lesAdherents;
        }

        public static void RemoveAdherent(AdherentMin unAdherent)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM ADHERENT WHERE Nom_adherent = @nom AND Prenom_adherent = @prenom";

            // Création et bind des paramètres
            SqlParameter nom = new SqlParameter("@nom", SqlDbType.VarChar, 255);
            SqlParameter prenom = new SqlParameter("@prenom", SqlDbType.VarChar, 255);
            nom.Value = unAdherent.Nom;
            prenom.Value = unAdherent.Prenom;
            cmd.Parameters.Add(nom);
            cmd.Parameters.Add(prenom);

            // Execution de la requête
            cmd.ExecuteNonQuery();
        }
    }
}
