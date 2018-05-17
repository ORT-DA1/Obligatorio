using System.Drawing;
using System.Windows.Forms;
using Domain.Entities;
using System.Collections.Generic;
using System;

namespace Gui.Forms
{
    public partial class GridForm : Form
    {
        private Domain.Entities.Grid grid;
        private Graphics graphic;
        private int option=0;
        private List<Point> pointArray;

        public GridForm()
        {
            InitializeComponent();
        }

        public GridForm(Domain.Entities.Grid grid)
        {
            InitializeComponent();
            this.grid = grid;
            this.pointArray = new List<Point>();
            this.graphic = this.gridPanel.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gridPanel.AutoScroll = true;
            this.Hide();

            paredBtn.MouseClick += new MouseEventHandler(cambiarOpcion);
            ventanaBtn.MouseClick += cambiarOpcion;
            puertaBtn.MouseClick += cambiarOpcion;
            quitarParedBtn.MouseClick += cambiarOpcion;
        }

        private void generateLines(object sender, PaintEventArgs e)
        {
            this.grid.DrawGrid(this.graphic);
            this.grid.DrawWalls(this.graphic);
            this.grid.DrawDoors(this.graphic);
            this.grid.DrawWindows(this.graphic);
            this.grid.DrawWallBeams(this.graphic);
        }

        public void UpdateLines()
        {
            this.gridPanel.Refresh();
        }


        public Point fixPoint(Point point)
        {
            Point fixedPoint = new Point(
               ((int)Math.Round((double)point.X / Domain.Entities.Grid.PixelConvertor)) * Domain.Entities.Grid.PixelConvertor,
               ((int)Math.Round((double)point.Y / Domain.Entities.Grid.PixelConvertor)) * Domain.Entities.Grid.PixelConvertor
           );
            return fixedPoint;
        }

        private void cambiarOpcion(object sender, System.EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "paredBtn":
                    option = 1;
                    break;
                case "ventanaBtn":
                    option = 2;
                    break;
                case "puertaBtn":
                    option = 3;
                    break;
                case "quitarParedBtn":
                    option = 4;
                    break;
                case "quitarPuertaBtn":
                    option = 5;
                    break;
                case "quitarVentanaBtn":
                    option = 6;
                    break;
                default:
                    break;
            }
        }

        private void gridPanel_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            if (pointArray.Count < 1)
            {
                pointArray.Add(coordinates);
            }
            else
            {
                pointArray.Add(coordinates);
                pointArray[0] = grid.fixPoint(pointArray[0]);
                switch (option)
                {
                    case 1:
                        grid.AddWall(graphic, new Wall(pointArray[0], grid.fixPoint(pointArray[1])));
                        UpdateLines();
                        break;
                    case 2:
                        grid.AddDoor(graphic, pointArray[0], pointArray[1], grid.wallSense(pointArray[0]));
                        UpdateLines();
                        break;
                    case 3:
                        grid.AddWindow(graphic, pointArray[0], pointArray[1], grid.wallSense(pointArray[0]));
                        UpdateLines();
                        break;
                    case 4:
                        grid.RemoveWall(grid.obtainWallInPoint(pointArray[0]));
                    UpdateLines();
                    break;
                    case 5:
                        grid.RemoveDoor(pointArray[0]);
                        UpdateLines();
                        break;
                    case 6:
                        grid.RemoveWindow(pointArray[0]);
                        UpdateLines();
                        break;
                    default:
                        break;
                    }
                pointArray.Clear();
            }
        }
    }
}
