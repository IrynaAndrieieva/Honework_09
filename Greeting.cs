using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honework_09
{
    class Greeting
    {
        public void Welcome()
        {
            Console.WriteLine("Hello! This app can help you make gifts from children considering age and their particular qualities");
            Console.WriteLine("Plese< write and choice next information");
            Console.WriteLine("Write age (4-18)");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choice particular qualities:");
            Console.WriteLine("push: A - diabetes, B - lactose intolerance, C - non");
            string choice = Console.ReadLine();

            AgeWeight agwei = new AgeWeight();
            agwei.AgeRight(age);

            Sorting sort = new Sorting();
            sort.PushChoice(choice);
        }
    }
}
