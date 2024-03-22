using Desarrollo_Patrón_Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_Patrón_Abstract_Factory
{
    public abstract class Pizza
    {
        public Dough dough;
        public Sauce sauce;
        public Veggies[] veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clams;

        public string name;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350°.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }

        public void SetName(string name)
        {
           this.name = name;
        }

        public string getName()
        {
            return name;
        }

        //public string ToString()
        //{
        //    StringBuilder print = new StringBuilder();
        //    print.Append("---- " + name + " ----\n");
        //    if (dough != null)
        //    {
        //        print.Append(dough + "\n");
        //    }
        //    if (sauce != null)
        //    {
        //        print.Append(sauce + "\n");
        //    }
        //    if (cheese != null)
        //    {
        //        print.Append(cheese + "\n");
        //    }
        //    if (veggies != null)
        //    {
        //        for (int i = 0; i < veggies.Length; i++)
        //        { 
        //            print.Append(veggies[i]);
        //            if (i < veggies.Length - 1)
        //            {
        //                print.Append(", ");

        //            }
        //        }
        //        print.Append("\n");
        //    }

        //}


    }
}
