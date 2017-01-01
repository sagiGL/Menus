using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private const int k_BackOptionIndex = 0;
        private readonly List<MenuItem> r_MenuItemsList;        

        // Getter for the MenuItem List
        public List<MenuItem> MenuItemsList
        {
            get { return r_MenuItemsList; }
        }

        // Constructor for a SubMenu given a title
        public SubMenu(string i_Title)
        {
            Title = i_Title;
            r_MenuItemsList = new List<MenuItem>();
        }

        // Adder of menuItem to the menuitem list
        public SubMenu AddMenuItem(MenuItem i_MenuItem)
        {
            // Check if the menu item list in Empty and need to add "Back" option
            if (!r_MenuItemsList.Any())
            {
                MenuItem goBackItem = new ActionItem("back");
                goBackItem.Index = 0;               
                r_MenuItemsList.Add(goBackItem);
            }

            i_MenuItem.Index = r_MenuItemsList.Count;
            r_MenuItemsList.Add(i_MenuItem);

            return this;
        }

        // Implemention of invoking the option
        internal override void DoWhenChosen()
        {
            // Checking if the menuitem is without options yet
            if (!r_MenuItemsList.Any())
            {
                Console.WriteLine("No menu items in the List");
            }
            else
            {
                Console.Clear();
                showSubMenu();
            }
        }

        private void showSubMenu()
        {
            int chosenOptionIndex;

            do
            {
                // 1) Print menu title
                Console.WriteLine(Title);
                
                // 2) Print menu options
                foreach (MenuItem menuItem in r_MenuItemsList)
                {
                    if (menuItem.Index != 0)
                    {
                        Console.WriteLine("{0}. {1}", menuItem.Index, menuItem.Title);
                    }
                }

                Console.WriteLine("{0}. {1}", r_MenuItemsList[0].Index, r_MenuItemsList[0].Title);
                
                // 3 + 4) Get user's Choise and check input validation
                chosenOptionIndex = this.getOptionFromUser();
               
                // 5) invoking the option
                if (chosenOptionIndex != k_BackOptionIndex)
                {
                    r_MenuItemsList[chosenOptionIndex].DoWhenChosen();
                }
            }
            while (chosenOptionIndex != k_BackOptionIndex);
        }

        // Helper to get choice
        private int getOptionFromUser()
        {
            int Option;
            string OptionStr;

            Console.Write("Option #: ");
            OptionStr = Console.ReadLine();

            // Input Validation
            while (!int.TryParse(OptionStr, out Option) || (Option < 0 || Option > this.MenuItemsList.Count - 1))
            {
                Console.Write("Please enter a number between {0} and {1}:", 0, this.MenuItemsList.Count - 1);
                OptionStr = Console.ReadLine();
            }

            return Option;
        }
    }
}
