using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace HW4_C_Sharp_P_Kh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 3:

            string tempStr = "Hello, world!";
            Encoder encoder = new Encoder();
            encoder.AddText(tempStr);
            encoder.Encrypt();
            Console.WriteLine(encoder.GetText());
            Decryptor decryptor = new Decryptor();
            decryptor.AddText(encoder.GetText());
            decryptor.Decipher();
            Console.WriteLine(decryptor.GetText());
            Console.ReadLine();

            // Task 5:


            string expression = "99 + 10 - 39,5 + 55,1 - 100,1 - 22,99 + 1,01";
            Console.WriteLine($"{expression} = {Calc.GetResult(expression)}");
            expression = "1 + 12 + 123 + 12345 + 12345678 - 999,5 - 9999,5 - 99999,5 - 999999,9 - 9999999,9";
            Console.WriteLine($"{expression} = {Calc.GetResult(expression)}");
            Console.ReadLine();
        }
    }
}
