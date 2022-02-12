using System;
using System.Collections.Generic;
using System.Text;
using TMPS.KebabAbstractFactory.Interfaces;
using TMPS.KebabFactory;

namespace TMPS.KebabAbstractFactory.Models
{
    public class TwisterKebabModels : KebabModel
    {
        IKebabComponents kebabComponents;

        public TwisterKebabModels(IKebabComponents _kebabComponents)
        {
            kebabComponents = _kebabComponents;
            _kebabName = "Twist de pui";
            _doughType = "Din papusoi";
            _sauce = "BBQ";
            _vegetables = "Marinated cucumbers and tomatoes";
            _meat = "Chicken";
            toppings.Add("Cheese");
        }

        public override KebabModel Clone()
        {
            return this.MemberwiseClone() as KebabModel;
        }

        public override void Order()
        {
            Console.WriteLine("One kebab pls");
            kebabComponents.makeDough();
            kebabComponents.catchMeat();
            kebabComponents.createSauce();
        }
    }
}
