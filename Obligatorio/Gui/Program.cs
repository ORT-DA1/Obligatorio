using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gui.Forms;
using Domain.Repositories;
using Domain;

namespace Gui
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                if (!context.Administrators.Any())
                {
                    Administrator admin = new Administrator("admin", "admin", "Joaquin", "Touris", new DateTime(2018, 05, 05), new DateTime(2018, 05, 05));
                    context.Administrators.Add(admin);
                    context.SaveChanges();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
