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
        }
    }
}
