using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Evenement
    {
        private int id;
        private string libelle;
        private DateTime date;
        private string lieu;

        public Evenement(int id)
        {
            this.Id = id;
        }

        public Evenement(int id, string libelle, DateTime date, string lieu)
        {
            this.id = id;
            this.libelle = libelle;
            this.date = date;
            this.lieu = lieu;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Lieu { get => lieu; set => lieu = value; }
    }
}
