using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListClass linkedListClass = new LinkedListClass();
            linkedListClass.AddElements();
            linkedListClass.DeleteLastValue();
            linkedListClass.DeleteFirstElement();
            linkedListClass.Display();
        }
    }
}
