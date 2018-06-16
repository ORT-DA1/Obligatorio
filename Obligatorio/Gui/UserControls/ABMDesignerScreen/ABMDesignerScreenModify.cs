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
        private Designer _selectedDesigner;
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
            _selectedDesigner = (Designer)this.designerList.SelectedItem;
            if (_selectedDesigner == null)
            {
                ClearFields();
                this.modifyDesigner_btn.Enabled = false;
            }
            else
            {
                LoadDataIntoFields();
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
        private void LoadDataIntoFields()
        {
            this.userNameTxt.Text = _selectedDesigner.Username;
            this.passwordTxt.Text = _selectedDesigner.Password;
            this.nameTxt.Text = _selectedDesigner.Name;
            this.surnameTxt.Text = _selectedDesigner.Surname;
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
            this._selectedDesigner = (Designer)this.designerList.SelectedItem;
            try
            {
                //this._selectedDesigner.Username = this.userNameTxt.Text;
                //this._selectedDesigner.Password = this.passwordTxt.Text;
                //this._selectedDesigner.Name = this.nameTxt.Text;
                //this._selectedDesigner.Surname = this.surnameTxt.Text;

                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea Modificar este Diseñador?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Modify(_selectedDesigner);
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
