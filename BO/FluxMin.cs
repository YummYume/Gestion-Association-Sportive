using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class FluxMin
    {
        private int id;
        private string libelle;
        private DateTime date;
        private string montant;
        private string budget;

        public FluxMin(int id)
        {
            this.Id = id;
        }

        public FluxMin(int id, string libelle, DateTime date, string montant, string budget)
        {
            this.id = id;
            this.libelle = libelle;
            this.date = date;
            this.montant = montant + "€";
            this.budget = budget;
        }

        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Montant { get => montant; set => montant = value + "€"; }
        public string Budget { get => budget; set => budget = value; }
        public int Id { get => id; set => id = value; }
    }
}
