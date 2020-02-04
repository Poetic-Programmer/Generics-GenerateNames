using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAndDisplayNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = GenerateNames();
            PrintNames(names);
        }

        static string[] GenerateNames()
        {
            string[] names = new string[4];
            names[0] = "batman";
            names[1] = "robin";
            names[2] = "nightwing";
            names[3] = "batwoman";
            return names;
        }

        static void PrintNames(string[] names)
        {
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
