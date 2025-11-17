using System;
using System.Collections;
using System.Collections.Generic;

namespace hashtable_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("101", "Mira");
            ht.Add("102", "Sam");
            ht.Add("103", "Max");
            ht.Add("104", "John");
            ICollection key = ht.Keys;

            Console.WriteLine("Hash Table: ");

            foreach(var i in key)
            {  
                Console.WriteLine(i + " : " + ht[i]); 

            }


            SortedList<string, string> names = new SortedList<string, string>();
            names.Add("6", "Mira");
            names.Add("1", "Sam");
            names.Add("3", "Max");
            names.Add("2", "John");

            Console.WriteLine("SortedList Table: ");

            foreach (KeyValuePair<string, string> i in names)
            {
                Console.WriteLine(i.Key + " : " + i.Value);

            }
            Console.ReadLine();


        }
    }
}
