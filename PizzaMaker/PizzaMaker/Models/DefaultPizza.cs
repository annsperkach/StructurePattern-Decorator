using PizzaMaker.Abstracts;
using System;

namespace PizzaMaker.Models
{
    public class DefaultPizza : AbstractPizza
    {
        public override int GetAmountOfComponent()
        {
            return 0;
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}
