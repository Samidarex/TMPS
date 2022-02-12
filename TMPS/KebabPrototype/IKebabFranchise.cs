using System;
using System.Collections.Generic;
using System.Text;
using TMPS.KebabFactory.Stores;

namespace TMPS.KebabPrototype
{
    public interface IKebabFranchise
    {
        MMLKebab GetMMLKebab();
        TwisterKebab GetTwisterKebab();

    } 
}
