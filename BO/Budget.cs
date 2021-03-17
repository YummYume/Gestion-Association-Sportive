﻿using System;
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
        private int montantInitial;
        private DateTime dateCreation;

        public Budget(int id, string libelle, int montantInitial, DateTime dateCreation)
        {
            this.id = id;
            this.libelle = libelle;
            this.montantInitial = montantInitial;
            this.dateCreation = dateCreation;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public int MontantInitial { get => montantInitial; set => montantInitial = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
    }
}
