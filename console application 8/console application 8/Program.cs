using System;

namespace Laborr8
{
    class Program
    {
        struct Train
        {
            public int number;
            public string mes;
            public int kolvovag;
            public enum typeTrain : byte { skTrain, pasTrain, tTrain };
            public typeTrain a;

            public Train(int a, string b, int c, typeTrain s)
            {
                this.number = a;
                this.mes = b;
                this.kolvovag = c;
                this.a = (typeTrain)s;
            }

            public override string ToString()
            {
                return $"Отправление поездов:\n\tНомер: {number}\tСообщением: {mes}\n\tКоличество вагонов: {kolvovag}\tтип: {a}";
            }
        }
        static void Main(string[] args)
        {
            Train p = new Train(601, "Москва - Адлер", 5, 0);
            Console.WriteLine(p.ToString());
        }
    }
}