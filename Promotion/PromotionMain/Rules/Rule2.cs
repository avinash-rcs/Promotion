using System;
using System.Collections.Generic;
using PromotionMain.Models;
using System.Linq;

namespace PromotionMain.Rules
{
    public class Rule2: IRule
    {
        char _skutype1;
        char _skutype2;

        // when SKUtype1 and SKU type2 are bought together it is at the offer price
        public Rule2(char SKUtype1, char SKUtype2)
        {
            this._skutype1=SKUtype1;
            this._skutype2=SKUtype2;
        }

        public bool IsApplicable(List<char> cart)
        {
            return cart.Any(x=> x == _skutype1) && cart.Any(x=> x == _skutype2);
        }

        public List<char> Apply(List<char> cart)
        {
            if (!IsApplicable(cart)) throw new Exception("Rule applied when not applicable");
            
            List<char> newcart = new List<char>();
            bool found1=false,found2=false;

            //Delete required number of items consumed by the rule; return the rest;
            foreach(var item in cart)
            {
                if (item == _skutype1 && !found1) 
                {
                    found1=true;
                    continue;
                }
                if (item == _skutype1 && !found2) 
                {
                    found2=true;
                    continue;
                }
                newcart.Add(item);
            }
            return newcart;
        }
    }
}