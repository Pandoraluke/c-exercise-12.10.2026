using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data;

namespace parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            passbyvalue(i);
            Console.WriteLine($"main: pbv:{i}");

            int j = 1;
            passbyreference(ref j);
            Console.WriteLine($"main: pbref: {j}");


            List<int> list = new List<int>();
            passbyreference(list);
            Console.WriteLine($"main: pbref: {list.Count}");


            int k;
            PassByOut(out k);
            Console.WriteLine($"main: pbo: {k}");

        }

        private static void PassByOut(out int k)
        {
            k = 1;
            k++;
            Console.WriteLine($"methods: pbo: {k}");
        }
        private static void passbyreference(ref int j)
        {
            j++;
            Console.WriteLine($"method: pbref: {j}");
        }
        private static void passbyreference(List<int> list)
        {
            list.Add(100);
            Console.WriteLine($"method: pbref: {list.Count}");
            Print(new List<int>(list));
        }

        private static void Print(List<int> list)
        {
            Console.WriteLine($"print: pbref: {list.Count}");
            Console.WriteLine($"no print, hehe");
            list.Clear();
       
        }

        // ctrl r r, changes the name of the method everywhere

        private static void passbyvalue(int i)
        {
            i++;
            Console.WriteLine($"method: pbv:{i}");
        }
    }
}