using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly SubMenu m_MainMenuList;

        // Constructor for new main menu
        public MainMenu()
        {
            this.m_MainMenuList = new SubMenu("Main Menu");
        }

        // Getter to the main menu
        public SubMenu MainMenuList
        {
            get { return this.m_MainMenuList; }
        }

        // Adding menu item to the main menu
        public void AddItemToMainMenu(MenuItem i_MenuItemToAdd)
        {
            this.m_MainMenuList.AddMenuItem(i_MenuItemToAdd);
           
            // Checking if there is a need to change the "back" option to "exit" in case it was the first item added to the menu
            if (this.m_MainMenuList.MenuItemList.Count == 2)
            {
                this.m_MainMenuList.MenuItemList[0].Title = "Exit";
            }
        }

        // Showing the menu
        public void Show()
        {
            this.m_MainMenuList.DoWhenChosen();
        }
    }
}
