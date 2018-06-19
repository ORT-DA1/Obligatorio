using System;
using System.Windows.Forms;
using Gui.Interface;
using Domain.Exceptions;
using Domain.Entities;
using Domain.Logic;
using Domain.Repositories;

namespace Gui.UserControls.ABMDesignerScreen
{
    public partial class ABMDesignerScreenAdd : UserControl, IController
    {
        private DesignerHandler handler;
        private UserRepository userRepository;
        public ABMDesignerScreenAdd()
        {
            InitializeComponent();
            this.handler = new DesignerHandler();
            this.userRepository = new UserRepository();
            this.AccessibleName = "Agregar";
            this.titleTxt.Text = "Agregar Diseñador";     
        }
        public UserControl GetUserController()
        {
            return this;
        }
        private void addDesigner(object sender, EventArgs e)
        {
            try
            {
                Designer newDesigner = fetchValues();
                userRepository.UserExist(newDesigner.Username);
                handler.Add(newDesigner);
                MessageBox.Show("El Diseñador " + newDesigner.Username + " fue ingresado exitosamente al sistema.", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Designer fetchValues()
        {
            DateTime registrationDate = DateTime.Now;
            return new Designer(this.usernameTxt.Text, this.passwordTxt.Text, this.nameTxt.Text, this.surnameTxt.Text, registrationDate, null);
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
 