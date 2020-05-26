using System;

namespace Laborr6
{
    class Program
    {
        class Example
        {
            public static void Sqr(ref double a,ref double b)
            {
                a = Math.Pow(a, 2);
                b = Math.Pow(b, 2);
                Console.WriteLine($"В методе Sqr.a:\na = {a}\tb = {b}");
            }

            public int x;
            public int y;

            public Example(int x)
            {
                this.x = x;
                Console.WriteLine($"Example: {x}");
            }

            public static void Init(ref Example a)
            {
                Example var = a;
                a.x = 10;
                a.y = 11;
                Console.WriteLine($"В методе Init: {a.x}");
                Console.WriteLine($"В методе Init: {a.y}");
            }
        }
        static void Main(string[] args)
        {
            double a = 1.25;
            double b = 2.25;
            Console.WriteLine($"В методе Main:\na = {a}\t b = {b}");
            Example.Sqr(ref a,ref b);
            //Example.Sqr(a * 2, b * 2);

            Console.WriteLine();
            Example parametr = new Example(0);
            Example.Init(ref parametr);
        }
    }
}