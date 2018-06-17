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
                /*Client c = new Client
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

                Administrator a = new Administrator
                {
                    Username = "administrator",
                    Password = "administrator",
                    Name = "Agustina",
                    Surname = "Saul",
                    RegistrationDate = (DateTime.Now),
                    LastAccess = (DateTime.Now)
                };
                context.Administrators.Add(a);

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

                context.SaveChanges();*/
            }
                    
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
