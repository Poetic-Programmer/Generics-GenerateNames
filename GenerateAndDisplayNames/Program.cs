using System;
using System.Collections;
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
            var names = GenerateNames();
            PrintNames(names);
        }

        static ArrayList GenerateNames()
        {
            ArrayList names = new ArrayList();
            names.Add("batman");
            names.Add("robin");
            names.Add("nightwing");
            names.Add("batwoman");
            return names;
        }
        static void PrintNames(ArrayList names)
        {
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
