using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TMPS.KebabFactory
{
    public abstract class KebabModel
    {
        public string _kebabName;
        public string _doughType;
        public string _sauce;
        public string _vegetables;
        public string _meat;
        public string _catMeat;
        public ArrayList toppings = new ArrayList();

        public abstract void Order();

        public virtual void Cook()
        {
            Console.WriteLine("Ahmed is starting to cook your kebab at an intense pace!");
        }

        public virtual void CatchTheMeat()
        {
            Console.WriteLine("Vitalic went out to hunt down some good meat");
        }

        public virtual void BrewTheSauce()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
                Console.WriteLine("Oh no, it looks like the shaitan sauce debuffed you with a pancreatitis!");
            else
                Console.WriteLine("The sauce is safe");
        }

        public virtual void Pay()
        {
            Console.WriteLine("You just paid with a part of your soul for the legendary 30 lei kebab");
        }

        public abstract KebabModel Clone();
    }
}
