using PromotionMain.Models;
using System.Collections.Generic;

namespace PromotionMain.Rules
{
    public interface IRule
    {
        //Will test if this rule is applicable to items in the cart
        bool IsApplicable(List<char> cart);

        // Consumes items as per rule; returns modified list
        List<char> Apply(List<char> cart);

        //added for printing output
        string getPrettyMessage();
    }
}