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
            this.idTxt.Text = client.IdentityCard;
            this.phoneTxt.Text = client.Phone;
            this.addressTxt.Text = client.Address;   
        }
        private void confirm(object sender, EventArgs e)
        {
            try
            {
                DateTime lastAccess = DateTime.Now;

                this.client.Username = this.userNameTxt.Text;
                this.client.Password = this.passwordTxt.Text;
                this.client.Name = this.nameTxt.Text;
                this.client.Surname = this.surnameTxt.Text;
                this.client.IdentityCard = this.idTxt.Text;
                this.client.Phone = this.phoneTxt.Text;
                this.client.Address = this.addressTxt.Text;
                this.client.LastAccess = lastAccess;

                ProcessConfirmation();
            }
            catch (ExceptionController Exception)
            {
                var message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadUserData();
            }
        }
        private void ProcessConfirmation()
        {
            DialogResult dialogResult = MessageBox.Show("Una vez confirmados los datos, muchos de ellos no podran ser modificados mas adelante. Desea Continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                handler.Modify(this.client);
                Redirect(this.client);
            }
        }
        private void Redirect(Client modifiedClient)
        {
            MainMenu mainMenu = new MainMenu(modifiedClient);
            mainMenu.Show();
            this.Hide();
        }
    }
}
