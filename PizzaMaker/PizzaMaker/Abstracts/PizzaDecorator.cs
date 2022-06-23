using System;

namespace PizzaMaker.Abstracts
{
    public abstract class PizzaDecorator: AbstractPizza 
    {
        protected AbstractPizza _pizza;

        public PizzaDecorator(AbstractPizza pizza)
        {
            _pizza = pizza;
        }

        public override int GetAmountOfComponent()
        {
           return _pizza.GetAmountOfComponent();
        }

        public override int GetCost()
        {
           return _pizza.GetCost();
        }
    }
}
