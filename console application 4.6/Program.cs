using System;

namespace Lab4_6
{
    class Program
    {
        private static Random rnd = new Random();

        public static void createArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = rnd.Next(1, 9);
        }
        public static void printArray(string b, int[,] a)
        {
            Console.Write("\n" + b + "[" + a.GetLength(0) + ";" + a.GetLength(1) + "]" + ":");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.Write(" { ");
                    }
                    Console.Write(a[i, j] + "; ");
                }
                Console.Write("}");
            }
        }
        public static int sravn(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        public static int[,] sum(int[,] a, int[,] b)
        {
            int x = sravn(a.GetLength(0), b.GetLength(0));
            int y = sravn(a.GetLength(1), b.GetLength(1));

            int[,] s = new int[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    s[i, j] = a[i, j] + b[i, j];
            return s;
        }
        public static int[,] razn(int[,] a, int[,] b)
        {
            int x = sravn(a.GetLength(0), b.GetLength(0));
            int y = sravn(a.GetLength(1), b.GetLength(1));

            int[,] s = new int[x, y];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    s[i, j] = a[i, j] - b[i, j];
            return s;
        }
        public static int[,] proizv(int[,] a, int b)
        {
            int[,] s = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    s[i, j] = a[i, j] * b;
            return s;
        }
        public static int[,] del(int[,] a, int b)
        {
            int[,] s = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    s[i, j] = a[i, j] / b;
            return s;
        }
        static void Main()
        {
            Console.WriteLine($"Введите размерность массива: ");

            int[,] m1 = new int[rnd.Next(2, 6), rnd.Next(2, 6)];
            int[,] m2 = new int[rnd.Next(2, 6), rnd.Next(2, 6)];

            createArray(m1);
            createArray(m2);

            printArray("1 Maccив: ", m1);
            printArray("2 Maccив: ", m2);

            int[,] r1 = sum(m1, m2);
            printArray("Сумма массивов: ", r1);

            int[,] r2 = razn(m1, m2);
            printArray("Разность массивов: ", r2);

            int[,] r3 = proizv(m1, 4);
            printArray("Умножение на число: ", r3);

            int[,] r4 = del(m2, 2);
            printArray("Деление на число: ", r4);

            Console.WriteLine();
            Console.WriteLine("Введите индексы элементов");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x >= m1.GetLength(0) || y >= m1.GetLength(1))
            {
                Console.WriteLine("Выход за предел массива");
            }
            else
            {
                Console.WriteLine($"Значение массива  в точке [{x};{y}] = {m1[x, y]}");
            }
        }
    }
}
