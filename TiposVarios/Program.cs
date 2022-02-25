// See https://aka.ms/new-console-template for more information
using System;

namespace OlaMundo
///
{
    class Program
    ///
    {
        static void Main(string[] args)
        {
            int i = 0x10;
            uint j = 0x10U;
            int x = 0b1011_0110;
            int n = 0b10110110;
            double y = 1_712_432.23;

            char copyrightSymbol = '\u00A9';
            char newLine = '\u000A';

            float a = 3.1415f;
            decimal b = 3.1415m;
            long c = 3L;

            Console.WriteLine(i + " " + j + " " + x + " " + n + "" + y);
            Console.WriteLine(copyrightSymbol + " " + newLine);
            Console.WriteLine(a + " " + b + " " + c);
        }
    }
}
