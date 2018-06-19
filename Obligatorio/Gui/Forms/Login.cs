using System;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Data;
using Domain.Exceptions;
using Domain.Logic;
using Domain.Interface;
using Domain.Repositories;

namespace Gui.Forms
{
    public partial class Login : Form
    {
        private IUserRepository userRepository;
        public Login()
        {
            InitializeComponent();
            this.userRepository = new UserRepository();
            this.ControlBox = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userName = this.usernameTxt.Text;
            var password = this.passwordTxt.Text;

            try
            {
                User user = this.userRepository.GetUser(userName, password);
                this.LogUser(user);
            }
            catch (ExceptionController exceptionMessage)
            {
                String msgError = exceptionMessage.Message;
                MessageBox.Show(msgError, "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LogUser(User user)
        {
            if (user.CanVerifyInformation())
            {
                FirstLogin(user);
            }
            else
            {
                NormalLogin(user);
            }
        }
        private void FirstLogin(User user)
        {
            MessageBox.Show("Bievenido por primera vez a Graphic Master!" + "\n" + "Porfavor, verifique sus datos antes de continuar.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClientVerifyInformation verificationForm = new ClientVerifyInformation((Client)user);
            verificationForm.Show();
            this.Hide();
        }
        private void NormalLogin(User user)
        {
            MainMenu mainMenu = new MainMenu(user);
            user.LastAccess = DateTime.Now;
            mainMenu.Show();
            this.Hide();
            mainMenu.FormClosing += quit;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void quit(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
