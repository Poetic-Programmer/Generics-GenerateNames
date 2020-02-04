using System;
using System.Collections;
using System.Collections.Specialized;
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

            List<string> newNames = CopyAtMost<string>(names, 20);
            PrintNames(newNames);
        }

        static List<String> GenerateNames()
        {
            List<string> names = new List<string>();
            names.Add("batman");
            names.Add("robin");
            names.Add("nightwing");
            names.Add("batwoman");
            return names;
        }
        static List<T> CopyAtMost<T>(List<T> input, int maxElecments)
        {
            int actualCount = Math.Min(input.Count, maxElecments);
            List<T> ret = new List<T>(actualCount);
            for(int i = 0; i < actualCount; ++i)
            {
                ret.Add(input[i]);
            }
            return ret;
        }

        static void PrintNames(List<string> names)
        {
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
