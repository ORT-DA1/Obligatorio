using System;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Data;
using Domain.Exceptions;

namespace Gui
{
    public partial class Login : Form
    {
        private DataStorage dataStorage;
        public Login()
        {
            InitializeComponent();
            this.dataStorage = DataStorage.GetStorageInstance();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userName = this.usernameTxt.Text;
            var password = this.passwordTxt.Text;

            try
            {
                dataStorage.UserExist(userName, password);
                User user = dataStorage.GetUser(userName);
                MainMenu mainMenu = new MainMenu(user);
                mainMenu.Show();
                this.Hide();
            }
            catch (ExceptionController exceptionMessage)
            {
                String msgError = exceptionMessage.Message;
                MessageBox.Show(msgError, "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
