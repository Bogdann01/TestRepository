using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invatat_1._1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Scrie numele aici: "+ Environment.NewLine);
            string nume = Console.ReadLine();

            Console.WriteLine("Salut, " + nume + '!');
            Console.ReadLine();
        }
    }
}
