using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class LinkListClass
    {
       List<int>  Number = new List<int>();
        public void Write()
        {
            Number.Add(56);
            Number.Add(30);
            Number.Add(70);
        }
        public void Display()
        {
            Console.WriteLine("Numbers are:");
            foreach (int i in Number)
            {
               Console.WriteLine(i);
            }
        }
        
    }
}
