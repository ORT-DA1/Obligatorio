using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gui.Interface;
using Domain.Exceptions;

namespace Gui.UserControls.MyAccount
{
    public partial class MyAccountOwnedGrids : UserControl, IController
    {
        public MyAccountOwnedGrids()
        {
            InitializeComponent();
            this.AccessibleName = "Mis Planos";
            this.titleTxt.Text = "Mis Planos";
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadOwnedGrids();
                return this;
            }
            catch (ExceptionController Exception)
            {

            }
            return null;
        }
        private void LoadOwnedGrids()
        {

        }
    }
}
