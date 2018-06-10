using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui.UserControls.CreateOpeningScreen
{
    public partial class CreateElement : UserControl
    {
        public CreateElement()
        {
            InitializeComponent();
        }

        private void typeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(this.typeComboBox.SelectedIndex == 0)
            {
                this.highFromGroundLbl.Visible = false;
                this.highFromGroundTextBox.Visible = false;
            }
            else
            {
                this.highFromGroundLbl.Visible = true;
                this.highFromGroundTextBox.Visible = true;
            }
        }

        private void createElementBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.typeComboBox.SelectedIndex == 0) {
                createTypeOfDoor(this.nameTextBox, this.widthTextBox, this.highTextBox);
            }else
            {
                createTypeOfWindow(this.nameTextBox, this.widthTextBox, this.highTextBox, this.highFromGroundTextBox);
            }
        }
    }
}
