using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private IAction m_Action;

        // Constructor for action item
        public ActionItem()
        {
            m_Action = null;
        }

        // Constructor for action item given a title
        public ActionItem(string i_Title)
        {
            Title = i_Title;
        }

        // Constructor for action item given a title and action
        public ActionItem(string i_Title, IAction i_Action)
        {
            Title = i_Title;
            m_Action = i_Action;
        }

        // Implemention of invoking the menu item
        internal override void DoWhenChosen()
        {
            if (m_Action == null)
            {
                System.Console.WriteLine("Item dont have an action yet");
            }
            else
            {
                m_Action.Invoke();
            }
        }
    }
}
