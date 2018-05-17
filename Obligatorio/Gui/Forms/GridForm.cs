using System.Drawing;
using System.Windows.Forms;
using Domain.Entities;
using System.Collections.Generic;
using System;
using Domain.Exceptions;

namespace Gui.Forms
{
    public partial class GridForm : Form
    {
        private Domain.Entities.Grid grid;
        private Graphics graphic;
        private int option=0;
        private List<Point> pointArray;
        private Form parentForm;
        private Grid selectedGrid;

        public GridForm()
        {
            InitializeComponent();
        }

        public GridForm(Grid grid, Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            this.grid = grid;
            this.pointArray = new List<Point>();
            this.graphic = this.gridPanel.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gridPanel.AutoScroll = true;
            this.Hide();

            wallBtn.MouseClick += new MouseEventHandler(changeOption);
            windowBtn.MouseClick += changeOption;
            doorBtn.MouseClick += changeOption;
            deleteWallBtn.MouseClick += changeOption;
            deleteWindowBtn.MouseClick += changeOption;
            deleteDoorBtn.MouseClick += changeOption;
            finishDesignBtn.MouseClick += changeOption;
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

        private void changeOption(object sender, System.EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "wallBtn":
                    option = 1;
                    break;
                case "windowBtn":
                    option = 2;
                    break;
                case "doorBtn":
                    option = 3;
                    break;
                case "deleteWallBtn":
                    option = 4;
                    break;
                case "deleteWindowBtn":
                    option = 5;
                    break;
                case "deleteDoorBtn":
                    option = 6;
                    break;
                case "finishDesignBtn":
                    option = 7;
                    string message = "Se han guardado los cambios sobre el plano";
                    MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.parentForm.Show();
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
                pointArray[0] = grid.FixPoint(pointArray[0]);
                switch (option)
                {
                    case 1:
                        try
                        {
                            grid.AddWall(graphic, new Wall(pointArray[0], grid.FixPoint(pointArray[1])));
                            UpdateLines();
                        }
                        catch (ExceptionController Exception)
                        {
                            string message = Exception.Message;
                            MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2:
                        try {
                            grid.AddDoor(graphic, pointArray[0], pointArray[1], grid.WallSense(pointArray[0]));
                            UpdateLines();
                        }
                        catch (ExceptionController Exception)
                        {
                            string message = Exception.Message;
                            MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 3:
                        try
                        {
                            grid.AddWindow(graphic, pointArray[0], pointArray[1], grid.WallSense(pointArray[0]));
                            UpdateLines();
                        }
                        catch (ExceptionController Exception)
                        {
                            string message = Exception.Message;
                            MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 4:
                        try
                        {
                            grid.RemoveWall(grid.ObtainWallInPoint(pointArray[0]));
                            UpdateLines();
                        }
                        catch (ExceptionController Exception)
                        {
                            string message = Exception.Message;
                            MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 5:
                        try
                        {
                            grid.RemoveWindow(pointArray[0]);
                            UpdateLines();
                        }
                        catch (ExceptionController Exception)
                        {
                            string message = Exception.Message;
                            MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 6:
                        try
                        {
                            grid.RemoveDoor(pointArray[0]);
                            UpdateLines();
                        }
                        catch (ExceptionController Exception)
                        {
                            string message = Exception.Message;
                            MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        break;
                    }
                pointArray.Clear();
            }
        }
    }
}
