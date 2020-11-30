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
            Console.WriteLine("This child has diabetes, so his gift will contain sugar-free sweets: ");

            SugarFreeChocolate sugfrch = new SugarFreeChocolate("Chocolate", 0, "yes", "yes");
            Console.WriteLine("---------------------");
            Console.WriteLine("The instance of Chocolate from diabetes:");
            sugfrch.Print();

            Console.ReadLine();
        }

        public void LactoseIntolerance()
        {
            Console.WriteLine("This child is lactose intolerant, so his gift will contain lactose - free sweets:");
            Candy cand = new Candy("jelly", 2, "non");

            Console.WriteLine("The instance of jelly:");
            cand.Print();
            Console.ReadLine();
        }

        public void Non()
        {
            Console.WriteLine("This child does not have diabetes or lactose intolerance, so his gift will contain the usual sweets: ");
            Chocolate choc = new Chocolate("Chocolate", 3, "yes", "yes");

            Console.WriteLine("---------------------");
            Console.WriteLine("The instance of Chocolate:");
            choc.Print();
            Console.ReadLine();
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
