using System;

namespace HomeTask_01._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4; //result = 16
            int b = -5; //result = 5
            int c = 0; //result = 0
            
            int x = a * a;
            Console.WriteLine($"{x}");

            int y = Math.Abs(b);
            Console.WriteLine($"{y}");

            Console.WriteLine($"{c}");
        }
    }
}