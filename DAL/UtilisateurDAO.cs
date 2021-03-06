﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BO;

namespace DAL
{
    public class UtilisateurDAO
    {
        // Vérifie si un utilisateur existe
        public static bool UtilisateurExiste(string login)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Login_utilisateur AS login FROM UTILISATEUR";
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["login"].ToString() == login)
                {
                    monReader.Close();
                    return true;
                }
            }

            monReader.Close();
            return false;
        }

        // Vérifie si le mot de passe correspond
        public static bool VerifierMotDePasse(string login, string mdp)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Mdp_utilisateur AS mdp FROM UTILISATEUR WHERE Login_utilisateur = @LOGIN";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@LOGIN";
            param.Value = login;
            cmd.Parameters.Add(param);
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["mdp"].ToString() == mdp)
                {
                    monReader.Close();
                    return true;
                }
            }

            monReader.Close();
            return false;
        }

        // Vérifier le droit de l'utilisateur
        public static string GetDroit(string login)
        {
            string droit = "";
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Droit_utilisateur AS droit FROM UTILISATEUR WHERE Login_utilisateur = @LOGIN";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@LOGIN";
            param.Value = login;
            cmd.Parameters.Add(param);
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["droit"].ToString() != null)
                {
                    droit = monReader["droit"].ToString();
                    monReader.Close();
                    return droit;
                }
            }

            monReader.Close();
            return droit;
        }

        public static Utilisateur CreerUtilisateurConnexion(string login)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM UTILISATEUR WHERE Login_utilisateur = @LOGIN";
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@LOGIN";
            param.Value = login;
            cmd.Parameters.Add(param);
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["Login_utilisateur"].ToString() == login)
                {
                    int idUtilisateur = Convert.ToInt32(monReader["ID_utilisateur"]);
                    string loginUtilisateur = monReader["Login_utilisateur"].ToString();
                    string mdpUtilisateur = monReader["Mdp_utilisateur"].ToString();
                    string droitUtilisateur = monReader["Droit_utilisateur"].ToString();
                    monReader.Close();
                    return new Utilisateur(idUtilisateur, loginUtilisateur, mdpUtilisateur, droitUtilisateur);
                }
            }

            monReader.Close();
            return new Utilisateur(0, "Utilisateur", "Introuvable", "null");
        }
    }
}
