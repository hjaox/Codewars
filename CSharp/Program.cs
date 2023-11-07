using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Regex.IsMatch("" , @"^[0-9]$"));
            Console.ReadLine();
        }
    }
}