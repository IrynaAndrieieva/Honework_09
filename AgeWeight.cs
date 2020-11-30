using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honework_09
{
    class AgeWeight
    {

        public void Preschooler()
        {
            Console.WriteLine("Candy weight: 1 kg");
        }

        public void PrimaryClasses()
        {
            Console.WriteLine("Candy weight: 1,5 kg");
        }

        public void HighSchool()
        {
            Console.WriteLine("Candy weight: 2 kg");
        }

        public void AgeRight(int age)
        {

            switch (age)
            {

                case 1:
                    Preschooler();
                    break;
                case 2:
                    PrimaryClasses();
                    break;
                case 3:
                    HighSchool();
                    break;

            }


        }


    }
}
