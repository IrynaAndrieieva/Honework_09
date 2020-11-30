using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honework_09
{
    public class Candy
    {
        public string name;
        public int sugar;
        public string lactose;

        public Candy(string Name, int Sugar, string Lactose)
        {
            this.Name = Name;
            this.sugar = Sugar;
            this.lactose = Lactose;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }

        public string Lactose
        {
            get { return lactose; }
            set { lactose = value; }
        }
        public void Print()
        {
            Console.WriteLine($"Name = {name}");
            Console.WriteLine($"Sugar = {sugar} gram");
            Console.WriteLine($"Lactose = {lactose}");
            Console.ReadLine();
        }

    }

    public class Chocolate : Candy
    {
        
        protected string cacao;
        
        public Chocolate(string name, int sugar, string lactose, string cacao) :
            base(name, sugar, lactose)
        {
            base.name = name; 
            this.sugar = sugar;
            this.lactose = lactose;
            this.cacao = cacao;
        }

        public string Cacao
        {
            get { return cacao; }
            set { cacao = value; }
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Cacao = {cacao}");
            Console.ReadLine();
        }
    }

    public class SugarFreeChocolate : Chocolate
    {
        public SugarFreeChocolate(string name, int sugar, string lactose, string cacao)
            : base(name, sugar, lactose, cacao)
        { }
    }

    public class Pastila : Candy
    {
        protected string fruit;
        public Pastila(string name, int sugar, string lactose)
            :base(name, sugar, lactose)
        {
            base.name = name;
            this.sugar = sugar;
            this.lactose = lactose;
        }

        public string Fruit
        {
            get { return fruit; }
            set { fruit = value; }
        }
    }
}
