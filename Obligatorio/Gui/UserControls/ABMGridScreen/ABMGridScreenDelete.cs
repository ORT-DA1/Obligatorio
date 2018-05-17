using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Logic;
using Domain.Entities;
using Domain.Exceptions;
using Gui.Interface;

namespace Gui.UserControls.ABMGridScreen
{
    public partial class ABMGridScreenDelete : UserControl, IController
    {
        private GridHandler handler;
        public ABMGridScreenDelete()
        {
            InitializeComponent();
            this.handler = new GridHandler();
            this.AccessibleName = "Borrar";
            this.titleTxt.Text = "Borrar Plano";
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
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        private void LoadGrids()
        {
            this.gridList.Items.Clear();
            foreach (var grid in handler.GetList())
            {
                this.gridList.Items.Add(grid);
            }
        }

        private void deleteGrid(object sender, EventArgs e)
        {
            var selectedGrid = (Grid)this.gridList.SelectedItem;
            if (selectedGrid != null)
            {
                Delete(selectedGrid);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione el Plano que desea borrar.", "No se selecciono ningun Plano.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Delete(Grid selectedGrid)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea borrar este Plano?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Delete(selectedGrid);
                    LoadGrids();
                }
            }
            catch (ExceptionController)
            {
                String message = "Ya no quedan Planos registrados en el sistema.";
                MessageBox.Show(message, "Sin Planos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
