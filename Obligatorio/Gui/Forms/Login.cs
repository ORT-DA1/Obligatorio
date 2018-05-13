using System;
using System.Windows.Forms;
using Domain.Entities;
using Domain.Data;
using Domain.Exceptions;
using Domain.Logic;

namespace Gui.Forms
{
    public partial class Login : Form
    {
        private DataStorage dataStorage;
        public Login()
        {
            InitializeComponent();
            this.dataStorage = DataStorage.GetStorageInstance();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userName = this.usernameTxt.Text;
            var password = this.passwordTxt.Text;

            try
            {
                dataStorage.UserExist(userName, password);
                User user = dataStorage.GetUser(userName);
                this.LogUser(user);
            }
            catch (ExceptionController exceptionMessage)
            {
                String msgError = exceptionMessage.Message;
                MessageBox.Show(msgError, "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LogUser(User user)
        {
            if (user.CanVerifyInformation())
            {   
                MessageBox.Show("Bievenido por primera vez a Graphic Master!" + "\n" + "Porfavor, verifique sus datos antes de continuar.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MainMenu mainMenu = new MainMenu(user);
                mainMenu.Show();
                this.Hide();
                mainMenu.FormClosing += quit;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void GenerateData(object sender, EventArgs e)
        {
            try
            {
                this.GenerateDesigners();
                this.GenerateClients();
                String infoMessage = "Se autogeneraron Datos de prueba";
                MessageBox.Show(infoMessage, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.generateDataStrip.Enabled = false;
            }
            catch (ExceptionController)
            {
                String msgError = "Los datos ya han sido generados previamente.";
                MessageBox.Show(msgError, "Error en Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.generateDataStrip.Enabled = false;
            }
        }

        private void GenerateDesigners()
        {
            DesignerHandler designerHandler = new DesignerHandler();

            DateTime validDate = new DateTime(2018, 05, 28, 10, 53, 55);
            Designer firstDesigner = new Designer("donald", "qwe123", "Donald", "Trump", validDate, null);
            Designer secondDesigner = new Designer("slash", "guitarLover1", "Slash", "Jackson", validDate, null);
            designerHandler.Add(firstDesigner);
            designerHandler.Add(secondDesigner);
        }
        private void GenerateClients()
        {
            ClientHandler clientHandler = new ClientHandler();

            DateTime validDate = new DateTime(2018, 05, 28, 10, 53, 55);
            Client firstClient = new Client("cliente", "cliente", "Oracle", "Netsuite", "12345678", 234234234, "16 de Abril 1912", validDate, null);
            Client secondClient = new Client("Cliente", "Cliente123", "League", "ofLegends", "54683928", 236234234, "16 de Abril 1912", validDate, null);
            clientHandler.Add(firstClient);
            clientHandler.Add(secondClient);
        }

        private void quit(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
