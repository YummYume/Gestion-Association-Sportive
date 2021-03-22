using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class FluxBLL
    {
        private static FluxBLL unFluxBLL;

        public static FluxBLL GetFluxBLL()
        {
            if (FluxBLL.unFluxBLL == null)
            {
                FluxBLL.unFluxBLL = new FluxBLL();
            }
            return FluxBLL.unFluxBLL;
        }

        public static List<Flux> GetFluxDebit(string year, Adherent adherent = null, Budget budget = null)
        {
            return FluxDAO.GetFlux(new TypeFlux(1, "Débit"), year, adherent, budget);
        }

        public static List<Flux> GetFluxCredit(string year, Adherent adherent = null, Budget budget = null)
        {
            return FluxDAO.GetFlux(new TypeFlux(2, "Crédit"), year, adherent, budget);
        }

        public static List<Flux> GetFluxYear(TypeFlux typeFlux, string year)
        {
            return FluxDAO.GetFlux(typeFlux, year);
        }

        public static List<Flux> GetFluxStudentYear(TypeFlux typeFlux, string year, Adherent adherent)
        {
            return FluxDAO.GetFlux(typeFlux, year, adherent);
        }

        public static List<Flux> GetFluxStudent(TypeFlux typeFlux, Adherent adherent)
        {
            return FluxDAO.GetFlux(typeFlux, null, adherent);
        }

        public static List<Flux> GetFlux(TypeFlux typeFlux)
        {
            return FluxDAO.GetFlux(typeFlux);
        }

        public static void AddFlux(Flux unFlux)
        {
            FluxDAO.AddFlux(unFlux);
        }

        public static void ModifierFlux(Flux unFlux)
        {
            FluxDAO.ModifierFlux(unFlux);
        }

        public static void SupprimerFlux(FluxMin unFlux)
        {
            FluxDAO.SupprimerFlux(unFlux);
        }

        public static List<FluxMin> GetBaseFluxInfo(TypeFlux typeFlux, string year = null)
        {
            return FluxDAO.GetBaseFluxInfo(typeFlux, year);
        }
    }
}
