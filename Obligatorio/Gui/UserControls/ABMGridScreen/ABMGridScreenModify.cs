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
using Domain.Repositories;

namespace Gui.UserControls.ABMGridScreen
{
    public partial class ABMGridScreenModify : UserControl, IController
    {
        private GridHandler gridHandler;
        private User _user;
        public ABMGridScreenModify(User user)
        {
            InitializeComponent();
            this._user = user;
            this.gridHandler = new GridHandler();
            this.AccessibleName = "Modificar";
            this.titleTxt.Text = "Modificar Plano";
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadGrids();
                return this;
            }
            catch (ExceptionController Exception)
            {
                var message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        private void LoadGrids()
        {
            this.gridList.Items.Clear();
            foreach (var grid in gridHandler.GetList())
            {
                this.gridList.Items.Add(grid);
            }
        }

        private void modifyGrid(object sender, EventArgs e)
        {
            var selectedGrid = (Grid)this.gridList.SelectedItem;
            if (selectedGrid != null)
            {
                RedirectToModifyGridForm(selectedGrid);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un Plano para Modificar.", "No se selecciono ningun Plano.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RedirectToModifyGridForm(Grid selectedGrid)
        {
            GridForm gridForm = new GridForm(selectedGrid, this.ParentForm, true, this._user);
            gridForm.Show();
            this.ParentForm.Hide();
        }
    }
}
