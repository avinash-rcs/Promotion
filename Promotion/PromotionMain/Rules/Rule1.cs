using System;
using System.Collections.Generic;
using PromotionMain.Models;
using System.Linq;

namespace PromotionMain.Rules
{
    public class Rule1: IRule
    {
        char _skutype;
        int n;
        // Instatiantes this rule with set parameters of n and SKU type
        public Rule1(char SKUtype,int n)
        {
            this._skutype=SKUtype;
            this.n = n;
        }
        public bool IsApplicable(List<char> cart)
        {
            return cart.Where(x => x == _skutype).Count()>=n;
        }

        public List<char> Apply(List<char> cart)
        {
            if (!IsApplicable(cart)) throw new Exception("Rule applied when not applicable");
            
            List<char> newcart = new List<char>();
            int i=0;

            //Delete required number of items consumed by the rule; return the rest;
            foreach(var item in cart)
            {
                if (item == _skutype && i<n) 
                {
                    i++;
                    continue;
                }
                newcart.Add(item);
            }
            return newcart;
        }
    }
}