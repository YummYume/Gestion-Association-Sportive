using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;

namespace GUI
{
    public partial class FormStatistiques : Form
    {
        private Utilisateur leUtilisateur;

        public FormStatistiques(Utilisateur unUtilisateur)
        {
            InitializeComponent();
            leUtilisateur = unUtilisateur;
        }

        private void FormStatistiques_Load(object sender, EventArgs e)
        {
            lblNombreAdherents.Text = AdherentBLL.GetNombreAdherents().ToString();
            lblFilles.Text = AdherentBLL.GetNombreAdherentsGenre("Femme").ToString();
            lblGarcons.Text = AdherentBLL.GetNombreAdherentsGenre("Homme").ToString();

            dtgDdn.Columns.Add("adn", "Année de Naissance");
            dtgDdn.Columns.Add("effectif", "Effectif");
            foreach (List<string> uneListe in AdherentBLL.GetNombreAdherentsDdn())
            {
                dtgDdn.Rows.Add(uneListe[0], uneListe[1]);
            }

            dtgEvenements.Columns.Add("nomEvenement", "Evenement");
            dtgEvenements.Columns.Add("inscrit", "Nombre Adhérents");
            foreach (List<string> uneListe in EvenementBLL.GetNombreAdherentsEvenements())
            {
                dtgEvenements.Rows.Add(uneListe[0], uneListe[1]);
            }

            dtgAdherents.Columns.Add("nomAdherent", "Adhérent");
            dtgAdherents.Columns.Add("nombreEvenements", "Inscriptions");
            foreach (List<string> uneListe in AdherentBLL.GetNombreEvenementsAdherents())
            {
                dtgAdherents.Rows.Add(uneListe[0], uneListe[1]);
            }
        }
    }
}