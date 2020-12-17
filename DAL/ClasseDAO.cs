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
    public class ClasseDAO
    {
        public static List<Classe> GetClasses()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            List<Classe> lesClasses = new List<Classe>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT ID_classe AS id, Libelle_classe AS libelle FROM CLASSE";
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                Classe uneClasse = new Classe((int)monReader["id"], monReader["libelle"].ToString());
                lesClasses.Add(uneClasse);
            }

            monReader.Close();
            return lesClasses;
        }
    }
}
