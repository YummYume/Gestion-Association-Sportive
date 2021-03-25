using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Flux
    {
        private int id;
        private string libelle;
        private DateTime date;
        private float montant;
        private bool prelevementEff;
        private Adherent adherent;
        private TypeFlux typeFlux;
        private Evenement evenement;
        private Budget budget;

        public Flux(int id)
        {
            this.Id = id;
        }

        public Flux(int id, string libelle, DateTime date, float montant, bool prelevementEff, Adherent adherent, TypeFlux typeFlux, Evenement evenement, Budget budget)
        {
            this.id = id;
            this.libelle = libelle;
            this.date = date;
            this.montant = montant;
            this.prelevementEff = prelevementEff;
            this.adherent = adherent;
            this.typeFlux = typeFlux;
            this.evenement = evenement;
            this.budget = budget;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime Date { get => date; set => date = value; }
        public float Montant { get => montant; set => montant = value; }
        public bool PrelevementEff { get => prelevementEff; set => prelevementEff = value; }
        public Adherent Adherent { get => adherent; set => adherent = value; }
        public TypeFlux TypeFlux { get => typeFlux; set => typeFlux = value; }
        public Evenement Evenement { get => evenement; set => evenement = value; }
        public Budget Budget { get => budget; set => budget = value; }
    }
}
