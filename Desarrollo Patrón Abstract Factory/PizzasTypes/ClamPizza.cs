using Desarrollo_Patrón_Abstract_Factory.IngredientFactory;
using Desarrollo_Patrón_Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_Patrón_Abstract_Factory.PizzasTypes
{
    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clams = ingredientFactory.CreateClams();
            Console.WriteLine("Preparing " + name + " With " + dough.ToString() + ", " + sauce.ToString() + "\n and  " + cheese.ToString() + " and " + clams.ToString());
        }
    }
}
