using Desarrollo_Patrón_Abstract_Factory.DifferentsTypes;
using Desarrollo_Patrón_Abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo_Patrón_Abstract_Factory.IngredientFactory
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }
        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new BlackOlives(), new Spinach() ,new EggPlants()};
            return veggies;
        }
        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
        public Clams CreateClams()
        {
            return new FreshClams();
        }
    }
}
