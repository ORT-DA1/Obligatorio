using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.UserControls.ABMDesignerScreen
{
    public partial class ABMDesignerScreenModify : UserControl
    {
        public ABMDesignerScreenModify()
        {
            InitializeComponent();
            this.AccessibleName = "Modificar";
            this.AccessibleDescription = "Modificar Diseñador";
        }
    }
}
