using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> _people = new List<int>();
            LinkedList<int> _people2 = new LinkedList<int>();
            Console.Write("Введите количество людей в кругу: ");
            int n = Convert.ToInt32(Console.ReadLine());
            CompletingList(_people, n);
            ComplitingLinkedList(_people2, n);
            Console.WriteLine("Имеем список:");
            Output(_people);
            DeleteSecondList(_people);
            DeleteSecondLinkedList(_people2);
            Console.Write("В превом списке остался: ");
            Output(_people);
            Console.Write("Во втором списке остался: ");
            Output(_people2);

            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        /// <summary>
        /// Compleating list 
        /// </summary>
        /// <param name="people"> Input list</param>
        /// <param name="N"> Count of list</param>
        static void CompletingList(List<int> people, int N)
        {
            for (int i = 0; i < N; i++)
            {
                people.Add(i);
            }
        }

        /// <summary>
        /// Compleatinh Linked List
        /// </summary>
        /// <param name="people"> Input list</param>
        /// <param name="N"> Count of list</param>
        static void ComplitingLinkedList(LinkedList<int> people, int N)
        {
            for (int i = 0; i < N; i++)
            {
                people.AddLast(i);
            }
        }

        /// <summary>
        /// Delete each second from list
        /// </summary>
        /// <param name="people"> Input list</param>
        static void DeleteSecondList(List<int> people)
        {
            
            int i = 1;
            while (people.Count > 1)
            {
                people.RemoveAt(i);
                i++;
                if (i > people.Count)
                {
                    i = 1;
                }
                if (i == people.Count)
                {
                    i = 0;
                }
            }
        }
        
        /// <summary>
        /// Delete each second from Linked list
        /// </summary>
        /// <param name="people"> Input list</param>
        static void DeleteSecondLinkedList(LinkedList<int> people)
        {
            LinkedListNode<int> node = people.First;
            while (people.Count > 1)
            {
                people.Remove(node.Next);
                node = node.Next;
                if (node == people.Last)
                {
                    people.RemoveFirst();
                    node = people.First;
                }
                if (node == null)
                {
                    node = people.First;
                }
            }
        }

        /// <summary>
        /// Output list
        /// </summary>
        /// <param name="people"> Iput list</param>
        static void Output(List<int> people)
        {
            foreach (var element in people)
            {
                Console.WriteLine(element);
            }
        }

        /// <summary>
        /// Output linked list
        /// </summary>
        /// <param name="people"> Input list</param>
        static void Output(LinkedList<int> people)
        {
            foreach (var element in people)
            {
                Console.WriteLine(element);
            }
        }
    }
}
