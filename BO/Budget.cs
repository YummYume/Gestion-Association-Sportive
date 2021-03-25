using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Budget
    {
        private int id;
        private string libelle;
        private float montantInitial;
        private DateTime dateCreation;

        public Budget(int id)
        {
            this.Id = id;
        }

        public Budget(int id, string libelle, float montantInitial, DateTime dateCreation)
        {
            this.id = id;
            this.libelle = libelle;
            this.montantInitial = montantInitial;
            this.dateCreation = dateCreation;
        }

        public Budget(string libelle, float montantInitial, DateTime dateCreation)
        {
            this.libelle = libelle;
            this.montantInitial = montantInitial;
            this.dateCreation = dateCreation;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public float MontantInitial { get => montantInitial; set => montantInitial = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
    }
}
