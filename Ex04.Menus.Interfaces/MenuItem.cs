using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Title = string.Empty;
        private int m_Index = 0;

        internal abstract void DoWhenChosen();
        
        // Getter&Setter to the index  of the menu item
        internal int Index
        {
            get { return this.m_Index; }
            set { this.m_Index = value; }
        }
        
        // Getter&Setter to the title of the menu item
        public string Title
        {
            get { return this.m_Title; }
            set { this.m_Title = value; }
        }
    }
}
