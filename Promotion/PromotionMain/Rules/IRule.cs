using PromotionMain.Models;
using System.Collections.Generic;

namespace PromotionMain.Rules
{
    public interface IRule
    {
        //Will test if this rule is applicable to items in the cart
        bool IsApplicable(List<char> cart);

        void Apply(List<char> cart);
    }
}