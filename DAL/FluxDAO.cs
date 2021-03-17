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
    public class FluxDAO
    {
        public static List<Flux> GetFlux(TypeFlux typeFlux, string year = null, Adherent adherent = null)
        {
            List<Flux> lesFlux = new List<Flux>();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT Id_flux AS idFlux, Libelle_flux AS libelleFLux, Date_flux AS dateFlux, Montant_flux as montantFlux, Prelevementeff_flux as prelevementFlux, #ID_typeflux as idTypeFlux, ID_evenement as idEvenement, Libelle_evenement as libelleEvenement, Date_evenement as dateEvenement, Lieu_evenement as lieuEvenement, Cout_evenement as coutEvenement, ID_adherent as idAdherent, Nom_adherent as nomAdherent, Prenom_adherent as prenomAdherent, Ddn_adherent as dateDeNaissanceAdherent, Sexe_adherent as sexeAdherent, Login_adherent_adherent as loginAdherent, Numtel_adherent as numTelAdherent, Email_adherent as emailAdherent, Numparent_adherent as numParentAdherent, Datemaj_adherent as dateMajAdherent, Archive_adherent as archiveAdherent, ID_classe as idClasse, Libelle_classe as libelleClasse FROM dbo.FLUX LEFT JOIN dbo.EVENEMENT ON FLUX.#ID_evenement = EVENEMENT.ID_evenement LEFT JOIN dbo.ADHERENT ON FLUX.#ID_adherent = ADHERENT.ID_adherent LEFT JOIN dbo.CLASSE ON ADHERENT.#ID_classe = CLASSE.ID_classe WHERE #ID_typeflux = @FLUX ";
            SqlParameter fluxParam = new SqlParameter();
            fluxParam.ParameterName = "@FLUX";
            fluxParam.Value = typeFlux.Id;
            cmd.Parameters.Add(fluxParam);

            if (year != null)
            {
                cmd.CommandText += "AND Date_flux LIKE '@YEAR*' ";
                SqlParameter yearParam = new SqlParameter();
                yearParam.ParameterName = "@YEAR";
                yearParam.Value = year;
                cmd.Parameters.Add(yearParam);
            }
            if (adherent != null)
            {
                cmd.CommandText += "AND ID_adherent = '@ID*'";
                SqlParameter idParam = new SqlParameter();
                idParam.ParameterName = "@ID";
                idParam.Value = adherent.Id;
                cmd.Parameters.Add(idParam);
            }
            SqlDataReader monReader = cmd.ExecuteReader();

            if (monReader.HasRows)
            {
                while (monReader.Read())
                {
                    Classe classe = new Classe((int)monReader["idClasse"], (string)monReader["libelleClasse"]);
                    adherent = new Adherent((int)monReader["idAdherent"], (string)monReader["nomAdherent"], (string)monReader["prenomAdherent"], (DateTime)monReader["dateDeNaissanceAdherent"], (string)monReader["sexeAdherent"], (string)monReader["loginAdherent"], "null", (string)monReader["numTelAdherent"], (string)monReader["emailAdherent"], (string)monReader["numTelParentAdherent"], classe);
                    Evenement evenement = new Evenement((int)monReader["idEvenement"], (string)monReader["libelleEvenement"], (DateTime)monReader["dateEvenement"], (string)monReader["lieuEvenement"], (float)monReader["coutEvenement"]);
                    Flux flux = new Flux((int)monReader["idFlux"], (string)monReader["libelleFlux"], (DateTime)monReader["dateFlux"], (float)monReader["montantFlux"], (string)monReader["prelevementFlux"], adherent, typeFlux, evenement);

                    lesFlux.Add(flux);
                }
            }

            monReader.Close();
            return lesFlux;
        }

        public static void AddFlux(Flux unFlux)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO dbo.FLUX (Libelle_flux, Date_flux, Montant_flux, Prelevementeff_flux, #ID_adherent, #ID_typeflux, #ID_evenement) VALUES (@libelle, @date, @montant, @prelevementEff, @idAdherent, @idTypeFlux, @idEvenement)";

            // Création et bind des paramètres
            SqlParameter libelle = new SqlParameter("@libelle", SqlDbType.VarChar, 255);
            SqlParameter date = new SqlParameter("@date", SqlDbType.DateTime);
            SqlParameter montant = new SqlParameter("@montant", SqlDbType.Int);
            SqlParameter prelevementEff = new SqlParameter("@prelevementEff", SqlDbType.TinyInt);
            SqlParameter idAdherent = new SqlParameter("@idAdherent", SqlDbType.Int);
            SqlParameter idTypeFlux = new SqlParameter("@idTypeFlux", SqlDbType.Int);
            SqlParameter idEvenement = new SqlParameter("@idEvenement", SqlDbType.Int);
            libelle.Value = unFlux.Libelle;
            date.Value = unFlux.Date;
            montant.Value = unFlux.Montant;
            prelevementEff.Value = unFlux.PrelevementEff;
            idAdherent.Value = unFlux.Adherent.Id;
            idTypeFlux.Value = unFlux.TypeFlux.Id;
            idEvenement.Value = unFlux.Evenement.Id;
            cmd.Parameters.Add(libelle);
            cmd.Parameters.Add(date);
            cmd.Parameters.Add(montant);
            cmd.Parameters.Add(prelevementEff);
            cmd.Parameters.Add(idAdherent);
            cmd.Parameters.Add(idTypeFlux);
            cmd.Parameters.Add(idEvenement);

            // Execution de la requête
            cmd.ExecuteNonQuery();
        }

        public static void ModifierFlux(Flux unFlux)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE dbo.FLUX SET Libelle_flux = @libelle, Date_flux = @date, Montant_flux = @montant, Prelevementeff_flux = @prelevementEff, #ID_adherent = @idAdherent, #ID_typeflux = @idTypeFlux, #ID_evenement = @idEvenement WHERE ID_flux = @id";

            // Création et bind des paramètres
            SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            SqlParameter libelle = new SqlParameter("@libelle", SqlDbType.VarChar, 255);
            SqlParameter date = new SqlParameter("@date", SqlDbType.DateTime);
            SqlParameter montant = new SqlParameter("@montant", SqlDbType.Int);
            SqlParameter prelevementEff = new SqlParameter("@prelevementEff", SqlDbType.TinyInt);
            SqlParameter idAdherent = new SqlParameter("@idAdherent", SqlDbType.Int);
            SqlParameter idTypeFlux = new SqlParameter("@idTypeFlux", SqlDbType.Int);
            SqlParameter idEvenement = new SqlParameter("@idEvenement", SqlDbType.Int);
            id.Value = unFlux.Id;
            libelle.Value = unFlux.Libelle;
            date.Value = unFlux.Date;
            montant.Value = unFlux.Montant;
            prelevementEff.Value = unFlux.PrelevementEff;
            idAdherent.Value = unFlux.Adherent.Id;
            idTypeFlux.Value = unFlux.TypeFlux.Id;
            idEvenement.Value = unFlux.Evenement.Id;
            cmd.Parameters.Add(id);
            cmd.Parameters.Add(libelle);
            cmd.Parameters.Add(date);
            cmd.Parameters.Add(montant);
            cmd.Parameters.Add(prelevementEff);
            cmd.Parameters.Add(idAdherent);
            cmd.Parameters.Add(idTypeFlux);
            cmd.Parameters.Add(idEvenement);

            // Execution de la requête
            cmd.ExecuteNonQuery();
        }

        public static void SupprimerFlux(Flux unFlux)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM dbo.FLUX WHERE ID_flux = @ID";

            // Création et bind des paramètres
            SqlParameter id = new SqlParameter("@ID", SqlDbType.Int);
            id.Value = unFlux.Id;
            cmd.Parameters.Add(id);

            // Execution de la requête
            cmd.ExecuteNonQuery();
        }
    }
}
