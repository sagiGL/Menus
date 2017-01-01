using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void ActionItemFunctionDelegate();

    public class ActionItem : MenuItem
    {
        public event ActionItemFunctionDelegate m_FunctionToInvokeWhenChosen;
        
        // Constructor with no params 
        public ActionItem()
        {
            m_FunctionToInvokeWhenChosen = null;
        }

        // Constructor with title param
        public ActionItem(string i_Title)
        {
            Title = i_Title;
        }

        // Constructor  to action item with function 
        public ActionItem(string i_Title, ActionItemFunctionDelegate i_FunctionToInvokeWhenChosen)
        {
            Title = i_Title;
            m_FunctionToInvokeWhenChosen += i_FunctionToInvokeWhenChosen;
        }

        // Activate the action item                                                                                                                                                                                               
        public override void DoWhenChosen()
        {
            // Check if the there is an action to invoke in action item
            if (m_FunctionToInvokeWhenChosen == null)
            {
                Console.WriteLine("No action was placed yet in this action item");
            }
            else
            {
                m_FunctionToInvokeWhenChosen.Invoke();
            }
        }
    }
}
