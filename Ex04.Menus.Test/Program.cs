using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Test;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            // Invoking menu with interface implementation 
            InterfaceTester.BuildInterfaceMenu().Show();

            // Invoking menu with delegates implementation 
            DelegateTester.BuildDelegateMenu().Show();
        }
    }
}
