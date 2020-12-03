using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Utilisateur
    {
        private int id;
        private string login;
        private string mdp;
        private string droit;

        public Utilisateur(int id, string login, string mdp, string droit)
        {
            this.Id = id;
            this.Login = login;
            this.Mdp = mdp;
            this.Droit = droit;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Droit { get => droit; set => droit = value; }
    }
}
