using System.Windows.Forms;
using Domain.Entities;

namespace Gui.Forms
{
    public partial class VerifyInformation : Form
    {
        private User user;
        public VerifyInformation(User user)
        {
            InitializeComponent();
            this.user = user;
        }
    }
}
