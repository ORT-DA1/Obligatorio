using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.Entities;
using Gui.UserControls.ABMClientScreen;
using Gui.UserControls.ABMDesignerScreen;


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

            SetUpEnvoronment();
            CreateMenu();
        }

        private void SetUpEnvoronment()
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
            foreach (MenuNode node in menuNodeList)
            {
                ToolStripMenuItem stripMenuItem = new ToolStripMenuItem(node.Title);
                foreach (UserControl action in node.UserActions)
                {
                    ToolStripMenuItem stripMenuChildItem = new ToolStripMenuItem();
                    stripMenuChildItem.Tag = action;
                    stripMenuChildItem.Text = action.AccessibleName;
                    action.Click += acccion_Click;
                    stripMenuItem.DropDownItems.Add(stripMenuChildItem);

                }
                leftMenu.Items.Add(stripMenuItem);
                ToolStripSeparator separator = new ToolStripSeparator();
                leftMenu.Items.Add(separator);
                Controls.Add(leftMenu);
            }
        }


        private void IncludeClientABMControlsToList()
        {
            ABMClientScreenAdd clientScreenAdd = new ABMClientScreenAdd();
            ABMClientScreenModify clientScreenModify = new ABMClientScreenModify();
            ABMClientScreenDelete clientScreenDelete = new ABMClientScreenDelete();
            MenuNode clientABMNode = new MenuNode("Mantenimiento de Clientes");

            clientABMNode.UserActions.Add(clientScreenAdd);
            clientABMNode.UserActions.Add(clientScreenModify);
            clientABMNode.UserActions.Add(clientScreenDelete);

            this.menuNodeList.Add(clientABMNode);
        }

        private void IncludeDesignerABMControlsToList()
        {
            ABMDesignerScreenAdd designerScreenAdd= new ABMDesignerScreenAdd();
            ABMDesignerScreenModify designerScreenModify = new ABMDesignerScreenModify();
            ABMClientScreenDelete designerScreenDelete = new ABMClientScreenDelete();
            MenuNode designerABMNode = new MenuNode("Mantenimiento de Disenadores");

            designerABMNode.UserActions.Add(designerScreenAdd);
            designerABMNode.UserActions.Add(designerScreenModify);
            designerABMNode.UserActions.Add(designerScreenDelete);

            this.menuNodeList.Add(designerABMNode);
        }

        private void IncludeGridABMControlsToListo()
        {
           
        }

        //Globals
        void acccion_Click(object sender, EventArgs e)
        {
            //panelContenido.Controls.Clear();
            //ToolStripMenuItem item = (ToolStripMenuItem)sender;
            //IActionHandler accion = (IActionHandler)item.Tag;
            //UserControl control = accion.GetControl();
            ////UserControl control = item.Tag
            //panelContenido.Controls.Add(control);
        }
        private void logOut(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void quit(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
