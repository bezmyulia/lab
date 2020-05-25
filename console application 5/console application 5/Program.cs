using System;
using System.Linq;
using System.Text;

namespace Laborr5
{
    class String
    {
        public static void SumInWords(int a)
        {
            string[] units = new[] { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", };
            string[] decades = new[] { "десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ", "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто ", };
            string[] hundreds = new[] { "сто ", "двести ", "триста ", "четыреста ", "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот ", };
            string[] thousands = new[] { "тысяча ", "две тысячи ", "три тысячи ", "четыре тысячи ", "пять тысяч ", "шесть тысяч ", "семь тысяч ", "восемь тысяч ", "девять тысяч ", };

            string nameMoney = "";
            int unit = a % 10;
            int decade = a % 100 / 10;
            int hundred = a % 1000 / 100;
            int thousand = a / 1000;

                if (thousand != 0)
            {
                nameMoney += thousands[thousand - 1];
            }
                if (hundred != 0)
            {
                nameMoney += hundreds[hundred - 1];
            }
                if (decade != 0)
            {
                nameMoney += decades[decade - 1];
            }
                if (unit != 0)
            {
                nameMoney += units[unit - 1];
            }
            Console.WriteLine(nameMoney);
        }

        public static void SplitJoin(string a)
        {
            string[] SimpleSentences, Words;
            SimpleSentences = a.Split('.');
            Words = a.Split(' ');

            for (int i = 0; i < SimpleSentences.Length; i++)
                Console.WriteLine(SimpleSentences[i]);

            for (int i = 0; i < Words.Length; i++)
                Console.WriteLine(Words[i]);

            Console.WriteLine(string.Join(" ", Words));
        }


        public static void TestStringBuilder()
        {
            StringBuilder str1 = new StringBuilder("String1 – example of StringBuilder");
            StringBuilder str2 = new StringBuilder("Лабота со строками.");
                for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] == 'Л')
                {
                    str2[i] = 'Р';
                }
            }
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

        public static void PrintCharAr(char[] a)
        {
            foreach (char a1 in a)
            {
                Console.Write(a1);
            }
        }

        public static string CharArrayToString(char[] a)
        {
            string str = new string(a);
            return str;
        }

        public static int IndexOfStr(char[] s1, char[] s2)
        {
            int a;

            for (int i = 0; i < s1.Length; i++)
                if (s1[i] == s2[0])
                {
                    int k = 0;
                    int num = i;
                    a = i;
                    for (int j = 0; j < s2.Length; j++)
                        if (s1[num] == s2[j])
                        {
                            k++;
                            num++;
                        }
                        else continue;
                    if (k == s2.Length) return a;
                }
            return -1;
        }

        public static void TestIndexSym(string a, string b)
        {
            int index;
            Console.Write("Строка \"{0}\" ", b);
            for (int i = 0; i < a.Length; i++)
                if (a[i] == b[0])
                {
                    int ind = 0;
                    int ii = i;
                    index = i;
                    for (int j = 0; j < b.Length; j++)
                        if (a[ii] == b[j])
                        {
                            ind++;
                            ii++;
                        }
                        else continue;
                    if (ind == b.Length) Console.Write("начинается с {0} заканчивается {1} ", index, index + ind - 1);
                }
        }

        static void Main()
        {
            string str = "t e s t";
            Console.WriteLine(str[0]);
            string str1 = "Строка1";
            string str2 = new string('s', 5);
            Console.WriteLine(str2);
            char[] charray = { 't', 'e', 's', 't' };
            string str3 = new string(charray);
            string strr1 = str1;
            Console.WriteLine(strr1);
               if (str1 == str3)
                {
                Console.WriteLine("Да");
                }
            else Console.WriteLine("Нет");
               if (strr1 != str3)
                {
                Console.WriteLine("Да");
                }
            string strr2 = strr1 + str3;
            Console.WriteLine(strr2);
            Console.WriteLine(strr2[5]);

            string message = "слово /*слово student*/ слово /*!*/3";
            string comment = "";
            Console.WriteLine();

            int i = 0;

            while (i < message.Length - 1)
            {
                if (message[i] == '/' && message[i + 1] == '*')
                {
                    i += 2;
                    while (!(message[i] == '*' && message[i + 1] == '/'))
                    {
                        comment += message[i];
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(comment);
            Console.WriteLine();
            string delstud = "";
            string student = "";
            for (i = 0; i < message.Length; i++)
            {
                if (message[i] == 's' && message[i + 6] == 't')
                {
                    for (int j = i; j < i + 7; j++)
                    {
                        student += message[j];
                    }

                    if (student == "student")
                    {
                        i += 7;
                    }
                }
                delstud += message[i];
            }
            Console.WriteLine(delstud);

            String.SumInWords(a: 5000);

            string a = "C#. Лаборатоная работа №5.";
            String.SplitJoin(a);

            Console.WriteLine();
            String.TestStringBuilder();

            Console.WriteLine();
            StringBuilder sb1 = new StringBuilder("Работа со строками.");
            StringBuilder sb2 = new StringBuilder("Преподаватель: Васильев П.В.");
            Console.WriteLine(sb1.Append(sb2));
            Console.WriteLine(sb2.Insert(0, "У нас по этой дисциплине экзамен."));

            StringBuilder sb3 = new StringBuilder();
            int num = 1;
            string[] mes =
                { "Один",  "Два",  "Три", "Четыре", "Пять"};
            foreach (string mes1 in mes)
            {
                sb3.AppendFormat($"{num++}:[{mes1}] ");
                Console.WriteLine(sb3);
            }

            Console.WriteLine();
            Console.WriteLine($"Текущая емкость буфера: [{sb2.Capacity}]");
            Console.WriteLine($"Максимальная емкость буфера: [{sb2.MaxCapacity}]");
            Console.WriteLine($"Новая емкость этого экземпляра: [{sb1.EnsureCapacity(50)}]");

            Console.WriteLine();

            char[] ch1 = { 'H', 'E', 'L', 'L', 'O', '!' };
            string str4 = "";
            String.PrintCharAr(ch1);
            Console.WriteLine();
            str4 = CharArrayToString(ch1);
            Console.WriteLine(str4);

            char[] ch2 = { 'П', 'а', 'в', 'е', 'л', 'В', 'л', 'а', 'д', 'и', 'м', 'и', 'р', 'о', 'в', 'и', 'ч' };

            Console.WriteLine(IndexOfStr(ch1, ch2));

            string str5 = "А я 1?";
            string str6 = "А";
            TestIndexSym(str5, str6);
        }
    }
}