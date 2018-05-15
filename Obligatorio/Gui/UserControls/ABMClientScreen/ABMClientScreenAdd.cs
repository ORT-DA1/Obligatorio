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

namespace Gui.UserControls.ABMClientScreen
{
    public partial class ABMClientScreenAdd : UserControl, IController
    {
        public ABMClientScreenAdd()
        {
            InitializeComponent();
            this.AccessibleName = "Agregar";
            this.client_title.Text = "Agregar Cliente";
        }

        public UserControl GetUserController()
        {
            return this;
        }
    }
}
