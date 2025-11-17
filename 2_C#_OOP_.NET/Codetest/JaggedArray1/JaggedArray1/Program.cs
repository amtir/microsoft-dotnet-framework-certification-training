using System;

namespace JaggedArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jagged Array: ");
            int[][] jarray = new int[2][] {
                new int [3] { 1, 2,3 },
                new int [4] { 4,5,6,7 }
            };
            Console.WriteLine(jarray[0][0] );
            Console.WriteLine(jarray[0][1]);
            Console.WriteLine(jarray[0][2]);
            Console.WriteLine(jarray[1][0]);
            Console.WriteLine(jarray[1][1]);
            Console.WriteLine(jarray[1][2]);
            Console.WriteLine(jarray[1][3]);
            Console.Read();

        }
    }
}
