using System;
using System.Windows.Forms;
using Domain.Exceptions;
using Gui.Interface;
using Domain.Logic;
using Domain.Entities;
using System.Collections.Generic;

namespace Gui.UserControls.ABMClientScreen
{
    public partial class ABMClientScreenModify : UserControl, IController
    {
        private ClientHandler handler;
        private Client _selectedClient;
        public ABMClientScreenModify()
        {
            InitializeComponent();
            this.handler = new ClientHandler();
            
            this.AccessibleName = "Modificar";
            this.titleTxt.Text = "Modificar Cliente";
            SetUpEnvironment();
        }
        private void SetUpEnvironment()
        {
            this._selectedClient = (Client)this.clientList.SelectedItem;
            //var selectedClient = (Client)this.clientList.SelectedItem;
            if (_selectedClient == null)
            {
                ClearFields();
                this.modifyClient_btn.Enabled = false;
            }
            else
            {
                LoadDataIntoFields(_selectedClient);
                this.modifyClient_btn.Enabled = true;
            }
        }
        private void ClearFields()
        {
            this.userNameTxt.Clear();
            this.passwordTxt.Clear();
            this.nameTxt.Clear();
            this.surnameTxt.Clear();
            this.idTxt.Clear();
            this.phoneTxt.Clear();
            this.addressTxt.Clear();
        }
        private void LoadDataIntoFields(Client selectedClient)
        {
            this.userNameTxt.Text = selectedClient.Username;
            this.passwordTxt.Text = selectedClient.Password;
            this.nameTxt.Text = selectedClient.Name;
            this.surnameTxt.Text = selectedClient.Surname;
            this.idTxt.Text = selectedClient.IdentityCard;
            this.phoneTxt.Text = selectedClient.Phone;
            this.addressTxt.Text = selectedClient.Address;
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadClientsIntoList();
                return this;
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        private void LoadClientsIntoList()
        {
            this.clientList.Items.Clear();
            foreach (Client client in handler.GetList())
            {
                this.clientList.Items.Add(client);
            }
        }
        private void renderModifyView(object sender, EventArgs e)
        {
            SetUpEnvironment();
        }
        private void LeaveController(object sender, EventArgs e)
        {
            ClearFields();
            this.modifyClient_btn.Enabled = false;
        }
        private void modifyClient(object sender, EventArgs e)
        {
            _selectedClient = (Client)this.clientList.SelectedItem;
            try
            {
                this._selectedClient.Username = this.userNameTxt.Text;
                this._selectedClient.Password = this.passwordTxt.Text;
                this._selectedClient.Name = this.nameTxt.Text;
                this._selectedClient.Surname = this.surnameTxt.Text;
                this._selectedClient.IdentityCard = this.idTxt.Text;
                this._selectedClient.Phone = this.phoneTxt.Text;
                this._selectedClient.Address = this.addressTxt.Text;

                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea Modificar este Cliente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Modify(this._selectedClient);
                    MessageBox.Show("El Cliente ha sido actualizado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClientsIntoList();
                    SetUpEnvironment();
                }
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}