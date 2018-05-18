using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gui.Interface;
using Domain.Entities;
using Domain.Exceptions;

namespace Gui.UserControls.Configuration
{
    public partial class ConfigurationPrice : UserControl, IController
    {
        public ConfigurationPrice()
        {
            InitializeComponent();

            this.AccessibleName = "Precios";
            this.titleTxt.Text = "Configuracion de Precios";
        }
        public UserControl GetUserController()
        {
            return this;
        }

        private void savePriceConfiguration(object sender, EventArgs e)
        {
            try
            {
                ValidCostPrice();
                if (elementList.SelectedItem.ToString().Equals("Pared"))
                {
                    Wall.CostPriceMeterWall = new Tuple<int, int>(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));

                }
                else if (elementList.SelectedItem.ToString().Equals("Viga"))
                {
                    WallBeam.CostPriceWallBeam = new Tuple<int, int>(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));

                }
                else if (elementList.SelectedItem.ToString().Equals("Ventana"))
                {
                    Window.CostPriceWindow = new Tuple<int, int>(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));

                }
                else if (elementList.SelectedItem.ToString().Equals("Puerta"))
                {
                    Door.CostPriceDoor = new Tuple<int, int>(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));

                }
                
                MessageBox.Show("Se han actualizado los precios del sistema.", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (ExceptionController Exception)
            {
                string message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ValidCostPrice()
        {
            int cost;
            int price;

            if (!int.TryParse(this.CostTextBox.Text, out cost))
            {
                throw new ExceptionController(ExceptionMessage.COST_INVALID);
            }

            if (!int.TryParse(this.PriceTextBox.Text, out price))
            {
                throw new ExceptionController(ExceptionMessage.PRICE_INVALID);
            }
        }


        private void leaveComponent(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            this.elementList.SelectedIndex = -1;
            this.PriceTextBox.Clear();
            this.CostTextBox.Clear();
        }

        private void setUpEnvironment(object sender, EventArgs e)
        {
            if (elementList.SelectedItem != null)
            {
                if (elementList.SelectedItem.ToString().Equals("Pared"))
                {
                    CostTextBox.Text = Wall.CostPriceMeterWall.Item1.ToString();
                    PriceTextBox.Text = Wall.CostPriceMeterWall.Item2.ToString();
                }
                else if (elementList.SelectedItem.ToString().Equals("Viga"))
                {
                    CostTextBox.Text = WallBeam.CostPriceWallBeam.Item1.ToString();
                    PriceTextBox.Text = WallBeam.CostPriceWallBeam.Item2.ToString();
                }
                else if (elementList.SelectedItem.ToString().Equals("Ventana"))
                {
                    CostTextBox.Text = Window.CostPriceWindow.Item1.ToString();
                    PriceTextBox.Text = Window.CostPriceWindow.Item2.ToString();
                }
                else if (elementList.SelectedItem.ToString().Equals("Puerta"))
                {
                    CostTextBox.Text = Door.CostPriceDoor.Item1.ToString();
                    PriceTextBox.Text = Door.CostPriceDoor.Item2.ToString();
                }
            }
        }
    }
}
