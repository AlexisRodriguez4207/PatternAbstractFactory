using Desarrollo_Patrón_Abstract_Factory.IngredientFactory;
using Desarrollo_Patrón_Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_Patrón_Abstract_Factory.PizzasTypes
{
    public class CheesePizza : Pizza
    {
        public PizzaIngredientFactory _ingredientFactory;

        public CheesePizza(PizzaIngredientFactory _ingredientFactory)
        {
            this._ingredientFactory = _ingredientFactory;
        }

        public override void Prepare()
        {
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            Console.WriteLine("Preparing " + name + " With " + dough.ToString() + ", " + sauce.ToString() + "\n and  " + cheese.ToString());
            
        }
    }
}
