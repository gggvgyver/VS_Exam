using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Debug_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.FirstName = "kim";
            p.LastName = "soon Kwang";

            Console.WriteLine(p.FunkyNameBuilder());

            Console.ReadLine();
        }
    }
}
