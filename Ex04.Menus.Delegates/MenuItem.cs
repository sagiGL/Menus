using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private string m_Title;
        private int m_Index;

        // Setter&Getter for title
        public string Title
        {
            get { return this.m_Title; }
            set { this.m_Title = value; }
        }

        // Setter&Getter for Index of menu item
        public int Index
        {
            get { return this.m_Index; }
            set { this.m_Index = value; }
        }

        // The action of the menu item to invoke when chosen, need to implement
        public abstract void DoWhenChosen();
    }
}
