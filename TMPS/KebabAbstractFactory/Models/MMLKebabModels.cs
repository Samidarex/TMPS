using System;
using System.Collections.Generic;
using System.Text;
using TMPS.KebabAbstractFactory.Interfaces;
using TMPS.KebabFactory;

namespace TMPS.KebabAbstractFactory.Models
{
    public class MMLKebabModels : KebabModel
    {
        IKebabComponents kebabComponents;

        public MMLKebabModels(IKebabComponents _kebabComponents)
        {
            kebabComponents = _kebabComponents;
            _kebabName = "Thirty lei kebab";
            _doughType = "Muchnoe";
            _sauce = "Garlic with mayo";
            _vegetables = "Patrunjel with tomatoes and cucumbers";
            _meat = "house speciality";
            toppings.Add("Nr.1 cheese");
            toppings.Add("Champinions from Rascanovca forest");
            toppings.Add("Extra meat");
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
