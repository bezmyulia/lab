using System;

namespace Laborr6
{
    class Program
    {
        class Example
        {
            public static void Sqr(double a, double b)
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

            public static void Init(Example a)
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
            Example.Sqr(a, b);
            Example.Sqr(a * 2, b * 2);

            // измененный вариант
            Console.WriteLine();
            Example parametr = new Example(0);
            Example.Init(parametr);


            // попробовать по заданию в пункте f 
            /*
            Example Obj = new Example(0);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);
            Example.Init(Obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", Obj.x, Obj.y);
            */
        }
    }
}