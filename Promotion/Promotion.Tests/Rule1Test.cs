using System;
using Xunit;
using PromotionMain;
using System.Collections.Generic;
using PromotionMain.Models;

namespace Promotion.Tests
{
    public class Rule1Test
    {
        [Fact]
        public void Check_If_Rule1_works_when_applicable()
        {
            List<char> mycart = new List<char>();
            mycart.Add('A');
            mycart.Add('A');
            mycart.Add('A');
            mycart.Add('A');

            PromotionMain.Rules.IRule rule1 = new PromotionMain.Rules.Rule1('A',4);


        }
    }
}
