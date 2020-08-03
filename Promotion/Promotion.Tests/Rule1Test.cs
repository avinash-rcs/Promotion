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

            PromotionMain.Rules.IRule rule1 = new PromotionMain.Rules.Rule1('A',3,0);
            Assert.True(rule1.IsApplicable(mycart));
        }

        [Fact]
        public void Check_If_Rule1_works_when_not_applicable()
        {
            List<char> mycart = new List<char>();
            mycart.Add('A');
            mycart.Add('A');

            PromotionMain.Rules.IRule rule1 = new PromotionMain.Rules.Rule1('A',3,0);
            Assert.False(rule1.IsApplicable(mycart));
        }


        [Fact]
        public void Check_If_Rule1_works_when_applicable_with_multiple_skus()
        {
            List<char> mycart = new List<char>();
            mycart.Add('B');
            mycart.Add('C');
            mycart.Add('D');
            mycart.Add('A');
            mycart.Add('A');
            mycart.Add('A');

            PromotionMain.Rules.IRule rule1 = new PromotionMain.Rules.Rule1('A',3,0);
            Assert.True(rule1.IsApplicable(mycart));
        }

        [Fact]
        public void Check_If_Rule1_Apply_method_consumes_correct_number_of_elements()
        {
            List<char> mycart = new List<char>();
            mycart.Add('B');
            mycart.Add('C');
            mycart.Add('D');
            mycart.Add('A');
            mycart.Add('A');
            mycart.Add('A');

            PromotionMain.Rules.IRule rule1 = new PromotionMain.Rules.Rule1('A',3,0);
            Assert.Equal(3,rule1.Apply(mycart).Count);
        }
    }
}
