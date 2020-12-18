using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Adherent
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateDeNaissance;
        private string sexe;
        private string login;
        private string motDePasse;
        private string numTel;
        private string email;
        private string numTelParent;
        private DateTime dateMAJ;
        private bool archive;
        private Utilisateur utilisateur;
        private Classe classe;

        public Adherent(int id, string nom, string prenom, DateTime dateDeNaissance, string sexe, string login, string motDePasse, string numTel, string email, string numTelParent, DateTime dateMAJ, bool archive, Utilisateur utilisateur, Classe classe)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateDeNaissance = dateDeNaissance;
            this.Sexe = sexe;
            this.Login = login;
            this.MotDePasse = motDePasse;
            this.NumTel = numTel;
            this.Email = email;
            this.NumTelParent = numTelParent;
            this.DateMAJ = dateMAJ;
            this.Archive = archive;
            this.Utilisateur = utilisateur;
            this.Classe = classe;
        }

        // Constructeur pour afficher les données dans la page admin (on retire les champs non affichés sauf l'id)
        public Adherent(int id, string nom, string prenom, DateTime dateDeNaissance, string sexe, string numTel, string email, string numTelParent, Classe classe)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateDeNaissance = dateDeNaissance;
            this.Sexe = sexe;
            this.NumTel = numTel;
            this.Email = email;
            this.NumTelParent = numTelParent;
            this.Classe = classe;
        }

        // Constructeur pour ajouter un Adherent (pas d'id)
        public Adherent(string nom, string prenom, DateTime dateDeNaissance, string sexe, string login, string mdp, string numTel, string email, string numTelParent, Utilisateur utilisateur, Classe classe)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateDeNaissance = dateDeNaissance;
            this.Sexe = sexe;
            this.Login = login;
            this.MotDePasse = mdp;
            this.NumTel = numTel;
            this.Email = email;
            this.NumTelParent = numTelParent;
            this.Utilisateur = utilisateur;
            this.Classe = classe;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateDeNaissance { get => dateDeNaissance; set => dateDeNaissance = value; }
        public string Sexe { get => sexe; set => sexe = value; }
        public string Login { get => login; set => login = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public string NumTel { get => numTel; set => numTel = value; }
        public string Email { get => email; set => email = value; }
        public string NumTelParent { get => numTelParent; set => numTelParent = value; }
        public DateTime DateMAJ { get => dateMAJ; set => dateMAJ = value; }
        public bool Archive { get => archive; set => archive = value; }
        public Utilisateur Utilisateur { get => utilisateur; set => utilisateur = value; }
        public Classe Classe { get => classe; set => classe = value; }

        public Adherent Clone()
        {
            return (Adherent)this.MemberwiseClone();
        }
    }
}
