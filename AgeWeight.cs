using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honework_09
{
    class AgeWeight
    {
        public void AgeRight(int age)
        {
            //switch { }
            if (age > 18)
            {
                Console.WriteLine("You write wrong age!");
            }
            else if (age < 4)
            {
                Console.WriteLine("You write wrong age!");
            }
            else
            {
                Console.WriteLine("You write right age!");
            }
        }
    }
}
