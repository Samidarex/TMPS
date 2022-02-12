using System;
using System.Collections.Generic;
using System.Text;
using static TMPS.KebabAbstractFactory.KebabBase;

namespace TMPS.KebabAbstractFactory.Interfaces
{
    public interface IKebabComponents
    {
        Dough makeDough();
        Sauce createSauce();
        Meat catchMeat();

    }
}
