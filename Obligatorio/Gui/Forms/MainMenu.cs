using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.Entities;
using Gui.UserControls.ABMArchitectScreen;
using Gui.UserControls.ABMClientScreen;
using Gui.UserControls.ABMDesignerScreen;
using Gui.UserControls.ABMGridScreen;
using Gui.UserControls.Configuration;
using Gui.UserControls.MyAccount;
using Gui.Interface;


namespace Gui.Forms
{
    public partial class MainMenu : Form
    {
        private User user;

        private MenuNode architectABMNode;
        private MenuNode clientABMNode;
        private MenuNode designerABMNode;
        private MenuNode gridABMNode;
        private MenuNode configurationNode;
        private MenuNode myAccountNode;

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
            GenerateMenuNodes();
            ArchitectABMControls();
            ClientABMControls();
            DesignerABMControls();
            GridABMControls();
            PriceConfiguration();
            PersonalInformation();
            OwnedGrids();
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
        private void GenerateMenuNodes()
        {
            this.architectABMNode = new MenuNode("Arquitectos");
            this.clientABMNode = new MenuNode("Clientes");
            this.designerABMNode = new MenuNode("Diseñadores");
            this.gridABMNode = new MenuNode("Planos");
            this.configurationNode = new MenuNode("Configuracion");
            this.myAccountNode = new MenuNode("Mi Cuenta");
        }
        private void ArchitectABMControls()
        {
            if (user.CanABMArchitects())
            {
                ABMArchitectScreenAdd architectScreenAdd = new ABMArchitectScreenAdd();
                ABMArchitectScreenModify architectScreenModify = new ABMArchitectScreenModify();
                ABMArchitectScreenDelete architectScreenDelete = new ABMArchitectScreenDelete();

                architectABMNode.UserActions.Add(architectScreenAdd);
                architectABMNode.UserActions.Add(architectScreenModify);
                architectABMNode.UserActions.Add(architectScreenDelete);

                this.menuNodeList.Add(architectABMNode);
            }
        }
        private void ClientABMControls()
        {
            if (user.CanABMClients())
            {
                ABMClientScreenAdd clientScreenAdd = new ABMClientScreenAdd();
                ABMClientScreenModify clientScreenModify = new ABMClientScreenModify();
                ABMClientScreenDelete clientScreenDelete = new ABMClientScreenDelete();

                clientABMNode.UserActions.Add(clientScreenAdd);
                clientABMNode.UserActions.Add(clientScreenModify);
                clientABMNode.UserActions.Add(clientScreenDelete);

                this.menuNodeList.Add(clientABMNode);
            }
        }
        private void DesignerABMControls()
        {
            if (user.CanABMDesigners())
            {
                ABMDesignerScreenAdd designerScreenAdd = new ABMDesignerScreenAdd();
                ABMDesignerScreenModify designerScreenModify = new ABMDesignerScreenModify();
                ABMDesignerScreenDelete designerScreenDelete = new ABMDesignerScreenDelete();

                designerABMNode.UserActions.Add(designerScreenAdd);
                designerABMNode.UserActions.Add(designerScreenModify);
                designerABMNode.UserActions.Add(designerScreenDelete);

                this.menuNodeList.Add(designerABMNode);
            }
        }
        private void GridABMControls()
        {
            if (user.CanABMGrids())
            {
                CreateElement gridScreenAdd = new CreateElement(this.user);
                ABMGridScreenModify gridScreenModify = new ABMGridScreenModify(this.user);
                ABMGridScreenDelete gridScreenDelete = new ABMGridScreenDelete(this.user);

                gridABMNode.UserActions.Add(gridScreenAdd);
                gridABMNode.UserActions.Add(gridScreenModify);
                gridABMNode.UserActions.Add(gridScreenDelete);

                this.menuNodeList.Add(gridABMNode);
            }
        }
        private void PriceConfiguration()
        {
            if (user.CanConfigurePrices())
            {
                ConfigurationPrice priceConfig = new ConfigurationPrice();
                configurationNode.AddNode(priceConfig);

                this.menuNodeList.Add(configurationNode);
            }
        }
        private void PersonalInformation()
        {
            if (user.CanSeePersonalInformation())
            {
                MyAccountPersonalInformation personalInfo = new MyAccountPersonalInformation((Client)user);
                myAccountNode.AddNode(personalInfo);

                this.menuNodeList.Add(myAccountNode);
            }
        } 
        private void OwnedGrids()
        {
            if (user.CanSeeOwnedGrids())
            {
                MyAccountOwnedGrids ownedGrids = new MyAccountOwnedGrids((Client)user);
                myAccountNode.AddNode(ownedGrids);

                if (!this.menuNodeList.Contains(myAccountNode))
                {
                    this.menuNodeList.Add(myAccountNode);
                }
            }
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
