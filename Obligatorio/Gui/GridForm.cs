using System.Drawing;
using System.Windows.Forms;
using Domain.Entities;

namespace Gui
{
    public partial class GridForm : Form
    {
        private Grid grid;
        private Graphics graphic;

        public GridForm()
        {
            InitializeComponent();
        }

        public GridForm(Grid grid)
        {
            InitializeComponent();
            this.grid = grid;
            this.graphic = this.gridPanel.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gridPanel.AutoScroll = true;
            this.Hide();
        }

        private void generateLines(object sender, PaintEventArgs e)
        {
            this.grid.DrawGrid(this.graphic);
        }

        public void UpdateLines()
        {
            this.gridPanel.Refresh();
        }
    }
}
