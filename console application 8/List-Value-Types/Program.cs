using System;

namespace List_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte a = 127;
            Byte b = 255;
            Int16 i1 = 16;
            Int32 i2 = 32;
            Int64 i3 = 64;
            String s = "";
            Exception ex = new Exception();
            Object[] obj = { a, b, i1, i2, i3, s, ex };

            foreach (var a1 in obj)
            {
                Console.WriteLine($"{a1.GetType()}:\t{a1.GetType().IsValueType}");
            }
        }
    }
}