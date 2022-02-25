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
            string b = @"Nao é um codigo Unicode \u1234, nao é nova linha \n";
            string c = "\"Esta string está entre aspas\"";
            string d = @"""Esta string está entre aspas""";

            string x = "a" + 2;
            string y = "abc" + x;

            string z = $"valor de x é {x}";
            string w = $"{x} mais {y} e’ igual a {x + y}";

            String.Format("Y e’ {1}, X e’ {0}", x, y);
            

            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d);
            Console.WriteLine("\n" + x + "\n" + y);
            Console.WriteLine("\n" + z + "\n" + w);
            Console.WriteLine(@"Verbatim com x = {0}", x);
        }
    }
}
