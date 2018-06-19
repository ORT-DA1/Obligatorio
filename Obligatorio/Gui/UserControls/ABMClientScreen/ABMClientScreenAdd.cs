using System;
using System.Windows.Forms;
using Gui.Interface;
using Domain.Logic;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Repositories;

namespace Gui.UserControls.ABMClientScreen
{
    public partial class ABMClientScreenAdd : UserControl, IController
    {
        private ClientHandler handler;
        private UserRepository userRepository;
        public ABMClientScreenAdd()
        {
            InitializeComponent();
            this.userRepository = new UserRepository();
            this.handler = new ClientHandler();
            this.AccessibleName = "Agregar";
            this.client_title.Text = "Agregar Cliente";
        }

        public UserControl GetUserController()
        {
            return this;
        }

        private void addClient(object sender, EventArgs e)
        {
            try
            {
                Client newClient = fetchValues();
                userRepository.UserExist(newClient.Username);
                handler.Add(newClient);
                MessageBox.Show("El cliente " + newClient.Username + " fue ingresado exitosamente al sistema.", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Client fetchValues()
        {
            DateTime registrationDate = DateTime.Now;

            return new Client(
                this.usernameTxt.Text, 
                this.passwordTxt.Text, 
                this.nameTxt.Text, 
                this.surnameTxt.Text, 
                this.idTxt.Text,
                this.phoneTxt.Text,
                this.addressTxt.Text,
                registrationDate,
                null);
        }

        private void ClearForm()
        {
            this.usernameTxt.Clear();
            this.passwordTxt.Clear();
            this.nameTxt.Clear();
            this.surnameTxt.Clear();
            this.idTxt.Clear();
            this.phoneTxt.Clear();
            this.addressTxt.Clear();
        }

    }
}
