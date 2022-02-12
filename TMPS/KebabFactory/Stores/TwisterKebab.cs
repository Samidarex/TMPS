using System;
using System.Collections.Generic;
using System.Text;
using TMPS.KebabAbstractFactory;
using TMPS.KebabAbstractFactory.Interfaces;
using TMPS.KebabAbstractFactory.Models;

namespace TMPS.KebabFactory.Stores
{
    public class TwisterKebab : Kebabanator
    {
        protected override KebabModel CreateKebab(string type)
        {
            KebabModel twistKebab = null;
            IKebabComponents kebabComponents = new TwisterKebabComponents();
            if (type == "kebab")
                twistKebab = new TwisterKebabModels(kebabComponents);

            return twistKebab;
        }
    }
}
