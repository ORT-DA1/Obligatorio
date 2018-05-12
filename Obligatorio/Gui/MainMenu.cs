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


namespace Gui
{
    public partial class MainMenu : Form
    {
        private User user;
        public MainMenu(User user)
        {
            InitializeComponent();

            this.user = user;
            this.createGridBtn.Visible = user.CanCreateGrid();
            this.designersConfigBtn.Visible = user.CanABMDesigners();
        }

        private void designersConfigBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
