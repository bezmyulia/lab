using System;

namespace Laborr6
{
    class Program
    {
        public static double Avarge(params int[] arr)

        {
            double av = 0;
            foreach (int elem in arr)
                av += elem;
            return (av / arr.Length);
        }
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(Avarge(a));

            short sh1 = 1, sh2 = 12;
            byte bt = 107;
            Console.WriteLine(Avarge(sh1, sh2, bt));
        }
    }
}