using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly SubMenu r_MainMenuList;

        // Constructor for MainMenu
        public MainMenu()
        {
            this.r_MainMenuList = new SubMenu("Main Menu");
        }

        // Getter for the MainMenu MenuItems 
        public SubMenu MainMenuItems
        {
            get { return this.r_MainMenuList; }
        }

        // Adder to the MainMenu MenuItem 
        public void AddItemToMainMenu(MenuItem i_MenuItemToAdd)
        {
            this.r_MainMenuList.AddMenuItem(i_MenuItemToAdd);
            
            // Checking if this is a new menu , so we change the "Back" to "Exit" since this is how each subMenu initalized
            if (this.r_MainMenuList.MenuItemsList.Count == 2)
            {
                this.r_MainMenuList.MenuItemsList[0].Title = "Exit";
            }
        }

        public void Show()
        {
            this.r_MainMenuList.DoWhenChosen();
        }
    }
}
