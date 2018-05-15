using System;
using System.Windows.Forms;
using Domain.Exceptions;
using Gui.Interface;

namespace Gui.UserControls.ABMClientScreen
{
    public partial class ABMClientScreenModify : UserControl, IController
    {
        public ABMClientScreenModify()
        {
            InitializeComponent();
            this.AccessibleName = "Modificar";
            //this.AccessibleDescription = "Modificar Cliente";
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadClients();
                return this;
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        private void LoadClients()
        {
            // Cargar clientes en tabla.
        }
    }
}
