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
            this.designerConfiguration_btn.Visible = user.CanABMDesigners();
            this.girdConfiguration_btn.Visible = user.CanABMGrids();

            SetUp();
        }

        private void SetUp()
        {
            this.mainPicture_box.Visible = true;

            this.createGrid_btn.Visible = false;
            this.modifyGrid_btn.Visible = false;
            this.deleteGrid_btn.Visible = false;

            this.createDesigner_btn.Visible = false;
            this.modifyDesigner_btn.Visible = false;
            this.deleteDesigners_btn.Visible = false;

            this.clearMenu_Btn.Visible = false;
        }

        //Administrator
        private void showDesignersConfiguration(object sender, EventArgs e)
        {
            interactiveMenu();
            this.createDesigner_btn.Visible = true;
            this.modifyDesigner_btn.Visible = true;
            this.deleteDesigners_btn.Visible = true;
        }

        //Client

        //Designer
        private void showGridConfigurationOptions(object sender, EventArgs e)
        {
            interactiveMenu();
            this.createGrid_btn.Visible = true;
            this.modifyGrid_btn.Visible = true;
            this.deleteGrid_btn.Visible = true;
        }
        private void createGrid(object sender, EventArgs e)
        {
            CreateGridForm createGridForm = new CreateGridForm();
            createGridForm.Show();
            this.Hide();
        }

        //Globals
        private void logOut(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void interactiveMenu() {
            this.clearMenu_Btn.Visible = true;
        }

        private void clearMenu(object sender, EventArgs e)
        {
            this.SetUp();
        }

        private void exit(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
