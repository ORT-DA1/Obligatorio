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
using Domain.Repositories;
using Gui.Interface;
using Domain.Exceptions;

namespace Gui.UserControls.ABMArchitectScreen
{
    public partial class ABMArchitectScreenModify : UserControl, IController
    {
        private ArchitectHandler handler;
        private UserRepository userRepository;
        private Architect _selectedArchitect;
        public ABMArchitectScreenModify()
        {
            InitializeComponent();
            this.handler = new ArchitectHandler();
            this.userRepository = new UserRepository();
            this.AccessibleName = "Modificar";
            this.titleLbl.Text = "Modificar Arquitecto";
            SetUpEnvironment();

        }
        private void SetUpEnvironment()
        {
            _selectedArchitect = (Architect)this.architectList.SelectedItem;
            if (_selectedArchitect == null)
            {
                ClearFields();
                this.modifyArchitect_btn.Enabled = false;
            }
            else
            {
                LoadDataIntoFields();
                this.modifyArchitect_btn.Enabled = true;
            }
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadDataIntoList();
                return this;
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
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
            this.userNameTxt.Text = _selectedArchitect.Username;
            this.passwordTxt.Text = _selectedArchitect.Password;
            this.nameTxt.Text = _selectedArchitect.Name;
            this.surnameTxt.Text = _selectedArchitect.Surname;
        }
        private void LoadDataIntoList()
        {
            this.architectList.Items.Clear();
            foreach (var architect in handler.GetList())
            {
                this.architectList.Items.Add(architect);
            }
        }
        private void modifyArchitect(object sender, EventArgs e)
        {
            try
            {
                ValidateUser();
                SetFieldValues();

                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea Modificar este Arquitecto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Modify(_selectedArchitect);
                    MessageBox.Show("El Arquitecto ha sido actualizado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataIntoList();
                    SetUpEnvironment();
                }
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDataIntoList();
                SetUpEnvironment();
            }
        }
        private void ValidateUser()
        {
            if (this.userNameTxt.Text != _selectedArchitect.Username)
            {
                this.userRepository.UserExist(this.userNameTxt.Text);
            }
        }
        private void SetFieldValues()
        {
            this._selectedArchitect.Username = this.userNameTxt.Text;
            this._selectedArchitect.Password = this.passwordTxt.Text;
            this._selectedArchitect.Name = this.nameTxt.Text;
            this._selectedArchitect.Surname = this.surnameTxt.Text;
        }
        private void renderModifiedView(object sender, EventArgs e)
        {
            SetUpEnvironment();
        }

        private void LeaveController(object sender, EventArgs e)
        {
            ClearFields();
            this.modifyArchitect_btn.Enabled = false;
        }
    }
}
