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
using Gui.Interface;
using Domain.Exceptions;

namespace Gui.UserControls.ABMDesignerScreen
{
    public partial class ABMDesignerScreenModify : UserControl, IController
    {
        private DesignerHandler handler;
        public ABMDesignerScreenModify()
        {
            InitializeComponent();
            this.handler = new DesignerHandler();
            this.AccessibleName = "Modificar";
            this.titleLbl.Text = "Modificar Diseñador";
            SetUpEnvironment();
        }
        private void SetUpEnvironment()
        {
            var selectedDesigner = (Designer)this.designerList.SelectedItem;
            if (selectedDesigner == null)
            {
                ClearFields();
                this.modifyDesigner_btn.Enabled = false;
            }
            else
            {
                LoadDataIntoFields(selectedDesigner);
                this.modifyDesigner_btn.Enabled = true;
            }
        }
        private void ClearFields()
        {
            this.userNameTxt.Clear();
            this.passwordTxt.Clear();
            this.nameTxt.Clear();
            this.surnameTxt.Clear();
        }
        private void LoadDataIntoFields(Designer selectedDesigner)
        {
            this.userNameTxt.Text = selectedDesigner.Username;
            this.passwordTxt.Text = selectedDesigner.Password;
            this.nameTxt.Text = selectedDesigner.Name;
            this.surnameTxt.Text = selectedDesigner.Surname;
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadDesignersIntoList();
                return this;
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        private void LoadDesignersIntoList()
        {
            this.designerList.Items.Clear();
            foreach (var designer in handler.GetList())
            {
                this.designerList.Items.Add(designer);
            }
        }

        private void renderModifiedView(object sender, EventArgs e)
        {
            SetUpEnvironment();
        }

        private void LeaveController(object sender, EventArgs e)
        {
            ClearFields();
            this.modifyDesigner_btn.Enabled = false;
        }

        private void modifyDesigner(object sender, EventArgs e)
        {
            var selectedDesigner = (Designer)this.designerList.SelectedItem;
            try
            {
                Designer modifiedClient = new Designer(
                    this.userNameTxt.Text,
                    this.passwordTxt.Text,
                    this.nameTxt.Text,
                    this.surnameTxt.Text,
                    selectedDesigner.RegistrationDate,
                    selectedDesigner.LastAccess);

                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea Modificar este Diseñador?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Modify(selectedDesigner, modifiedClient);
                    MessageBox.Show("El Diseñador ha sido actualizado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDesignersIntoList();
                    SetUpEnvironment();
                }
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
