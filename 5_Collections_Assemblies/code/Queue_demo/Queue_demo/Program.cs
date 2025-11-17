using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("MCA");
            q.Enqueue("MBA");
            q.Enqueue("B. SC");
            Console.WriteLine("The elements in queue are: ");
            foreach(string s in q)
            {  
                Console.WriteLine(s); 
            }

            q.Dequeue();
            q.Dequeue();

            Console.WriteLine("The elements after Dequeue are: ");
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
