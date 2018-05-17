using System;
using System.Windows.Forms;
using Gui.Interface;
using Domain.Entities;
using Domain.Logic;
using Domain.Exceptions;

namespace Gui.UserControls.MyAccount
{
    public partial class MyAccountPersonalInformation : UserControl, IController
    {
        private Client client;
        private ClientHandler handler;
        public MyAccountPersonalInformation(Client client)
        {
            InitializeComponent();
            this.client = client;
            this.handler = new ClientHandler();
            this.AccessibleName = "Datos Personales";
            this.titleTxt.Text = "Mis Datos Personales";
        }
        public UserControl GetUserController()
        {
            LoadInformation();
            return this;
        }
        private void LoadInformation()
        {
            this.userNameTxt.Text = client.Username;
            this.passwordTxt.Text = client.Password;
            this.nameTxt.Text = client.Name;
            this.surnameTxt.Text = client.Surname;
            this.idTxt.Text = client.Id;
            this.phoneTxt.Text = client.Phone;
            this.addressTxt.Text = client.Address;
        }

        private void modifyAccount(object sender, EventArgs e)
        {
            try
            {
                Client modifiedClient = fetchValues();
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea Modificar su Contraseña?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Modify(client, modifiedClient);
                    MessageBox.Show("Su contraseña ha sido actualizado exitosamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Client fetchValues()
        {
            return new Client(
                this.userNameTxt.Text,
                this.passwordTxt.Text,
                this.nameTxt.Text,
                this.surnameTxt.Text,
                this.idTxt.Text,
                this.phoneTxt.Text,
                this.addressTxt.Text,
                client.RegistrationDate,
                client.LastAccess);
        }
    }
}
