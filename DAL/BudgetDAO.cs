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
    public class BudgetDAO
    {
        public static Budget getBudgetAS(string year)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            Budget budgetAS = new Budget(0, "null", 0, DateTime.Now);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Libelle_budget AS libelle, Montantinitial_budget AS montantInitial, DateCreation_budget AS dateCreation FROM BUDGET WHERE Libelle_budget = 'AS' AND DateCreation_budget LIKE '@YEAR*'";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@YEAR";
            param.Value = year;
            cmd.Parameters.Add(param);
            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.HasRows)
            {
                while (monReader.Read())
                {
                    budgetAS.Id = (int)monReader["id"];
                    budgetAS.Libelle = (string)monReader["libelle"];
                    budgetAS.MontantInitial = (int)monReader["monstantInitial"];
                    budgetAS.DateCreation = (DateTime)monReader["dateCreation"];
                }
            }

            monReader.Close();
            return budgetAS;
        }

        public static Budget getBudgetEPS(string year)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            Budget budgetEPS = new Budget(0, "null", 0, DateTime.Now);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Libelle_budget AS libelle, Montantinitial_budget AS montantInitial, DateCreation_budget AS dateCreation FROM dbo.BUDGET WHERE Libelle_budget = 'EPS' AND DateCreation_budget LIKE '@YEAR*'";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@YEAR";
            param.Value = year;
            cmd.Parameters.Add(param);
            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.HasRows)
            {
                while (monReader.Read())
                {
                    budgetEPS.Id = (int)monReader["id"];
                    budgetEPS.Libelle = (string)monReader["libelle"];
                    budgetEPS.MontantInitial = (int)monReader["monstantInitial"];
                    budgetEPS.DateCreation = (DateTime)monReader["dateCreation"];
                }
            }

            monReader.Close();
            return budgetEPS;
        }

        public static void AddBudget(Budget unBudget)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO dbo.BUDGET (Libelle_budget, Montantinitial_budget, DateCreation_budget) VALUES (@libelle, @montantInitial, @dateCreation)";

            // Création et bind des paramètres
            SqlParameter libelle = new SqlParameter("@libelle", SqlDbType.VarChar, 255);
            SqlParameter montantInitial = new SqlParameter("@montantInitial", SqlDbType.Int);
            SqlParameter dateCreation = new SqlParameter("@dateCreation", SqlDbType.DateTime);
            libelle.Value = unBudget.Libelle;
            montantInitial.Value = unBudget.MontantInitial;
            dateCreation.Value = unBudget.DateCreation;
            cmd.Parameters.Add(libelle);
            cmd.Parameters.Add(montantInitial);
            cmd.Parameters.Add(dateCreation);

            // Execution de la requête
            cmd.ExecuteNonQuery();
        }

        public static void ModifierBudget(Budget unBudget)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE dbo.BUDGET SET Libelle_budget = @libelle, Montantinitial_budget = @montantInitial, DateCreation_budget = @dateCreation WHERE ID_budget = @id";

            // Création et bind des paramètres
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            SqlParameter libelle = new SqlParameter("@libelle", SqlDbType.VarChar, 255);
            SqlParameter montantInitial = new SqlParameter("@montantInitial", SqlDbType.Int);
            SqlParameter dateCreation = new SqlParameter("@dateCreation", SqlDbType.DateTime);
            id.Value = unBudget.Id;
            libelle.Value = unBudget.Libelle;
            montantInitial.Value = unBudget.MontantInitial;
            dateCreation.Value = unBudget.DateCreation;
            cmd.Parameters.Add(id);
            cmd.Parameters.Add(libelle);
            cmd.Parameters.Add(montantInitial);
            cmd.Parameters.Add(dateCreation);

            // Execution de la requête
            cmd.ExecuteNonQuery();
        }
    }
}
