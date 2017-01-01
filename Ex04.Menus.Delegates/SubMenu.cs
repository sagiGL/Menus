using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private const int k_BackOptionIndex = 0;
        private List<MenuItem> m_MenuItemList;        

        // Setter&Getter to menu item list
        public List<MenuItem> MenuItemList
        {
            get { return m_MenuItemList; }
            set { m_MenuItemList = value; }
        }

        // Constructor to SubMenu
        public SubMenu(string i_Title)
        {
            Title = i_Title;
            m_MenuItemList = new List<MenuItem>();
        }

        // Add a menu item to a menu
        public SubMenu AddMenuItem(MenuItem i_MenuItem)
        {
           // Check if menu item list is empty if not add back option befor adding new menu item 
           if (!this.MenuItemList.Any())
            {
                MenuItem GoBackOption = new ActionItem("Back");
                GoBackOption.Index = 0;
                this.MenuItemList.Add(GoBackOption);
            }

            i_MenuItem.Index = this.m_MenuItemList.Count();
            this.m_MenuItemList.Add(i_MenuItem);

            return this;
        }

        // Show the SubMenu menu item list
        private void showSubMenu()
        {
            int chosenOptionIndex;

            do
            {
                // 1)Print the name of the menu
                Console.WriteLine(Title);
                
                // 2)Print the menu
                foreach (MenuItem menuItem in m_MenuItemList)
                {
                    if (menuItem.Index != 0)
                    {
                        Console.WriteLine("{0}. {1}", menuItem.Index, menuItem.Title);
                    }
                }

                Console.WriteLine("{0}. {1}", m_MenuItemList[0].Index, m_MenuItemList[0].Title);
                
                // 3 + 4)Get chosen option with input validation 
                chosenOptionIndex = this.getChoiceFromUser();
                
                // 5) invoking the option
                if (chosenOptionIndex != k_BackOptionIndex)
                {
                    m_MenuItemList[chosenOptionIndex].DoWhenChosen();
                }
            }
            while (chosenOptionIndex != k_BackOptionIndex);
        }

        // Activate SubMenu when chosen.
        public override void DoWhenChosen()
        {
            if (!m_MenuItemList.Any())
            {
                Console.WriteLine("No action was placed yet in this action item");
            }
            else
            {
                Console.Clear();
                showSubMenu();
            }
        }

        // Helper to get from the user option.
        private int getChoiceFromUser()
        {
            int choice;
            string choiceStr;

            Console.Write("Option #: ");
            choiceStr = Console.ReadLine();

            // Checking for good input
            while (!int.TryParse(choiceStr, out choice) || (choice < 0 || choice > m_MenuItemList.Count - 1))
            {
                Console.Write("Invalid Input please enter a number between {0} and {1}:", 0, m_MenuItemList.Count - 1);
                choiceStr = Console.ReadLine();
            }

            return choice;
        }
    }
}
