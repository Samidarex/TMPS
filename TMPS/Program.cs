using System;

namespace TMPS
{
    class Program
    {
        static void Main(string[] args)
        {
            var MMLKebab = KebabSingletone.KebabNetwork.Instance.KebabFranchise.GetMMLKebab();
            var TwisterKebab = KebabSingletone.KebabNetwork.Instance.KebabFranchise.GetTwisterKebab();

            var orderMML = MMLKebab.OrderKebab("kebab");
            var orderTwister = TwisterKebab.OrderKebab("kebab");

            var kebabClone = orderMML.Clone();

            Console.WriteLine(kebabClone._kebabName);

            Console.ReadKey();
        }
    }
}
