using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class AdherentMin
    {
        private string nom;
        private string prenom;

        public AdherentMin(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
