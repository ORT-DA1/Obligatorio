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
                #region Administrator
                if (!context.Administrators.Any())
                {
                    Administrator admin = new Administrator("admin", "admin", "Joaquin", "Touris", new DateTime(2018, 05, 05), new DateTime(2018, 05, 05));
                    context.Administrators.Add(admin);
                    context.SaveChanges();
                }
                #endregion

                #region Default Costs and Prices
                if (!context.PricesAndCosts.Any())
                {                
                    PriceAndCost priceWall = new PriceAndCost
                    {
                        Cost = 50,
                        Price = 100,
                        PriceAndCostId = 1
                    };
                    PriceAndCost priceWallBeam = new PriceAndCost
                    {
                        Cost = 50,
                        Price = 100,
                        PriceAndCostId = 2
                    };
                    PriceAndCost priceWindow = new PriceAndCost
                    {
                        Cost = 50,
                        Price = 75,
                        PriceAndCostId = 3
                    };
                    PriceAndCost priceDoor = new PriceAndCost
                    {
                        Cost = 50,
                        Price = 100,
                        PriceAndCostId = 4
                    };
                    PriceAndCost priceDecorativeColumn = new PriceAndCost
                    {
                        Cost = 25,
                        Price = 50,
                        PriceAndCostId = 5
                    };

                    context.PricesAndCosts.Add(priceWall);
                    context.PricesAndCosts.Add(priceWallBeam);
                    context.PricesAndCosts.Add(priceWindow);
                    context.PricesAndCosts.Add(priceDoor);
                    context.PricesAndCosts.Add(priceDecorativeColumn);
                    context.SaveChanges();
                }
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
