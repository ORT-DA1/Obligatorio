using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Logic;
using Logic.Interface;

namespace Gui
{
    public partial class WelcomeForm : Form
    {
        private IUserHandler<Client> ClientHandler;
        private IUserHandler<Designer> DesignerHandler;
        public WelcomeForm()
        {
            InitializeComponent();
            this.ClientHandler = new ClientHandler();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userName = this.usernameTxt.Text;
            var password = this.passwordTxt.Text;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
