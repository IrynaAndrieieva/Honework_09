using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honework_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting gret = new Greeting();
            gret.Welcome();

            Candy cand = new Candy("jelly", 2, "non");

            Console.WriteLine("The instance of jelly:");
            cand.Print();

            Chocolate choc = new Chocolate("Chocolate", 3, "yes", "yes");

            Console.WriteLine("---------------------");
            Console.WriteLine("The instance of Chocolate:");
            choc.Print();
            Console.ReadLine();

        }
    }
}
