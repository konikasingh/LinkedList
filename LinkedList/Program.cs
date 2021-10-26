using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList list = new CustomLinkedList();

            /*Creating a simple link list*/
             
            //list.InsertLast(56);
            //list.InsertLast(30);
            //list.InsertLast(70);
            //list.display();
            
            /*Adding element in Linkedlist*/

            //list.InsertFirst(70);
            //list.InsertFirst(30);
            //list.InsertFirst(56);
            //Console.WriteLine("after inserting node the list is:");
            //list.display();

            /*Appending the element in linkedlist*/
             
            //list.Append(56);
            //list.Append(30);
            //list.Append(70);
            //Console.WriteLine("After appending node the list is:");
            //list.display();

            /*Insert at last position*/

            //list.InsertLast(50);
            //list.InsertLast(70);
            //Console.WriteLine("after insert node at specific position");
            //list.specificPostition(2, 30);
            //list.display();

            /*Delete the first element*/

            //list.InsertLast(50);
            //list.InsertLast(30);
            //list.InsertLast(70);
            //Console.WriteLine("after deleting first node the list is:");
            //list.deleteFirstNode();
            //list.display();

            /*Delete the last element*/

            //list.InsertLast(50);
            //list.InsertLast(30);
            //list.InsertLast(70);
            //Console.WriteLine("after deleting last node the list is:");
            //list.deleteLastNode();
            //list.display();

            /*Search the first element*/

            //list.InsertLast(56);
            //list.InsertLast(30);
            //list.InsertLast(70);
            //Console.WriteLine("the list is:");
            //list.display();
            //list.Search(30);

            /*Search the last element*/

            //list.InsertLast(56);
            //list.InsertLast(30);
            //list.InsertLast(70);
            //Console.WriteLine("the list is:");
            //list.display();
            //Console.WriteLine("afete adding the new node list is");
            //list.insertAfterNode(30, 40);
            //list.display();

            /*Ability to delete the element 40 in list*/

            list.InsertLast(50);
            list.InsertLast(30);
            list.InsertLast(70);

            Console.WriteLine("afete adding the new node list is");
            list.insertAfterNode(30, 40);
            list.display();
            list.size();
            Console.WriteLine("afete deleting specific node list is:");
            list.deleteSpecificNode(40);
            list.display();
            list.size();


        }
    }
}
