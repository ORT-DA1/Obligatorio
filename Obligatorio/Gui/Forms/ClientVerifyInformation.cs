using System;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Logic;
using Domain.Exceptions;

namespace Gui.Forms
{
    public partial class ClientVerifyInformation : Form
    {
        private Client client;
        private ClientHandler handler;
        public ClientVerifyInformation(Client user)
        {
            InitializeComponent();
            this.client = user;
            this.handler = new ClientHandler();
            this.ControlBox = false;
            LoadUserData();
        }
        private void LoadUserData()
        {
            this.userNameTxt.Text = client.Username;
            this.passwordTxt.Text = client.Password;
            this.nameTxt.Text = client.Name;
            this.surnameTxt.Text = client.Surname;
            //this.idTxt.Text = client.Id;
            this.phoneTxt.Text = client.Phone;
            this.addressTxt.Text = client.Address;   
        }
        private void confirm(object sender, EventArgs e)
        {
            try
            {
                Client modifiedClient = fetchValues();
                ProcessConfirmation(modifiedClient);
            }
            catch (ExceptionController Exception)
            {
                var message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ProcessConfirmation(Client modifiedClient)
        {
            DialogResult dialogResult = MessageBox.Show("Una vez confirmados los datos, muchos de ellos no podran ser modificados mas adelante. Desea Continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                handler.Modify(client, modifiedClient);
                Redirect(modifiedClient);
            }
        }
        private Client fetchValues()
        {
            DateTime lastAccess = DateTime.Now;

            return new Client(
                this.userNameTxt.Text,
                this.passwordTxt.Text,
                this.nameTxt.Text,
                this.surnameTxt.Text,
                this.idTxt.Text,
                this.phoneTxt.Text,
                this.addressTxt.Text,
                client.RegistrationDate,
                lastAccess);
        }
        private void Redirect(Client modifiedClient)
        {
            MainMenu mainMenu = new MainMenu(modifiedClient);
            mainMenu.Show();
            this.Hide();
        }
    }
}
