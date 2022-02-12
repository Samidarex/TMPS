using System;
using System.Collections.Generic;
using System.Text;
using TMPS.KebabPrototype;

namespace TMPS.KebabSingletone
{
    public sealed class KebabNetwork
    {
        private KebabNetwork() { }

        public static KebabNetwork Instance { get; } = new KebabNetwork();

        public IKebabFranchise KebabFranchise { get; } = new KebabFranchise();
    }
}
