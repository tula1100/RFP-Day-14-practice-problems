using System;

namespace Day_14_Linked_List_Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist : operations");
            LinkedList list = new LinkedList();
            list.Add(56);
            int a = list.Search(56);
            list.InsertAtParticulatPosition(a + 1, 30);
            int b = list.Search(30);
            list.InsertAtParticulatPosition(b + 1, 70);
            list.Display();
           
        }
    }
}