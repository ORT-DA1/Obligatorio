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
using Domain.Logic;
using Domain.Entities;

namespace Gui.UserControls.ABMArchitectScreen
{
    public partial class ABMArchitectScreenDelete : UserControl, IController
    {
        private ArchitectHandler handler;
        public ABMArchitectScreenDelete()
        {
            InitializeComponent();
            this.handler = new ArchitectHandler();
            this.AccessibleName = "Borrar";
            this.titleTxt.Text = "Borrar Arquitecto";
        }
        public UserControl GetUserController()
        {
            try
            {
                LoadArchitectsIntoList();
                return this;
            }
            catch (ExceptionController Exception)
            {
                String message = Exception.Message;
                MessageBox.Show(message, "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return null;
        }
        public void LoadArchitectsIntoList()
        {
            this.architectList.Items.Clear();
            foreach (Architect architect in handler.GetList())
            {
                this.architectList.Items.Add(architect);
            }
        }
        private void deleteArchitect(object sender, EventArgs e)
        {
            var selectedArchitect = architectList.SelectedItem;
            if (selectedArchitect != null)
            {
                Delete((Architect)selectedArchitect);
            }
            else
            {
                MessageBox.Show("Porfavor seleccione el Arquitecto que desea borrar.", "No se selecciono ningun usuaruio.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Delete(Architect architect)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que desea borrar este Cliente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    handler.Delete(architect);
                    LoadArchitectsIntoList();
                }
            }
            catch (ExceptionController)
            {
                String message = "Ya no quedan Arquitectos registrados en el sistema.";
                MessageBox.Show(message, "Sin Arquitectos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
