using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<string> tree = new Tree<string>
            {
                "b",
                "c",
                "a",
                "d",
                "f",
                "g",
                "m",
                "e",
                "p"
            };

            foreach (string el in tree)
            {
                Console.Write($"{el} ");
            }

            Console.Read();
        }
    }
}
