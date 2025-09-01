using SupportingProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetpackageProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();

            int a = 5, b = 6;
            int c = s.Add(a, b);
            Console.WriteLine($"Sum is {c}");
            Console.ReadLine();

        }
    }
}
