using System.Collections.Generic;
using System.Windows.Forms;

namespace Gui
{
    public class MenuNode
    {
        public string Title { get; set; }
        public string Action { get; set; }
        public List<UserControl> UserActions { get; set; }

        public MenuNode(string title, string action)
        {
            this.Title = title;
            this.Action = action;
            this.UserActions = new List<UserControl>();
        }

        public void AddNode(UserControl action)
        {
            this.UserActions.Add(action);
        }
    }
}
