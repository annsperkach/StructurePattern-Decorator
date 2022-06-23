using PizzaMaker.Abstracts;
using System;

namespace PizzaMaker.Decorators
{
    internal class BeckonPizzaDecorator: PizzaDecorator
    {
        public BeckonPizzaDecorator(AbstractPizza pizza) : base(pizza) { }

        public override int GetAmountOfComponent()
        {
            return _pizza.GetAmountOfComponent() + 1;
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 110;
        }
    }
}
