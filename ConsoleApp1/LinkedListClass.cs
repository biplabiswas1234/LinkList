using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class LinkedListClass
    {
       LinkedList<int>  Number = new LinkedList<int>();
        public void InsertBetween()
        {
            Number.AddLast(30);
            Number.AddFirst(70);
            Number.AddLast(56);

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
