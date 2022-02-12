using System;
using System.Collections.Generic;
using System.Text;
using TMPS.KebabAbstractFactory;
using TMPS.KebabAbstractFactory.Interfaces;
using TMPS.KebabAbstractFactory.Models;

namespace TMPS.KebabFactory.Stores
{
    public class MMLKebab : Kebabanator
    {
        protected override KebabModel CreateKebab(string type)
        {
            KebabModel thirtyLeiKebab = null;
            IKebabComponents kebabComponents = new MMLKebabComponents();
            if (type == "kebab") 
                thirtyLeiKebab = new MMLKebabModels(kebabComponents);

            return thirtyLeiKebab;
        }
    }
}
