using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._4
{
    class Program
    {
        static void Main()
        {
            Int16 i1 = 1;
            Int32 i2 = 2;
            double db = 110;

            Console.WriteLine($" double -> Int16: {db = i1}");
            Console.WriteLine($" double -> Int32: {db = i2}");
            Console.WriteLine($" Int32->Int16: {i2 = i1}");
            Console.WriteLine($" Int16->Int32: {i1 = i2}"); //  диапазон исходного числа меньше
            Console.WriteLine($" Int16->double: {i1 = db}"); // из типов double и decimal не поддерживается неявное преобразование
            Console.WriteLine($" Int32->double: {i2 = db}"); // не поддерживается
        }
    }
}