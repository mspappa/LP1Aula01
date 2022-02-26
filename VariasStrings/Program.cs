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
            string e = String.Format("Y é {1}, X é {0}", x, y);

            string x = "a" + 2;
            string y = "abc" + x;

            string z = $"valor de x é {x}";
            string w = $"{x} mais {y} é igual a {x + y}";

            double xx = 0.12345;
            int ii = 18;

            string xx1 = $"xx={xx:f2}. e .{xx:p1}";
            string ii1 = $"ii={ii:x}. e .{ii:m}";

            Console.WriteLine(a + "\n" + b + "\n" + c + "\n" + d + "\n" + e);
            Console.WriteLine("\n" + x + "\n" + y);
            Console.WriteLine("\n" + z + "\n" + w);
            Console.WriteLine(@"Verbatim com x = {0}", x);
            Console.WriteLine(xx1 + "\n" + ii1 + "\n");
        }
    }
}
