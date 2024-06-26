﻿using Desarrollo_Patrón_Abstract_Factory.IngredientFactory;
using Desarrollo_Patrón_Abstract_Factory.PizzasTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_Patrón_Abstract_Factory.PizzasStores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("New York Style Veggie Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("New York Style Clam Pizza");
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("New York Style Pepperoni Pizza");
            }
            return pizza;
        }
    }
}
