using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        enum gradus : int
        {
            min = 0,
            krit = 72,
            max = 100,
        }
        static void Main(string[] args)
        {
            // int i = 10;	//объявление и инициализация целочисленной переменной i
            // Console.WriteLine(i);		//просмотр значения переменной
            // i = 100;		//изменение значение переменной
            //  Console.WriteLine(i);

            //int i;
            //Console.WriteLine(i);

            //const int i=10 ;	//объявление целочисленной константы i
            //Console.WriteLine(i);		//просмотр значения константы
            // i = 100;		//ошибка
            //Console.WriteLine(i);
            {
                //Console.WriteLine("Минимальная температура=" + (int)gradus.min);
                // Console.WriteLine("Критическая температура=" + (int)gradus.krit);
                // Console.WriteLine("Максимальная температура=" + (int)gradus.max);
            }
            //int i = 3, j = 4;
            //Console.WriteLine("{0} {1} {2}", j, i, j);

            //Console.WriteLine("Ура!\nСегодня \"понедельник\"!!!");

            //double x = Math.E;
            //Console.WriteLine("E={0,20}", x);
            //Console.WriteLine("E={0,10}", x);

            //double x = Math.E;
            //Console.WriteLine("E={0:##.###}", x);
            //Console.WriteLine("E={0:.####}", x);
            //Console.WriteLine("E={0:.######}", x); //измененная с точностью до 6 знаков после запятой

            //Console.WriteLine("C Format:{0,14:C} \t{0:C2}", 12345.678);
            //Console.WriteLine("D Format:{0,14:D} \t{0:D6}", 123);
            //Console.WriteLine("E Format:{0,14:E} \t{0:E8}", 12345.6789);
            //Console.WriteLine("G Format:{0,14:G} \t{0:G10}", 12345.6789);
            //Console.WriteLine("N Format:{0,14:N} \t{0:N4}", 12345.6789);
            //Console.WriteLine("X Format:{0,14:X} ", 1234);
            //Console.WriteLine("P Format:{0,14:P} ", 0.9);

            //string s = Console.ReadLine();
            //Console.WriteLine(s);

            //string s = Console.ReadLine();
            //int x = int.Parse(Console.ReadLine()); //преобразование введенной строки в число
            //Console.WriteLine(x);

            //string s = Console.ReadLine();
            //float x = float.Parse(s);
            //Console.WriteLine("Число={0:.###}", x); измененная программа, выводящая число с тремя знаками после запятой

            Console.Write("x=");
            string x = Console.ReadLine();
            float a = float.Parse(x);
            Console.Write("y=");
            string y = Console.ReadLine();
            float b = float.Parse(y);
            Console.Write("z=");
            string z = Console.ReadLine();
            float c = int.Parse(z);

            Console.WriteLine(a+b);

            Console.WriteLine("{0}+{1}={2}+{3}", a,b,b,a);

            Console.WriteLine(a + b + c);

            Console.WriteLine("{0:.#}", a * b);
                       
            Console.WriteLine("{0:.###}", a / b);

            Console.WriteLine("({0:.##}+{1:.##})+{2:.##}={3:.##}+({4:.##}+{5:.##})", a, b, c, a, b, c);

        }
    }
}

