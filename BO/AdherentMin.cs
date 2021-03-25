using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class AdherentMin
    {
        private int id;
        private string nom;
        private string prenom;

        public AdherentMin(int id)
        {
            this.Id = id;
        }

        public AdherentMin(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Id { get => id; set => id = value; }
    }
}
