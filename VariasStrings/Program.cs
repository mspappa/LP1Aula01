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
            string a = "Um tab\t e um copyright\u03A9";
            string b = @"Nao e’ um codigo Unicode \u1234, nao e’ nova linha \n";
            string c = "\"Esta string esta ’ entre aspas\"";
            string d = @"""Esta string esta ’ entre aspas""";

            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d);
        }
    }
}
