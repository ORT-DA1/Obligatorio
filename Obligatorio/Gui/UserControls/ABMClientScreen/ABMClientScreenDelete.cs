using System;
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
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }

        private void LoadClients()
        {
            //Poner todos los clientes en una lista.
        }
    }
}
