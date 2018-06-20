using System;
using System.Windows.Forms;
using Gui.Interface;
using Domain.Exceptions;
using Domain.Logic;
using Domain.Entities;
using Gui.Forms;

namespace Gui.UserControls.ABMGridScreen
{
    public partial class CreateElement : UserControl, IController
    {
        private ClientHandler clientHandler;
        private GridHandler gridHandler;

        public CreateElement()
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
            this.clientList.Items.Clear();
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
                gridHandler.Add(newGrid, (Client)this.clientList.SelectedItem);
                Redirect(newGrid);
            }
            catch (ExceptionController Exception)
            {
                string message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Grid fetchValues()
        {
            ValidWidthHeight();
            var selectedClient = (Client)this.clientList.SelectedItem;
            return new Grid(
                this.gridNameTxt.Text,
                selectedClient,
                int.Parse(this.widthTxt.Text),
                int.Parse(this.heightTxt.Text)
             );
        }
        private void ValidWidthHeight()
        {
            int width;
            int height;

            if (!int.TryParse(this.heightTxt.Text, out height))
            {
                throw new ExceptionController(ExceptionMessage.GRID_INVALID_HEIGHT_FORMAT);
            }

            if (!int.TryParse(this.widthTxt.Text, out width))
            {
                throw new ExceptionController(ExceptionMessage.GRID_INVALID_WIDTH_FORMAT);
            }
        }
        private void Redirect(Grid grid)
        {
            GridForm gridForm = new GridForm(grid, this.ParentForm, true);
            gridForm.Show();
            ClearFields();
            this.ParentForm.Hide();
        }
        private void ClearFields()
        {
            this.gridNameTxt.Clear();
            this.clientList.SelectedIndex = -1;
            this.widthTxt.Clear();
            this.heightTxt.Clear();
        }
    }
}

