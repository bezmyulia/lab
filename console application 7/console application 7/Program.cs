using System;
using System.Runtime.CompilerServices;

namespace Laborr7
{
    class Program
    {
        class Person
        {
            private string fam;
            private string status;
            private int salary;
            private int age;
            private string health;

            public Person()
            {
                this.fam = "";
                this.status = "Продавец";
                this.health = "Здоров";
            }
            public string Fam
            {
                set
                { if (fam == "") fam = value; }
                    get { return (fam); }
            }

            public string Status
            {
                get { return (status); }
            }

            public int Salary
            {
                set { salary = value; }
            }

            public int GetSalary()
            {
                return this.salary;
            }

            public int Age
            {
                set { age = value; }
                get { return (age); }
            }

            public string GetHelth()
            {
                return this.health;
            }
        }
        static void Main()
        {
            Person a = new Person();
            a.Fam = "Сергеев";
            a.Age = 19;
            a.Salary = 12000;

            Console.WriteLine($"Фамилия: {a.Fam}\nВозраст: {a.Age}\nСтатус: {a.Status}\n" + $"Заработная плата: {a.GetSalary()}\nЗдоровье: {a.GetHelth()}");

        }

    }
}