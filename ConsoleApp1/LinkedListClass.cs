using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class LinkedListClass
    {
       LinkedList<int>  Number = new LinkedList<int>();
        public void AddElements()
        {
            Number.AddFirst(56);
            Number.AddLast(30);
            Number.AddLast(70);

        }
        public void BeforeDelete()
        {
            Console.WriteLine("Before Deleting:");
            Console.WriteLine("Numbers are:");
            foreach (int i in Number)
            {
                Console.WriteLine(i);
            }
        }
        public void DeleteFirstElement()
        {
            Number.RemoveFirst();

        }
        public void Display()
        {
            Console.WriteLine("After Deleting umbers are:");
            foreach (int i in Number)
            {
               Console.WriteLine(i);
            }
        }
        
    }
}
