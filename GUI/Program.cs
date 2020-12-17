using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Instruction de test
            Adherent unAdherent = new Adherent(0, "nom", "prenom", new DateTime(2001, 4, 18), "Femme", "AAAA", "123", 0598652541, "aaa@aaa.aa", 0598652542, DateTime.Now, false, new Utilisateur(0, "AAAA", "123", "User"), new Classe(0, "ClasseTest"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormModificationAdherent(unAdherent));
        }
    }
}
