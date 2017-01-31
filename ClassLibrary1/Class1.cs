using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Threds(string[] args)
        {

            Thread t1 = new Thread(First);
            Thread t2 = new Thread(Second);
            Thread t3 = new Thread(Temperature);
            t1.Start();
            t2.Start();
            t3.Start();
            t3.Join();
            t2.Join();
            t1.Join();

            System.Console.WriteLine();
            System.Console.WriteLine("\n Press Enter for Exit");
            System.Console.ReadLine();
            System.Console.WriteLine("EXIT");
        }
        static void Temperature()
        {

        }
        static void First()
        {
            int k = 0;
            while (k < 5)
            {
                Random random = new Random();
                Thread.Sleep(random.Next(2, 5));
                k++;
                Console.WriteLine("C# threads are easy! ");
            }
        }
        static void Second()
        {
            int i = 0;
            while (i < 5)
            {
                Random random = new Random();
                Thread.Sleep(random.Next(1, 5));
                Console.WriteLine("Also, with multiple threads ... ");
                i++;
            }
        }
    }
}
