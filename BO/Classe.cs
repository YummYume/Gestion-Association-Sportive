using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Classe
    {
        private int id;
        private string libelle;

        public Classe(int id)
        {
            this.Id = id;
        }

        public Classe(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
