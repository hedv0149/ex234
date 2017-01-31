using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    p.Run();
        //    Class1.Threds();
        //}

        //private void Run()
        //{

        //}
        static void Main(string[] args)
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
            int alarm = 0;
            int temp;
            while (alarm < 3)
            {
                Random random = new Random();
                Thread.Sleep(random.Next(3, 5));
                temp = random.Next(-20, 120);
                Console.WriteLine(temp + " C ");
                if (temp < 0 || temp > 100)
                {
                    alarm++;
                    Console.WriteLine("!Alarm! Temperature is outside the legal range! ");
                }
            }
        }
        static void First()
        {
            int k = 0;
            while (k < 5)
            {
                Random random = new Random();
                Thread.Sleep(random.Next(2, 10));
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
                Thread.Sleep(random.Next(1, 20));
                Console.WriteLine("Also, with multiple threads ... ");
                i++;
            }
        }

    }
}
