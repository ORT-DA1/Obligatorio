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
using Domain.Logic;
using Domain.Repositories;

namespace Gui.UserControls.Configuration
{
    public partial class ConfigurationPrice : UserControl, IController
    {

        public PriceAndCostHandler priceAndCostHandler;
        public GridRepository gridRepository;
        public ConfigurationPrice()
        {
            this.gridRepository = new GridRepository();
            priceAndCostHandler = new PriceAndCostHandler(gridRepository);
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
                    priceAndCostHandler.WallModifyPriceCost(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));   
                }
                else if (elementList.SelectedItem.ToString().Equals("Viga"))
                {
                    priceAndCostHandler.WallBeamColumnModifyPriceCost(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));
                }
                else if (elementList.SelectedItem.ToString().Equals("Ventana"))
                {
                    priceAndCostHandler.WindowModifyPriceCost(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));
                }
                else if (elementList.SelectedItem.ToString().Equals("Puerta"))
                {
                    priceAndCostHandler.DoorModifyPriceCost(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));
                }
                else if (elementList.SelectedItem.ToString().Equals("Columna Decorativa"))
                {
                    priceAndCostHandler.DecorativeColumnModifyPriceCost(int.Parse(CostTextBox.Text), int.Parse(PriceTextBox.Text));
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
                    CostTextBox.Text = priceAndCostHandler.GetWallCost().ToString();
                    PriceTextBox.Text = priceAndCostHandler.GetWallPrice().ToString();
                }
                else if (elementList.SelectedItem.ToString().Equals("Viga"))
                {
                    CostTextBox.Text = priceAndCostHandler.GetWallBeamCost().ToString();
                    PriceTextBox.Text = priceAndCostHandler.GetWallBeamPrice().ToString();
                }
                else if (elementList.SelectedItem.ToString().Equals("Ventana"))
                {
                    CostTextBox.Text = priceAndCostHandler.GetWindowCost().ToString();
                    PriceTextBox.Text = priceAndCostHandler.GetWindowPrice().ToString();
                }
                else if (elementList.SelectedItem.ToString().Equals("Puerta"))
                {
                    CostTextBox.Text = priceAndCostHandler.GetDoorCost().ToString();
                    PriceTextBox.Text = priceAndCostHandler.GetDoorPrice().ToString();
                }
            }
        }
    }
}
