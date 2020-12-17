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

        public static List<Adherent> GetFullInfoAdherents()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            List<Adherent> lesAdherents = new List<Adherent>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT ID_adherent as id, Nom_adherent AS nom, Prenom_adherent AS prenom, Ddn_adherent as dateNaissance, Sexe_adherent as sexe, Numtel_adherent as num, Email_adherent as mail, Numparent_adherent as numParent, #ID_classe, Libelle_classe as classe FROM ADHERENT INNER JOIN CLASSE ON (ADHERENT.#ID_classe = CLASSE.ID_classe)";
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                Classe uneClasse = new Classe(Convert.ToInt32(monReader["#ID_classe"]), monReader["classe"].ToString());
                Adherent unAdherent = new Adherent(Convert.ToInt32(monReader["id"]), monReader["nom"].ToString(), monReader["prenom"].ToString(), Convert.ToDateTime(monReader["dateNaissance"]), monReader["sexe"].ToString(), monReader["num"].ToString(), monReader["mail"].ToString(), monReader["numParent"].ToString(), uneClasse);
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
