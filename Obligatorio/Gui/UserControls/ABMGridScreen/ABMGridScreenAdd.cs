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
using Gui.Forms;

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
            GridForm gridForm = new GridForm(grid, this.ParentForm);
            gridForm.Show();
            ClearFields();
            this.ParentForm.Hide();
            gridForm.FormClosing += quit;
        }
        private void ClearFields()
        {
            this.gridNameTxt.Clear();
            this.clientList.SelectedIndex = -1;
            this.widthTxt.Clear();
            this.heightTxt.Clear();
        }

        private void quit(object sender, EventArgs e)
        {
            //this.Parent.Show();
        }
    }
}

