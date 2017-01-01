using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TestExamples
    {
        public class ShowVersion : IAction
        {
            public void Invoke()
            {
                Console.WriteLine("Version: 16.2.4.0");
            }
        }

        public class CharsCount : IAction
        {
            public void Invoke()
            {
                int numOfLetters = 0;

                Console.WriteLine("Please type a sentence");
                string sentence = Console.ReadLine();
                foreach (char currChar in sentence)
                {
                    if (char.IsLetter(currChar))
                    {
                        numOfLetters++;
                    }
                }

                Console.WriteLine("The sentence got  {0} letters", numOfLetters);
            }
        }

        public class CountSpaces : IAction
        {
            public void Invoke()
            {
                int numOfSpaces = 0;

                Console.WriteLine("Please type a sentence");
                string sentence = Console.ReadLine();
                foreach (char currChar in sentence)
                {
                    if (char.IsWhiteSpace(currChar))
                    {
                        numOfSpaces++;
                    }
                }

                Console.WriteLine("The sentence got {0} spaces", numOfSpaces);
            }
        }

        public class ShowTime : IAction
        {
            public void Invoke()
            {
                DateTime currTime = DateTime.Now;
                Console.WriteLine("Current time: {0}:{1}", currTime.Hour, currTime.Minute);
            }
        }

        public class ShowDate : IAction
        {
            public void Invoke()
            {
                DateTime currDate = DateTime.Today;
                Console.WriteLine(
                    "Current date: {0}/{1}/{2}", currDate.Day, currDate.Month, currDate.Year);
            }
        }
    }
}
