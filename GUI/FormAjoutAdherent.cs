﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BO;

namespace GUI
{
    public partial class FormAjoutAdherent : Form
    {
        public FormAjoutAdherent()
        {
            InitializeComponent();
        }

        virtual protected void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ajout effectué (c'est faux)");
        }

        private void FormAdherent_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Classe uneClasse in ClasseBLL.GetClasses())
                {
                    this.lsbClasse.Items.Add(uneClasse.Libelle);
                }
            }
            catch (Exception)
            {
                //Fix pour le designer je ne comprend pas pourquoi il fait la gueule
            }
        }
    }
}
