using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();
            //list.InsertLast(56);
            //list.InsertLast(30);
            //list.InsertLast(70);
            //list.display();

            list.InsertFirst(70);
            list.InsertFirst(30);
            list.InsertFirst(56);
            Console.WriteLine("after inserting node the list is:");
            list.display();
        }
    }
}
