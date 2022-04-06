using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Angka angka = new Angka();
            Console.WriteLine("Minimun #1: {0}", angka.FindMinimum(3, 1));
            Console.WriteLine("Minimun #2: {0}", angka.FindMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", angka.FindMaximum(3, 1));
            Console.WriteLine("Maximum #2: {0}", angka.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
