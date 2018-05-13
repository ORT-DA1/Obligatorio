using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.Entities;
using Gui.UserControls.ABMClientScreen;


namespace Gui.Forms
{
    public partial class MainMenu : Form
    {
        
        private User user;
        List<MenuNode> menuNodeList = new List<MenuNode>();
        public MainMenu(User user)
        {
            InitializeComponent();

            this.user = user;
            this.showDesignerConfiguration_btn.Visible = user.CanABMDesigners();
            this.showGirdConfiguration_btn.Visible = user.CanABMGrids();


            this.mainPicture_box.Visible = true;


            SetUp();
        }

        private void SetUp()
        {
            this.CreateMenu();
            if (user.CanABMClients())
            {
                IncludeClientABMControlsToClist();  
            }
            if (user.CanABMDesigners())
            {
                IncludeDesignerABMControlsToClist();
            }
        }

        private void CreateMenu()
        {
            MenuStrip menuStrip = this.leftMenuStrip;
            foreach (MenuNode node in menuNodeList)
            {
                ToolStripMenuItem stripMenuItem = new ToolStripMenuItem(node.Title);
                foreach (UserControl action in node.UserActions)
                {
                    ToolStripMenuItem stripMenuChildItem = new ToolStripMenuItem();
                    stripMenuChildItem.Tag = action;
                    stripMenuChildItem.Text = node.Action;
                    action.Click += acccion_Click;
                    stripMenuItem.DropDownItems.Add(stripMenuChildItem);

                }
                menuStrip.Items.Add(stripMenuItem);
                ToolStripSeparator separator = new ToolStripSeparator();
                menuStrip.Items.Add(separator);
                Controls.Add(menuStrip);
            }
        }

        void acccion_Click(object sender, EventArgs e)
        {
            //panelContenido.Controls.Clear();
            //ToolStripMenuItem item = (ToolStripMenuItem)sender;
            //IActionHandler accion = (IActionHandler)item.Tag;
            //UserControl control = accion.GetControl();
            ////UserControl control = item.Tag
            //panelContenido.Controls.Add(control);
        }


        private void IncludeClientABMControlsToClist()
        {
            ABMClientScreenAdd ClientScreenAdd = new ABMClientScreenAdd();
            ABMClientScreenModify ClientScreenModify = new ABMClientScreenModify();
            ABMClientScreenDelete ClientScreenDelete = new ABMClientScreenDelete();
            MenuNode clientABMNode = new MenuNode("","");
        }
        private void IncludeDesignerABMControlsToClist()
        {

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
        private void showClientsConfiguration(object sender, EventArgs e)
        {
            interactiveMenu();
            this.createClients_brn.Visible = true;
            this.modifyClients_btn.Visible = true;
            this.deleteClients_btn.Visible = true;
        }

        //Designer
        private void showGridConfiguration(object sender, EventArgs e)
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
            this.SetUp();
            this.clearMenu_Btn.Visible = true;
        }

        private void clearMenu(object sender, EventArgs e)
        {
            this.SetUp();
        }

        private void quit(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
