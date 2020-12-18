﻿using System;
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
            cmd.CommandText = "SELECT Nom_adherent AS nom, Prenom_adherent AS prenom FROM ADHERENT WHERE Archive_adherent = 0";
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
            cmd.CommandText = "SELECT ID_adherent as id, Nom_adherent AS nom, Prenom_adherent AS prenom, Ddn_adherent as dateNaissance, Sexe_adherent as sexe, Numtel_adherent as num, Email_adherent as mail, Numparent_adherent as numParent, #ID_classe, Libelle_classe as classe FROM ADHERENT INNER JOIN CLASSE ON (ADHERENT.#ID_classe = CLASSE.ID_classe) WHERE Archive_adherent = 0";
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
            cmd.CommandText = "UPDATE dbo.ADHERENT SET Archive_adherent = 1 WHERE Nom_adherent = @nom AND Prenom_adherent = @prenom";

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

        public static void AddAdherent(Adherent unAdherent)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO dbo.ADHERENT (Nom_adherent, Prenom_adherent, Ddn_adherent, Sexe_adherent, Login_adherent_adherent, Mdp_adherent, Numtel_adherent, Email_adherent, Numparent_adherent, Archive_adherent, #Id_utilisateur, #Id_classe) VALUES (@nom, @prenom, @ddn, @sexe, @login, @mdp, @num, @email, @numParent, @archive, @utilisateur, @classe)";

            // Création et bind des paramètres
            SqlParameter nom = new SqlParameter("@nom", SqlDbType.VarChar, 255);
            SqlParameter prenom = new SqlParameter("@prenom", SqlDbType.VarChar, 255);
            SqlParameter dateNaissance = new SqlParameter("@ddn", SqlDbType.DateTime);
            SqlParameter sexe = new SqlParameter("@sexe", SqlDbType.VarChar, 255);
            SqlParameter login = new SqlParameter("@login", SqlDbType.VarChar, 255);
            SqlParameter mdp = new SqlParameter("@mdp", SqlDbType.VarChar, 255);
            SqlParameter numTel = new SqlParameter("@num", SqlDbType.VarChar, 255);
            SqlParameter email = new SqlParameter("@email", SqlDbType.VarChar, 255);
            SqlParameter numTelParent = new SqlParameter("@numParent", SqlDbType.VarChar, 255);
            SqlParameter archive = new SqlParameter("@archive", SqlDbType.Int);
            SqlParameter utilisateur = new SqlParameter("@utilisateur", SqlDbType.Int);
            SqlParameter classe = new SqlParameter("@classe", SqlDbType.Int);
            nom.Value = unAdherent.Nom;
            prenom.Value = unAdherent.Prenom;
            dateNaissance.Value = unAdherent.DateDeNaissance;
            sexe.Value = unAdherent.Sexe;
            login.Value = unAdherent.Login;
            mdp.Value = unAdherent.MotDePasse;
            numTel.Value = unAdherent.NumTel;
            email.Value = unAdherent.Email;
            numTelParent.Value = unAdherent.NumTelParent;
            archive.Value = 0;
            utilisateur.Value = unAdherent.Utilisateur.Id;
            classe.Value = unAdherent.Classe.Id;
            cmd.Parameters.Add(nom);
            cmd.Parameters.Add(prenom);
            cmd.Parameters.Add(dateNaissance);
            cmd.Parameters.Add(sexe);
            cmd.Parameters.Add(login);
            cmd.Parameters.Add(mdp);
            cmd.Parameters.Add(numTel);
            cmd.Parameters.Add(email);
            cmd.Parameters.Add(numTelParent);
            cmd.Parameters.Add(archive);
            cmd.Parameters.Add(utilisateur);
            cmd.Parameters.Add(classe);

            // Execution de la requête
            cmd.ExecuteNonQuery();
        }

        public static bool AdherentExiste(AdherentMin unAdherent)
        {
            List<AdherentMin> lesAdherents = GetInfoBaseAdherents();

            if (lesAdherents.Exists(leAdherent => unAdherent.Nom == leAdherent.Nom && unAdherent.Prenom == leAdherent.Prenom))
            {
                return true;
            }
            return false;
        }
    }
}
