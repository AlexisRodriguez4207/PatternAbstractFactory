using Desarrollo_Patrón_Abstract_Factory.IngredientFactory;
using Desarrollo_Patrón_Abstract_Factory.PizzasTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_Patrón_Abstract_Factory.PizzasStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Chicago Style Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Chicago Style Veggie Pizza");
            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Chicago Style Clam Pizza");
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Chicago Style Pepperoni Pizza");
            }
            return pizza;
        }
    }
}
