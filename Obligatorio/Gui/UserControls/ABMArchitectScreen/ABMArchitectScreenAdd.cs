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
using Domain.Entities;

namespace Gui.UserControls.ABMArchitectScreen
{
    public partial class ABMArchitectScreenAdd : UserControl, IController
    {
        private handler = new ArchitectHandler();
        public ABMArchitectScreenAdd()
        {
            InitializeComponent();
            this.AccessibleName = "Agregar";
            this.titleTxt.Text = "Agregar Arquitecto";
        }

        public UserControl GetUserController()
        {
            return this;
        }

        private void addArchitect_Click(object sender, EventArgs e)
        {
            try
            {
                Architect newArchitect = FetchValues();
                //handler.Add(newDesigner);
                //MessageBox.Show("El Diseñador " + newDesigner.Username + " fue ingresado exitosamente al sistema.", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();

            }
            catch (ExceptionController message)
            {
                throw;
            }
        }

        private Architect FetchValues()
        {
            DateTime registrationDate = DateTime.Now;
            return new Architect(this.usernameTxt.Text, this.passwordTxt.Text, this.nameTxt.Text, this.surnameTxt.Text, registrationDate, null);
        }
    }
}
