using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public static class DelegateTester
    {
        public static MainMenu BuildDelegateMenu()
        {
            /// Create ActionItems:
            ActionItemFunctionDelegate showVersionFunction = new TestExamples.ShowVersion().Invoke;
            MenuItem actionItem1 = new ActionItem("Show Version", showVersionFunction);
            ActionItemFunctionDelegate charsCountFunction = new TestExamples.CharsCount().Invoke;
            MenuItem actionItem2 = new ActionItem("Chars Count", charsCountFunction);
            ActionItemFunctionDelegate countSpacesFunction = new TestExamples.CountSpaces().Invoke;
            MenuItem actionItem3 = new ActionItem("Count Spaces", countSpacesFunction);
            ActionItemFunctionDelegate showTimeFunction = new TestExamples.ShowTime().Invoke;
            MenuItem actionItem4 = new ActionItem("Show Time", showTimeFunction);
            ActionItemFunctionDelegate showDateFunction = new TestExamples.ShowDate().Invoke;
            MenuItem actionItem5 = new ActionItem("Show Date", showDateFunction);
           
            /// Create SubMenus:
            SubMenu subMenu1 = new SubMenu("Actions");
            subMenu1.AddMenuItem(actionItem2);
            subMenu1.AddMenuItem(actionItem3);
            SubMenu subMenu2 = new SubMenu("Version and Actions");
            subMenu2.AddMenuItem(actionItem1);
            subMenu2.AddMenuItem(subMenu1);
            SubMenu subMenu3 = new SubMenu("Show Date/Time");
            subMenu3.AddMenuItem(actionItem4);
            subMenu3.AddMenuItem(actionItem5);
            
            /// Create MainMenu
            MainMenu mainMenu = new MainMenu();
            mainMenu.AddItemToMainMenu(subMenu2);
            mainMenu.AddItemToMainMenu(subMenu3);

            return mainMenu;
        }
    }
}
