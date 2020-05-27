using System;

namespace Laborr8
{
    class Program
    {
        class Train
        {
            public string number;
            public string mes;
            public int kolvovag;
            public enum typeTrain : byte { skTrain, pasTrain, tTrain };
            public typeTrain a;

            public Train(string a, string b, int c, int s)
            {
                this.number = a;
                this.mes = b;
                this.kolvovag = c;
                this.a = (typeTrain)s;
            }

            class FirmTrain : Train
            {
                public string nameFirm;
                public double kPrice;
                public FirmTrain(string number, string mes, int kolvovag, int a, string b, double e) : base(number, mes, kolvovag, a)
                {
                    this.number = number;
                    this.mes = mes;
                    this.kolvovag = kolvovag;
                    this.a = (typeTrain)a;
                    this.nameFirm = b;
                    this.kPrice = e;
                }
                public override string ToString()
                {
                    return $"Отправление поездов:\n\tНомер: {number}\tСообщением: {mes}\n\tКоличество вагонов: {kolvovag}\tтип: {a}" +
                           $"\tФирменное название: {nameFirm}\tКоэффицент удорожания: {kPrice}";
                }
            }
            static void Main(string[] args)
            {
                FirmTrain p = new FirmTrain("601", "Москва - Адлер", 5, 1, "Ласточка", 1.2);
                Console.WriteLine(p.ToString());
            }
        }
    }
}