using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Logic;
using Domain.Repositories;
using Domain.Exceptions;
using Domain.Entities;

namespace Gui.Forms
{
    public partial class NewOpeningForm : Form
    {
        private WindowHandler windowHandler;
        private DoorHandler doorHandler;
        private GridRepository _repository;
        private PriceAndCostHandler priceAndCostHandler;

        public NewOpeningForm(GridRepository repository)
        {
            InitializeComponent();
            this._repository = repository;
            this.windowHandler = new WindowHandler(this._repository);
            this.doorHandler = new DoorHandler(this._repository);
            this.priceAndCostHandler = new PriceAndCostHandler(this._repository);

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            ValidWidthHeight();
            var priceAndCost = this.priceAndCostHandler.GetPriceAndCostDoor();
            Door newDoorType = new Door(null, null, "vertical" , int.Parse(this.widthTxt.Text), int.Parse(this.heightTxt.Text), this.nameTxt.Text);
            //this.doorHandler.AddNewDoorEntity(newDoorType, priceAndCost);
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidWidthHeight()
        {
            int width;
            int height;

            if (!int.TryParse(this.heightTxt.Text, out height))
            {
                //throw new ExceptionController(ExceptionMessage); // Crear exception Message para invalid abertura height
            }

            if (!int.TryParse(this.widthTxt.Text, out width))
            {
               // throw new ExceptionController(ExceptionMessage); // Crear exception Message para invalid abertura width
            }
        }
    }
}
