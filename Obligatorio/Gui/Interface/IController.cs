using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.Interface
{
    public interface IController
    {
        UserControl GetUserController();
    }
}
