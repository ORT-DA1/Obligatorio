using System;
using System.Windows.Forms;
using Gui.Interface;
using Domain.Logic;
using Domain.Entities;
using Domain.Exceptions;

namespace Gui.UserControls.ABMDesignerScreen
{
    public partial class ABMDesignerScreenDelete : UserControl, IController
    {
        private DesignerHandler handler;
        public ABMDesignerScreenDelete()
        {
            InitializeComponent();
            this.handler = new DesignerHandler();
            this.AccessibleName = "Borrar";
            this.titleTxt.Text = "Borrar Diseñador";
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadDesignersIntoListo();
                return this;
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private void LoadDesignersIntoListo()
        {
            this.designerList.Items.Clear();
            foreach (Designer designer in handler.GetList())
            {
                designerList.Items.Add(designer);
            }
        }
        private void deleteDesigner(object sender, EventArgs e)
        {
            var selectedDesigner = designerList.SelectedItem;
            if (selectedDesigner != null)
            {
                Delete((Designer)selectedDesigner);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione el Diseñador que desea borrar.", "No se selecciono ningun usuaruio.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Delete(Designer designerToDelete)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea borrar este Diseñador?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Delete(designerToDelete);
                    LoadDesignersIntoListo();
                }
            }
            catch (ExceptionController)
            {
                String message = "Ya no quedan Diseñadores registrados en el sistema.";
                MessageBox.Show(message, "Sin Diseñadores.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
