using System;
using System.Windows.Forms;
using Gui.Interface;
using Domain.Exceptions;
using Domain.Logic;
using Domain.Entities;

namespace Gui.UserControls.ABMClientScreen
{
    public partial class ABMClientScreenDelete : UserControl, IController
    {
        private ClientHandler handler;
        public ABMClientScreenDelete()
        {
            InitializeComponent();
            this.handler = new ClientHandler();
            this.AccessibleName = "Borrar";
            this.titleTxt.Text = "Borrar Cliente";
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
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void LoadClientsIntoList()
        {
            this.clientList.Items.Clear();
            foreach (Client client in handler.GetList())
            {
                this.clientList.Items.Add(client);
            }
        }

        private void deleteClient(object sender, EventArgs e)
        {
            var selectedClient = clientList.SelectedItem;
            if (selectedClient != null)
            {
                Delete((Client)selectedClient);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione el Cliente  que desea borrar.", "No se selecciono ningun usuaruio.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Delete(Client clientToDelete)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea borrar este Cliente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Delete(clientToDelete);
                    LoadClientsIntoList();
                }
            }
            catch (ExceptionController)
            {
                String message = "Ya no quedan Clientes registrados en el sistema.";
                MessageBox.Show(message, "Sin Clientes.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
