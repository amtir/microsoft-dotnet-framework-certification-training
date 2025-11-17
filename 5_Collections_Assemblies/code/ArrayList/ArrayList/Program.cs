using System;
using System.Collections;
using System.Collections.Generic; 

namespace ArrayList_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Elements of the array are : " + arr[i]);
            }

            ArrayList a = new ArrayList();
            a.Add(10);
            a.Add(20);
            a.Add("Jeni");
            a.Add(4.234);
            Console.WriteLine("Capacity: " + a.Capacity);
            Console.WriteLine("Legth: " + a.Count);

            Console.WriteLine("Elements of the ArrayList are");
            foreach ( object i in a)
            {
                Console.WriteLine(i);
            }


            ArrayList b = new ArrayList();
            b.Add(10);
            b.Add(2);
            b.Add(6);
            b.Add(4);
            Console.WriteLine("Capacity: " + b.Capacity);
            Console.WriteLine("Legth: " + b.Count);
            b.Sort();
            Console.WriteLine("Elements of the ArrayList are");
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
