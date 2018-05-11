using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Logic;
using Domain.Interface;
using Domain.Data;

namespace Gui
{
    public partial class WelcomeForm : Form
    {
        private DataStorage dataStorage;
        public WelcomeForm()
        {
            InitializeComponent();
            this.dataStorage = DataStorage.GetStorageInstance();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userName = this.usernameTxt.Text;
            var password = this.passwordTxt.Text;

            User user = 

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
