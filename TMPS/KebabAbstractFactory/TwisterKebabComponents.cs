using System;
using System.Collections.Generic;
using System.Text;
using TMPS.KebabAbstractFactory.Interfaces;

namespace TMPS.KebabAbstractFactory
{
    public class TwisterKebabComponents : IKebabComponents
    {
        public KebabBase.Meat catchMeat()
        {
            Console.WriteLine("Petya went to Botanica to catch the juciest meat from the city.");
            return new KebabBase.Meat();
        }

        public KebabBase.Sauce createSauce()
        {
            Console.WriteLine("The legendary alchemist Sergay started brewing the sauce.");
            return new KebabBase.Sauce();
        }

        public KebabBase.Dough makeDough()
        {
            Console.WriteLine("Angela remembered his spouse Andrey face, and started beating the dough with the power of 2 Toyota Prius.");
            return new KebabBase.Dough();
        }
    }
}
