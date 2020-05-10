using System;

namespace Laborr4_4
{
    class Student
    {
        private string name;
        private object sumb;
        private static Random rnd = new Random();

        public void SetValue(string a)
        {
            name = a;
            sumb = rnd.Next(1, 100);
        }
        public void Print()
        {
            Console.WriteLine($"{name} {sumb}");
        }
        public static Student[] InitAr(Student[] stud)
        {
            for (int i = 0; i < stud.Length; i++)
                stud[i] = new Student();
            return stud;
        }
        static void Main()
        {
            Student[] stud = new Student[3];

            for (int i = 0; i < stud.Length; i++)
            {
                Student.InitAr(stud);
            }
            stud[0].SetValue("Юлия:");
            stud[1].SetValue("Диана:");
            stud[2].SetValue("Луиза:");

            stud[0].Print();
            stud[1].Print();
            stud[2].Print();
        }
    }
}