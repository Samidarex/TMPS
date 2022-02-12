using System;
using System.Collections.Generic;
using System.Text;
using TMPS.KebabFactory.Stores;

namespace TMPS.KebabPrototype
{
    public class KebabFranchise : IKebabFranchise
    {
        public MMLKebab GetMMLKebab() => new MMLKebab();

        TwisterKebab IKebabFranchise.GetTwisterKebab() => new TwisterKebab();
    }
}
