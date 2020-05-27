using System;
using System.Linq;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "Лабораторная работа №8";
            Console.WriteLine(s);
            string[] sa = s.Split(' ');

            Array.Sort(sa);

            string saa = string.Join(" ", sa);
            Console.WriteLine(saa);
        }
    }
}