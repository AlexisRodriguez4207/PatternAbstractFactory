using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rodriguez Perez Carlos Alexis 20210627
namespace Desarrollo_Patrón_Abstract_Factory.PizzasStores
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            Console.WriteLine("--- Making a " + pizza.getName() + " ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
