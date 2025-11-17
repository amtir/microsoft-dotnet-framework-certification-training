using System;

namespace excep1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {



                int x = 10, b = 0;
                int c = x / b;
                Console.WriteLine("c = " + c);

                int[] a = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
                Console.WriteLine(a[7]);

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception occured: " + e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Exception occured: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally: Clean resources");
            }
            
        }
    }
}
