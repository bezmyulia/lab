using System;

namespace Laborr7
{
    class Program
    {
        class Rational
        {
            private int m;
            private int n;

            public Rational(int a, int b)
            {
                if (b == 0)
                {
                    this.m = 0;
                    this.n = 1;
                }
                else
                {
                    this.m = a;
                    this.n = b;
                }
            }
            public override string ToString()
            {
                return $"({m}/{n})";
            }
            public void PrintRational()
            {
                Console.WriteLine($"Класс: Rational\t{m}/{n}");
            }
            public Rational Plus(Rational a)
            {
                int x, y;
                x = m * a.n + n * a.m;
                y = n * a.n;
                return (new Rational(x, y));
            }
            public static Rational operator +(Rational x, Rational y)
            {
                return (x.Plus(y));
            }
            public Rational Minus(Rational a)
            {
                int x, y;
                x = m * a.n - n * a.m;
                y = n * a.n;
                return (new Rational(x, y));
            }
            public static Rational operator -(Rational x, Rational y)
            {
                return (x.Minus(x));
            }
            public Rational Mult(Rational a)
            {
                int x, y;
                x = m * a.m;
                y = n * a.n;
                return (new Rational(x, y));
            }
            public static Rational operator *(Rational x, Rational y)
            {
                return (x.Mult(y));
            }
            public Rational Divide(Rational a)
            {
                int x, y;
                x = m * a.n;
                y = n * a.m;
                return (new Rational(x, y));
            }
            public static Rational operator /(Rational x, Rational y)
            {
                return (x.Divide(y));
            }
            private Rational(int a, int b, string t)
            {
                m = a; n = b;
            }

            private static Rational zero;
            private static Rational one;
            static Rational()
            {
                zero = new Rational(0, 1, "zero");
                one = new Rational(1, 1, "one");
            }
            public static bool operator ==(Rational x, Rational y)
            {
                return ((x.m == y.m) && (x.n == y.n));
            }
            public static bool operator !=(Rational x, Rational y)
            {
                return ((x.m != y.m) || (x.n != y.n));
            }
            public static bool operator <(Rational x, Rational y)
            {
                return ((x.m * y.n) < (x.n * y.m));
            }
            public static bool operator >(Rational x, Rational y)
            {
                return ((x.m * y.n) > (x.n * y.m));
            }

            public static bool operator >(Rational x, double y)
            {
                return ((double)x.m / x.n > y);
            }
            public static bool operator <(Rational x, double y)
            {
                return ((double)x.m / x.n < y);
            }

            public static void TestRational()
            {
                Console.WriteLine("Вызов функции TestRational:");
                Rational obj1 = new Rational(1, 1);
                Rational obj2 = new Rational(5, 5);
                Rational obj3 = new Rational(-1, 5);
                Rational obj4 = new Rational(5, -1);
                double a = 1.25;
                double b = 2.125;
                if (obj1 == zero)
                {
                    Console.WriteLine($"{obj1} = {zero}");
                }
                else
                {
                    Console.WriteLine($"{obj1} != {zero}");
                }
                if (obj2 != one)
                {
                    Console.WriteLine($"{obj2} != {one}");
                }
                else
                {
                    Console.WriteLine($"{obj2} = {one}");
                }

                if (obj3 > obj4)
                {
                    Console.WriteLine($"{obj3} > {obj4}");
                }
                else
                {
                    Console.WriteLine($"{obj3} < {obj4}");
                }

                if (obj4 > a)
                {
                    Console.WriteLine($"{obj4} > {a}");
                }
                else
                {
                    Console.WriteLine($"{obj4} < {a}");
                }

                if (obj1 < b)
                {
                    Console.WriteLine($"{obj4} < {b}");
                }
                else
                {
                    Console.WriteLine($"{obj4} > {b}");
                }
            }
        }

        static void Main(string[] args)
        {
            Rational obj1 = new Rational(5, 0);
            Rational obj2 = new Rational(5, 4);
            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj2.ToString());
            obj1.PrintRational();
            obj2.PrintRational();
            Rational obj3 = new Rational(1, -3);
            obj3.PrintRational();

            Console.WriteLine("+ " + obj3.Plus(obj2));
            Console.WriteLine("- " + obj3.Minus(obj2));
            Console.WriteLine("* " + obj3.Mult(obj2));
            Console.WriteLine("/ " + obj3.Divide(obj2));

            Console.WriteLine("* + " + obj3.Mult(obj3.Plus(obj2)));

            Rational.TestRational();
            Console.WriteLine("Hello!");
        }
    }
}