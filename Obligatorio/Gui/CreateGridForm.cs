using Domain.Entities;
using System;
using System.Windows.Forms;

namespace Gui
{
    public partial class CreateGridForm : Form
    {
        public CreateGridForm()
        {
            InitializeComponent();
        }

        private void createGridBtn_MouseClick(object sender, MouseEventArgs e)
        {
            //validar inputs
            String gridName = this.gridNameTxt.Text;
            int width = Int16.Parse(this.widthTxt.Text);
            int height = Int16.Parse(this.heightTxt.Text);


            //
            DateTime registrationDate = new DateTime(1990, 07, 21);
            Client client = new Client("test", "test", "test", "test", "test", 1203, "test", registrationDate, null);

            Grid grid = new Grid(gridName, client, height, width);
            GridForm gridForm = new GridForm(grid);
            gridForm.Show();
        }
    }
}
