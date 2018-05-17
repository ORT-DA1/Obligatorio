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
using Domain.Logic;
using Domain.Entities;

namespace Gui.UserControls.ABMGridScreen
{
    public partial class ABMGridScreenAdd : UserControl, IController
    {
        private ClientHandler clientHandler;
        private GridHandler gridHandler;
        public ABMGridScreenAdd()
        {
            InitializeComponent();
            this.clientHandler = new ClientHandler();
            this.gridHandler = new GridHandler();
            this.AccessibleName = "Crear";
            this.titleTxt.Text = "Crear Plano";
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
                String message = "No existen Clientes para asocioar a un nuevo plano.";
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        private void LoadClients()
        {
            foreach (var client in clientHandler.GetList())
            {
                this.clientList.Items.Add(client);
            }
        }

        private void createGrid(object sender, EventArgs e)
        {
            try
            {
                Grid newGrid = fetchValues();
                gridHandler.Add(newGrid);
            }
            catch (ExceptionController Exception)
            {
                string message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Grid fetchValues()
        {
            var selectedClient = (Client)this.clientList.SelectedItem;
            return new Grid(
                this.gridNameTxt.Text,
                selectedClient,
                int.Parse(this.widthTxt.Text),
                int.Parse(this.heightTxt.Text)
             );
        }
    }
}
