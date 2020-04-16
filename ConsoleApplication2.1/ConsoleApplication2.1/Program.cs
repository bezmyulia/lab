using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2._1
{
    class Program
    {
        static void Main()
        {
            /*
            int i = 3, j = 4;
            Console.WriteLine("{0} {1}", i, j);
            Console.WriteLine("{0} {1}", ++i, --j);
            Console.WriteLine("{0} {1}", i++, j--);
            Console.WriteLine("{0} {1}", i, j);

            bool a = true, b = false;
            Console.WriteLine("{0} {1}", -i, -j);
            Console.WriteLine("{0} {1}", !a, !b);

            int x = -4;
            byte y = 4;
            int c = (int)y;  //преобразование без потери точности
            byte d = (byte)x; //преобразование с потерей точности
            Console.WriteLine("{0} {1}", c, d);

            int z = 100, k = 15;
            double e = 14.2, f = 3.5;
            Console.WriteLine("{0} {1} {2}", z* k, z/ k, z % k);
            Console.WriteLine("{0} {1} {2}", e* f, e / f, e % f);

            int h = 15, g = 15;
            Console.WriteLine(h < g); //меньше
            Console.WriteLine(h <= g);  //меньше или равно
            Console.WriteLine(h > g);  //больше
            Console.WriteLine(h >= g); //больше или равно
            Console.WriteLine(h == g);  //равно
            Console.WriteLine(h != g);  //не равно

            Console.WriteLine("x     y     x и y x или y");
            Console.WriteLine("{0} {1} {2} {3}", false, false, false && false, false || false);
            Console.WriteLine("{0} {1} {2} {3}", false, true, false && true, false || true);
            Console.WriteLine("{0} {1} {2} {3}", true, false, true && false, true || false);
            Console.WriteLine("{0} {1} {2} {3}", true, true, true && true, true || true);

            int x = 5; int y = 10;
            int max = (x > y) ? x : y;
            Console.WriteLine(max);
            */

            /*Console.WriteLine("Задание 2.1");
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Количество черных ячеек=" + n * n / 2);
            Console.WriteLine("Введите k");
            float k = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите m");
            float m = float.Parse(Console.ReadLine()); ;
            float z = (k + m) % 2;
            if (z != 0) Console.WriteLine("2. Белая ячейка");
                else Console.WriteLine("2. Черная ячейка");

            Console.Write("Введите k1");
            float k1 = float.Parse(Console.ReadLine());
            Console.Write("Введите m1");
            float m1 = float.Parse(Console.ReadLine());
            Console.Write("Введите k2");
            float k2 = float.Parse(Console.ReadLine());
            Console.Write("Введите m2");
            float m2 = float.Parse(Console.ReadLine());
            float x = (k1 + m1) % 2;
            float y = (k2 + m2) % 2;

            if (x != y) Console.WriteLine("3. Ячейки не одного цвета");
            else Console.WriteLine("3. Ячейки одного цвета");

            Console.WriteLine("4. Ударит или нет");
            if ((k1 == k2) && (m2 - m1 == 1)) Console.WriteLine("Пешка бьет");
                else Console.WriteLine("Пешка не бьет");
            if ((Math.Abs(k1 - k2)) == Math.Abs((m2 - m1))) Console.WriteLine("Слон бьет");
                else Console.WriteLine("Слон не бьет");
            if ((k1 == k2) || (m1 == m2)) Console.WriteLine("Ладья бьет");
                else Console.WriteLine("Ладья не бьет");
            if (((Math.Abs(k1 - k2)) == Math.Abs((m2 - m1))) || ((k1 == k2) || (m1 == m2))) Console.WriteLine("Ферзь бьет");
                else Console.WriteLine("Ферзь не бьет");
            if (((m2 - 2) == m1) && ((k2 - 1) == k1) || ((k1 - 1) == k2) || ((m2 + 2) == m1) && ((k2 - 1) == k1) || ((k1 - 1) == k2) || ((k2 - 2) == k1) && ((m2 - 1) == m1) || ((m1 - 1) == m2) || ((k2 + 2) == k1) && ((m2 - 1) == m1) || ((m1 - 1) == m2)) Console.WriteLine("Конь бьет");
                else Console.WriteLine("Конь не бьет");


            Console.WriteLine("Задание 2.2");
            int day, month, year, pros = 0, ost = 0, predd = 0, predm = 0, predy = 0, nextd = 0, nextm = 0, nexty = 0;
            int[] d = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.WriteLine("Введите день ");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год ");
            year = int.Parse(Console.ReadLine());
            int m = month;
            while (m > 0)
            { pros += d[m]; m--; }
            m = month;
            while (m < 13)
            { ost += d[m]; m++; }
            if (day == 1)
            {
                if (month == 1)
                {
                    predm = 12;
                    predy = year - 1;
                    predd = d[predm];
                }
                else
                {
                    predd = d[month - 1];
                    predm = month - 1;
                    predy = year;
                }
            }
            else
            {
                predd = day - 1;
                predm = month;
                predy = year;
            }
            if (day == d[month])
            {
                if (month == 12)
                {
                    nextm = 1;
                    nexty = year + 1;
                    nextd = 1;
                }
                else
                {
                    nextd = 1;
                    nextm = month + 1;
                    nexty = year;
                }
            }
            else
            {
                nextd = day + 1;
                nextm = month;
                nexty = year;
            }
            pros -= d[month] - day;
            ost -= day;
            Console.WriteLine("С начала года прошло {0} дней", pros);
            Console.WriteLine("До конца года осталось {0} дней", ost);
            Console.WriteLine("Вчерашняя дата - {0}:{1}:{2}", predd, predm, predy);
            Console.WriteLine("Завтрашняя дата - {0}:{1}:{2}", nextd, nextm, nexty); 
            */

             Console.WriteLine("Задание 2.3");
             Console.WriteLine("Числа Армстронга: ");
                 for (int i = 100; i < 999; i++)
            {
                    int a1 = i / 100;
                    int a2 = i / 10 % 10;
                    int a3 = i % 10;
                if (i == Math.Pow(a1, 3) + Math.Pow(a2, 3) + Math.Pow(a3, 3))
                    Console.WriteLine(i); 
        }

            Console.WriteLine("Задание 2.4");
            Console.Write("Введите сторону n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону m:");
            int m = int.Parse(Console.ReadLine());
            int mal = n * m;
            int k = 0;
            Console.WriteLine("Квадратов наименьшей площади: "+ mal); 
            while (n != m)
            {
                if (n > m) { n = n - m; k++; }
                else { m = m - n; k++; }   
            }
            k++;
            Console.WriteLine("Квадратов набольшей площади: "+ k);
            


            /*
                        Console.WriteLine("Задание 1");
                        Console.Write("Сторона а=");
                        int a = int.Parse(Console.ReadLine());
                        int p = a * 3;
                        Console.WriteLine("Периметр р=" + p);
                        double s = ((a * a) * Math.Sqrt(3)) / 4;
                        Console.WriteLine("Площадь s=" + s);

                        Console.WriteLine("Задание 2");
                        Console.Write("Число=");
                        int b = int.Parse(Console.ReadLine());
                        float q = b % 2;
                        if (q != 0) Console.WriteLine("Число нечетное");
                        else Console.WriteLine("Число четное");

                        Console.WriteLine("Задание 3");
                        Console.Write("x =");
                        float x = float.Parse(Console.ReadLine());
                        Console.Write("y =");
                        float y = float.Parse(Console.ReadLine());
                        if (x * x + y * y < 9 && y > 0) Console.WriteLine("внутри");
                        else if (x * x + y * y > 9 || y < 0) Console.WriteLine("вне");
                        else Console.WriteLine("на границе");

                        Console.WriteLine("Задание 4");
                        Console.Write("Номер месяца =");
                        int n = int.Parse(Console.ReadLine());
                        n = 12 - n;
                        switch (n)
                        {
                            case 0: Console.WriteLine("Месяц - декабрь. Новый год очень скоро"); break;
                            case 1: Console.WriteLine("январь"); break;
                            case 2: Console.WriteLine("февраль"); break;
                            case 3: Console.WriteLine("март"); break;
                            case 4: Console.WriteLine("апрель"); break;
                            case 5: Console.WriteLine("май"); break;
                            case 6: Console.WriteLine("июнь"); break;
                            case 7: Console.WriteLine("июль"); break;
                            case 8: Console.WriteLine("август"); break;
                            case 9: Console.WriteLine("сентябрь"); break;
                            case 10: Console.WriteLine("октябрь"); break;
                            case 11: Console.WriteLine("ноябрь"); break;
                            default:
                                Console.WriteLine("Вы ошиблись, нет такого месяца"); break;
                        }
                        Console.WriteLine(n);
                        */


        }
    }
}
