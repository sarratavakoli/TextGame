using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("First Name | Last Name  |   Age");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Bill", "Gates", 51));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Edna", "Parker", 114));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Johnny", "Depp", 44));
            Console.WriteLine("-------------------------------");
        }
    }
}
