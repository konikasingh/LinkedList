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

            //list.InsertFirst(70);
            //list.InsertFirst(30);
            //list.InsertFirst(56);
            //Console.WriteLine("after inserting node the list is:");
            //list.display();

            //list.Append(56);
            //list.Append(30);
            //list.Append(70);
            //Console.WriteLine("After appending node the list is:");
            //list.display();

            //list.InsertLast(50);
            //list.InsertLast(70);
            //Console.WriteLine("after insert node at specific position");
            //list.specificPostition(2, 30);
            //list.display();

            //list.InsertLast(50);
            //list.InsertLast(30);
            //list.InsertLast(70);
            //Console.WriteLine("after deleting first node the list is:");
            //list.deleteFirstNode();
            //list.display();

            list.InsertLast(50);
            list.InsertLast(30);
            list.InsertLast(70);
            Console.WriteLine("after deleting last node the list is:");
            list.deleteLastNode();
            list.display();

        }
    }
}
