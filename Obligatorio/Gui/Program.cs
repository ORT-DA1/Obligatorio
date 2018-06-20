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
                if (!context.Clients.Any())
                {
                    Client c = new Client
                    {
                        Username = "client",
                        Password = "client",
                        Name = "Ana",
                        Surname = "Rodriguez",
                        Address = "Cuareim 1221",
                        RegistrationDate = (DateTime.Now),
                        LastAccess = (DateTime.Now),
                        Phone = "093535353"
                    };
                    context.Clients.Add(c);
                    context.SaveChanges();
                }
                if (!context.Designers.Any())
                {
                    Designer d = new Designer
                    {
                        Username = "designer",
                        Password = "designer",
                        Name = "Pablo",
                        Surname = "Pereira",
                        RegistrationDate = (DateTime.Now),
                        LastAccess = (DateTime.Now)
                    };
                    context.Designers.Add(d);
                    context.SaveChanges();
                }
                if (!context.Architects.Any())
                {
                    Architect ar = new Architect
                    {
                        Username = "architect",
                        Password = "architect",
                        Name = "Joaquin",
                        Surname = "Touris",
                        RegistrationDate = (DateTime.Now),
                        LastAccess = (DateTime.Now)
                    };
                    context.Architects.Add(ar);
                    context.SaveChanges();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
