using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Daniel";
            String verb = "pooping";
            String adjective = "laconically";

            writeThis(name, verb, adjective);
            Console.Write(group(10, 15, 20));
            Console.Write("Hello World!");
            Console.Read();
        }
        public static void writeThis(String name, String verb, String adjective)
        {
            String total = "Hello" + name + ".";
            total += "I've been " + verb + " until we met. I've been so " + adjective + " nervous for this moment.";
            Console.Write(total);
        }

        public static String group(int a, int b, int c)
        {
            String total = "" + a + ", " + b + ", " + c + "!";
            return total;
        }

    }
}
