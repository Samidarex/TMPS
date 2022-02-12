using System;
using System.Collections.Generic;
using System.Text;

namespace TMPS.KebabFactory
{
    public abstract class Kebabanator
    {
        protected abstract KebabModel CreateKebab(String type);
        public KebabModel OrderKebab(String type)
        {
            var luxuryKebab = CreateKebab(type);
            luxuryKebab.Order();
            luxuryKebab.Pay();
            luxuryKebab.CatchTheMeat();
            luxuryKebab.BrewTheSauce();
            luxuryKebab.Cook();
            return luxuryKebab;
        }
    }
}
