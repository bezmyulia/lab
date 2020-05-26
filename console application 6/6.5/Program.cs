using System;

namespace Laborr6
{
    class Program
    {
        public static double tm(int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }

        public static double ptm(params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }

        public static double ss(ref int a, params int[] arr)
        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }

        public static void stroka(params char[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 'h';
            }
            Console.Write("Char[] a: {");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "; ");
            }
            Console.WriteLine("}");
        }

        public static void TypeOfObject(Object a)
        {
            Console.WriteLine(a.GetType());
        }


        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            Console.WriteLine($"<тип>[]: {tm(a)}");

            short sh1 = 1, sh2 = 12;
            byte bt = 107;
            Console.WriteLine("params <тип>[]: " + ptm(sh1, sh2, bt));

            int b0 = 10, b1 = 20, b2 = 30, b3 = 40, b4 = 50;
            Console.WriteLine("По ссылке: " + ss(ref b0, b1, b2, b3, b4));

            char[] s = { 'H', 'e', 'l', 'l', 'o', '!' };
            stroka(s);

            TypeOfObject(s);
        }
    }
}