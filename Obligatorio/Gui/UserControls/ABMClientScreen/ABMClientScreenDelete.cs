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
using Domain.Exceptions;

namespace Gui.UserControls.ABMClientScreen
{
    public partial class ABMClientScreenDelete : UserControl, IController
    {
        public ABMClientScreenDelete()
        {
            InitializeComponent();
            this.AccessibleName = "Borrar";
            this.AccessibleDescription = "Borrar Cliente";
        }

        public UserControl GetUserController()
        {
            try
            {
                LoadClients();
                return this;
            }
            catch (ExceptionController)
            {
                throw new ExceptionController(ExceptionMessage.GRID_INVALID_HEIGHT_ABOVE); //Agregar Exception
            }
        }

        private void LoadClients()
        {
            //Poner todos los clientes en una lista.
        }
    }
}
