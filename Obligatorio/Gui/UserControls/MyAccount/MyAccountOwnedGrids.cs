using System.Windows.Forms;
using Gui.Interface;
using Domain.Exceptions;
using Domain.Logic;
using Domain.Entities;
using Gui.Forms;

namespace Gui.UserControls.MyAccount
{
    public partial class MyAccountOwnedGrids : UserControl, IController
    {
        private GridHandler gridHandler;
        private Client client;
        public MyAccountOwnedGrids(Client client)
        {
            InitializeComponent();
            this.gridHandler = new GridHandler();
            this.client = client;
            this.AccessibleName = "Mis Planos";
            this.titleTxt.Text = "Mis Planos";
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadOwnedGrids();
                return this;
            }
            catch (ExceptionController Exception)
            {
                var message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        private void LoadOwnedGrids()
        {
            this.ownedGridlist.Items.Clear();
            foreach (var grid in gridHandler.GetClientGrids(this.client))
            {
                this.ownedGridlist.Items.Add(grid);
            }
        }

        private void seeGrid(object sender, System.EventArgs e)
        {
            var selectedGrid = (Grid)this.ownedGridlist.SelectedItem;
            if (selectedGrid != null)
            {
                RedirectToGridForm(selectedGrid);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un Plano para Modificar.", "No se selecciono ningun Plano.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RedirectToGridForm(Grid selectedGrid)
        {
            GridForm gridForm = new GridForm(selectedGrid, this.ParentForm, false);
            gridForm.Show();
            this.ParentForm.Hide();
        }
    }
}
