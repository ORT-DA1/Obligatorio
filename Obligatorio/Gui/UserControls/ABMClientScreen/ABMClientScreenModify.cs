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
            this.titleTxt.Text = "Modificar Cliente";
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadClientsIntoList();
                return this;
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        private void LoadClientsIntoList()
        {
            // Cargar clientes en tabla.
        }
    }
}
