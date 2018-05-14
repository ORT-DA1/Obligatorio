using System.Collections.Generic;
using System.Windows.Forms;

namespace Gui
{
    public class MenuNode
    {
        public string Title { get; set; }
        public List<UserControl> UserActions { get; set; }

        public MenuNode(string title)
        {
            this.Title = title;
            this.UserActions = new List<UserControl>();
        }

        public void AddNode(UserControl action)
        {
            this.UserActions.Add(action);
        }
    }
}
