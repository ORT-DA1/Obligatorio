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
                LoadSignedGrids();
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
            foreach (var grid in gridHandler.GetClientNotSignedGrids(this.client))
            {
                this.ownedGridlist.Items.Add(grid);
            }
        }
        private void LoadSignedGrids()
        {
            this.signedGrids_list.Items.Clear();
            foreach (var grid in gridHandler.GetClientSignedGrids(this.client))
            {
                this.signedGrids_list.Items.Add(grid);
            }
        }

        private void SeeGridInProgress(object sender, System.EventArgs e)
        {
            this.signedGrids_list.ClearSelected();
            var selectedGrid = (Grid)this.ownedGridlist.SelectedItem;
            if (selectedGrid != null)
            {
                RedirectToGridForm(selectedGrid);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un Plano.", "No se selecciono ningun Plano.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RedirectToGridForm(Grid selectedGrid)
        {
            GridForm gridForm = new GridForm(selectedGrid, this.ParentForm, false, this.client);
            gridForm.Show();
            this.ParentForm.Hide();
        }

        private void SeeSignedGrids(object sender, System.EventArgs e)
        {
            this.ownedGridlist.ClearSelected();

            var selectedGrid = (Grid)this.signedGrids_list.SelectedItem;
            if (selectedGrid != null)
            {
                RedirectToGridForm(selectedGrid);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione un Plano.", "No se selecciono ningun Plano.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
