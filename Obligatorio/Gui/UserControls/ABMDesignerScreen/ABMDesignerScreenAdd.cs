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

namespace Gui.UserControls.ABMDesignerScreen
{
    public partial class ABMDesignerScreenAdd : UserControl, IController
    {
        public ABMDesignerScreenAdd()
        {
            InitializeComponent();
            this.AccessibleName = "Agregar";
            this.AccessibleDescription = "Agregar Diseñador";
        }

        public UserControl GetUserController()
        {
            return this;
        }
    }
}
