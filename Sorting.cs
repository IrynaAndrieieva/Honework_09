using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honework_09
{
    class Sorting
    {
        public void Diabetes()
        {

        }

        public void LactoseIntolerance()
        {

        }

        public void Non()
        {

        }

        public void PushChoice(string choice)
        {

            switch (choice)
            {

                case "A":
                    Diabetes();
                    break;
                case "B":
                    LactoseIntolerance();
                    break;
                case "C":
                    Non();
                    break;

            }


        }
    }
}
