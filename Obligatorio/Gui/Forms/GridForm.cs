using System.Drawing;
using System.Windows.Forms;
using Domain.Entities;
using System.Collections.Generic;
using System;
using Domain.Exceptions;
using Domain.TypesGrid;
using Domain.Repositories;
using Domain.Logic;

namespace Gui.Forms
{
    public partial class GridForm : Form
    {
        private Domain.Entities.Grid grid;
        private Graphics graphic;
        private int option = 0;
        private List<System.Drawing.Point> pointArray;
        private Form parentForm;
        private User _user;
        private GridHandler handler;

        public GridForm()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public GridForm(Grid grid, Form parentForm, bool canEditGrid, User user)
        {
            InitializeComponent();
            this.handler = new GridHandler();
            this._user = user;
            this.parentForm = parentForm;
            this.ControlBox = false;
            this.grid = grid;
            this.pointArray = new List<System.Drawing.Point>();
            this.graphic = this.gridPanel.CreateGraphics();
            graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gridPanel.AutoScroll = true;
            this.Hide();

            SetupEnvironment(canEditGrid);

            wallBtn.MouseClick += new MouseEventHandler(changeOption);
            windowBtn.MouseClick += changeOption;
            doorBtn.MouseClick += changeOption;
            deleteWallBtn.MouseClick += changeOption;
            deleteWindowBtn.MouseClick += changeOption;
            deleteDoorBtn.MouseClick += changeOption;
            finishDesignBtn.MouseClick += changeOption;
            addDecorativeColumnBtn.MouseClick += changeOption;
            deleteDecorativeColumnBtn.MouseClick += changeOption;

        }

        private void SetupEnvironment(bool canEditGrid)
        {
            this.wallBtn.Visible = canEditGrid;
            this.windowBtn.Visible = canEditGrid;
            this.doorBtn.Visible = canEditGrid;
            this.deleteDoorBtn.Visible = canEditGrid;
            this.deleteWallBtn.Visible = canEditGrid;
            this.deleteWindowBtn.Visible = canEditGrid;
            this.finishDesignBtn.Visible = canEditGrid;
            this.addDecorativeColumnBtn.Visible = canEditGrid;
            this.deleteDecorativeColumnBtn.Visible = canEditGrid;

            this.totalConstructionCostlbl.Visible = !canEditGrid;
            this.costLbl.Visible = !canEditGrid;
            this.costLbl.Text = Convert.ToString(this.grid.TotalCost());
            this.back_btn.Visible = !canEditGrid;
            this.moneyLbl.Visible = !canEditGrid;

            this.comboBox1.SelectedIndex = 0;

        }

        private void generateLines(object sender, PaintEventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
            this.grid.GridStrategy.DrawGrid(this.graphic, grid.Height, grid.Width);
            this.grid.DrawWalls(this.graphic);
            this.grid.DrawDoors(this.graphic);
            this.grid.DrawWindows(this.graphic);
            this.grid.DrawWallBeams(this.graphic);
            this.grid.DrawDecorativeColumns(this.graphic);
        }

        public void UpdateLines()
        {
            this.gridPanel.Refresh();
        }

        public Domain.Entities.Point fixPoint(Domain.Entities.Point point)
        {
            Domain.Entities.Point fixedPoint = new Domain.Entities.Point(
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
                    FinishAndSave();
                    break;
                case "addDecorativeColumnBtn":
                    option = 8;
                    break;
                case "deleteDecorativeColumnBtn":
                    option = 9;
                    break;
                default:
                    break;
            }
        }

        private void FinishAndSave()
        {
            var signatures = handler.GetGridSignatures(this.grid);

            if (this._user.CanSignGrids() && signatures == null)
            {

                DialogResult dialogResult = MessageBox.Show("Este plano no contiene firma, desea firmarlo?", "Plano Sin Firmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    ProcessGridSavingConfirmationWithSignature();
                }

            }
            else if (this._user.CanSignGrids() && signatures != null)
            {

                MessageBox.Show("Estimado " + _user.Username + ", acaba de guardar un plano Firmado. Al haber editado el mismo, su firma quedara registrada.", "Plano Sin Firmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProcessGridSavingConfirmationWithSignature();
            }

            MessageBox.Show("Cambios Guardados Correctamente", "Confirmacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CloseView();
        }

        private void CloseView()
        {
            option = 0;
            this.Close();
            this.parentForm.Show();
        }

        private void ProcessGridSavingConfirmationWithSignature()
        {
            DateTime signatureDate = DateTime.Now;
            Signature signature = new Signature((Architect)this._user, signatureDate, grid);
            handler.SaveSignature(grid, signature);
        }

        private void gridPanel_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            System.Drawing.Point coordinates = me.Location;

            if (option != 0)
            {
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
                                grid.AddWall(graphic, new Wall(new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y)
                                    , new Domain.Entities.Point(grid.FixPoint(pointArray[1]).X, grid.FixPoint(pointArray[1]).Y)));
                                UpdateLines();
                            }
                            catch (ExceptionController Exception)
                            {
                                string message = Exception.Message;
                                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case 2:
                            try
                            {
                                grid.AddDoor(graphic, new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y)
                                    , new Domain.Entities.Point(pointArray[1].X, pointArray[1].Y)
                                    , grid.WallSense(new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y)));
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
                                grid.AddWindow(graphic, new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y)
                                    , new Domain.Entities.Point(pointArray[1].X, pointArray[1].Y)
                                    , grid.WallSense(new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y)));
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
                                grid.RemoveWall(grid.ObtainWallInPoint(new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y)));
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
                                grid.RemoveWindow(new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y));
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
                                grid.RemoveDoor(new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y));
                                UpdateLines();
                            }
                            catch (ExceptionController Exception)
                            {
                                string message = Exception.Message;
                                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case 8:
                            try
                            {
                                grid.AddDecorativeColumn(graphic, new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y));
                                UpdateLines();
                            }
                            catch (ExceptionController Exception)
                            {
                                string message = Exception.Message;
                                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case 9:
                            grid.RemoveDecorativeColumn(new Domain.Entities.Point(pointArray[0].X, pointArray[0].Y));
                            UpdateLines();
                            break;
                        default:
                            break;
                    }
                    pointArray.Clear();
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parentForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                this.setCompleteLineGrid();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.setDottedLineGrid();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                this.setWithoutVisualGrid();
            }
        }

        private void setWithoutVisualGrid()
        {
            this.grid.GridStrategy = new WithoutVisualGrid();
            this.grid.GridStrategy.DrawGrid(this.graphic, grid.Height, grid.Width);
            this.grid.DrawWalls(this.graphic);
            this.grid.DrawDoors(this.graphic);
            this.grid.DrawWindows(this.graphic);
            this.grid.DrawWallBeams(this.graphic);
            this.grid.DrawDecorativeColumns(this.graphic);
        }

        private void setDottedLineGrid()
        {
            this.grid.GridStrategy = new WithoutVisualGrid();
            this.grid.GridStrategy.DrawGrid(this.graphic, grid.Height, grid.Width);
            this.grid.GridStrategy = new DottedLineGrid();
            this.grid.GridStrategy.DrawGrid(this.graphic, grid.Height, grid.Width);
            this.grid.DrawWalls(this.graphic);
            this.grid.DrawDoors(this.graphic);
            this.grid.DrawWindows(this.graphic);
            this.grid.DrawWallBeams(this.graphic);
            this.grid.DrawDecorativeColumns(this.graphic);
        }

        private void setCompleteLineGrid()
        {
            this.grid.GridStrategy = new CompleteLineGrid();
            this.grid.GridStrategy.DrawGrid(this.graphic, grid.Height, grid.Width);
            this.grid.DrawWalls(this.graphic);
            this.grid.DrawDoors(this.graphic);
            this.grid.DrawWindows(this.graphic);
            this.grid.DrawWallBeams(this.graphic);
            this.grid.DrawDecorativeColumns(this.graphic);
        }
    }
}
