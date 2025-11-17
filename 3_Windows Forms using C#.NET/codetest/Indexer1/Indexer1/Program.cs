using System;
using System.Security.Cryptography.X509Certificates;

namespace Indexer1
{
    class IndexedNames
    {
        private string[] namelist = new string[size]; 
        static public int size = 10;
        
        public IndexedNames()
        {
            for(int i = 0; i < size; i++)
                namelist[i] = "N.A";
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = ".";
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    namelist[index] = value;
            }

            }
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Indexer ...");
                IndexedNames names = new IndexedNames();
                names[0] = "AAAAAAAA";
                names[1] = "BBBBBBBB";
                names[2] = "CCCCCCCC";
                names[3] = "DDDDDDDD";
                names[4] = "EEEEEEEE";
                names[5] = "FFFFFFFF";

                for (int i = 0; i < IndexedNames.size; i++)
                {
                    Console.WriteLine(names[i]);
                }

                Console.WriteLine(names[1234]);
                Console.WriteLine(names[1234]="1234");
                Console.WriteLine(names[1234]);
            }
        }
    }
}
