using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public static class InterfaceTester
    {
        public static MainMenu BuildInterfaceMenu()
        {
            /// Create leaves:
            IAction showVersionRunnable = new TestExamples.ShowVersion();
            MenuItem actionItemShowVer = new ActionItem("Show Version", showVersionRunnable);
            IAction charsCountRunnable = new TestExamples.CharsCount();
            MenuItem actionItemCharCount = new ActionItem("Chars Count", charsCountRunnable);
            IAction countSpacesRunnable = new TestExamples.CountSpaces();
            MenuItem actionItemCountSpaces = new ActionItem("Count Spaces", countSpacesRunnable);
            IAction showTimeRunnable = new TestExamples.ShowTime();
            MenuItem actionItemShowTime = new ActionItem("Show Time", showTimeRunnable);
            IAction showDateRunnable = new TestExamples.ShowDate();
            MenuItem actionItemShowDate = new ActionItem("Show Date", showDateRunnable);
            
            /// Create sub menus:
            SubMenu subMenuActions = new SubMenu("Actions");
            subMenuActions.AddMenuItem(actionItemCharCount);
            subMenuActions.AddMenuItem(actionItemCountSpaces);
            SubMenu subMenuVerAndActions = new SubMenu("Version and Actions");
            subMenuVerAndActions.AddMenuItem(actionItemShowVer);
            subMenuVerAndActions.AddMenuItem(subMenuActions);
            SubMenu subMenuDateAndTime = new SubMenu("Show Date/Time");
            subMenuDateAndTime.AddMenuItem(actionItemShowTime);
            subMenuDateAndTime.AddMenuItem(actionItemShowDate);
           
            /// Create Main menu
            MainMenu mainMenu = new MainMenu();
            mainMenu.AddItemToMainMenu(subMenuVerAndActions);
            mainMenu.AddItemToMainMenu(subMenuDateAndTime);

            return mainMenu;
        }
    }
}
