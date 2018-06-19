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
using Domain.Logic;
using Domain.Repositories;

namespace Gui.UserControls.ABMArchitectScreen
{
    public partial class ABMArchitectScreenAdd : UserControl, IController
    {
        private ArchitectHandler handler;
        private UserRepository userRepository;
        public ABMArchitectScreenAdd()
        {
            InitializeComponent();
            this.handler = new ArchitectHandler();
            this.userRepository = new UserRepository();
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
                userRepository.UserExist(newArchitect.Username);
                handler.Add(newArchitect);
                MessageBox.Show("El Arquitecto " + newArchitect.Username + " fue ingresado exitosamente al sistema.", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();

            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Architect FetchValues()
        {
            DateTime registrationDate = DateTime.Now;
            return new Architect(this.usernameTxt.Text, this.passwordTxt.Text, this.nameTxt.Text, this.surnameTxt.Text, registrationDate, null);
        }

        private void ClearForm()
        {
            this.usernameTxt.Clear();
            this.passwordTxt.Clear();
            this.nameTxt.Clear();
            this.surnameTxt.Clear();
        }
    }
}
