using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.Entities;
using Gui.UserControls.ABMClientScreen;
using Gui.UserControls.ABMDesignerScreen;
using Gui.UserControls.ABMGridScreen;
using Gui.Interface;


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

            SetUpEnvironment();
            CreateMenu();
        }

        private void SetUpEnvironment()
        {
            if (user.CanABMClients())
            {
                IncludeClientABMControlsToList();  
            }
            if (user.CanABMDesigners())
            {
                IncludeDesignerABMControlsToList();
            }
            if (user.CanABMGrids())
            {
                IncludeGridABMControlsToListo();
            }

        }
        private void CreateMenu()
        {
            MenuStrip leftMenu = this.leftMenuStrip;
            ToolStripSeparator firstSeparator = new ToolStripSeparator();
            leftMenu.Items.Add(firstSeparator);
            foreach (MenuNode node in menuNodeList)
            {
                ToolStripMenuItem stripMenuItem = new ToolStripMenuItem(node.Title);
                foreach (UserControl action in node.UserActions)
                {
                    ToolStripMenuItem stripMenuChildItem = new ToolStripMenuItem();
                    stripMenuChildItem.Tag = action;
                    stripMenuChildItem.Text = action.AccessibleName;
                    stripMenuChildItem.Click += updateControlPanel;
                    stripMenuItem.DropDownItems.Add(stripMenuChildItem);

                }
                leftMenu.Items.Add(stripMenuItem);
                ToolStripSeparator itemSeparator = new ToolStripSeparator();
                leftMenu.Items.Add(itemSeparator);
                Controls.Add(leftMenu);
            }
        }
        private void IncludeClientABMControlsToList()
        {
            ABMClientScreenAdd clientScreenAdd = new ABMClientScreenAdd();
            ABMClientScreenModify clientScreenModify = new ABMClientScreenModify();
            ABMClientScreenDelete clientScreenDelete = new ABMClientScreenDelete();

            MenuNode clientABMNode = new MenuNode("Clientes");
            clientABMNode.UserActions.Add(clientScreenAdd);
            clientABMNode.UserActions.Add(clientScreenModify);
            clientABMNode.UserActions.Add(clientScreenDelete);

            this.menuNodeList.Add(clientABMNode);
        }
        private void IncludeDesignerABMControlsToList()
        {
            ABMDesignerScreenAdd designerScreenAdd= new ABMDesignerScreenAdd();
            ABMDesignerScreenModify designerScreenModify = new ABMDesignerScreenModify();
            ABMDesignerScreenDelete designerScreenDelete = new ABMDesignerScreenDelete();

            MenuNode designerABMNode = new MenuNode("Diseñadores");
            designerABMNode.UserActions.Add(designerScreenAdd);
            designerABMNode.UserActions.Add(designerScreenModify);
            designerABMNode.UserActions.Add(designerScreenDelete);

            this.menuNodeList.Add(designerABMNode);
        }
        private void IncludeGridABMControlsToListo()
        {
            ABMGridScreenAdd gridScreenAdd = new ABMGridScreenAdd();
            ABMGridScreenModify gridScreenModify = new ABMGridScreenModify();
            ABMGridScreenDelete gridScreenDelete = new ABMGridScreenDelete();

            MenuNode gridABMNode = new MenuNode("Planos");
            gridABMNode.UserActions.Add(gridScreenAdd);
            gridABMNode.UserActions.Add(gridScreenModify);
            gridABMNode.UserActions.Add(gridScreenDelete);

            this.menuNodeList.Add(gridABMNode);
        }
        //Globals
        void updateControlPanel(object sender, EventArgs e)
        {
            controlPanel.Controls.Clear();
            ToolStripMenuItem menuNode = (ToolStripMenuItem)sender;
            IController controller = (IController)menuNode.Tag;
            UserControl controlToShow = controller.GetUserController();
            
            controlPanel.Controls.Add(controlToShow);
        }
        private void logOut(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void quit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
