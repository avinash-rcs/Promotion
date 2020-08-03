using System;
using Xunit;
using PromotionMain;
using System.Collections.Generic;
using PromotionMain.Models;

namespace Promotion.Tests
{
    public class Rule2Test
    {
        [Fact]
        public void Check_If_Rule2_works_when_applicable()
        {
            List<char> mycart = new List<char>();
            mycart.Add('A');
            mycart.Add('A');
            mycart.Add('B');
            mycart.Add('C');

            PromotionMain.Rules.IRule rule2 = new PromotionMain.Rules.Rule2('B','C');
            Assert.True(rule2.IsApplicable(mycart));
        }

        [Fact]
        public void Check_If_Rule2_works_when_not_applicable()
        {
            List<char> mycart = new List<char>();
            mycart.Add('A');
            mycart.Add('A');

            PromotionMain.Rules.IRule rule2 = new PromotionMain.Rules.Rule2('B','C');
            Assert.False(rule2.IsApplicable(mycart));
        }


        [Fact]
        public void Check_If_Rule2_works_when_applicable_with_multiple_skus()
        {
            List<char> mycart = new List<char>();
            mycart.Add('B');
            mycart.Add('C');
            mycart.Add('D');
            mycart.Add('A');
            mycart.Add('A');
            mycart.Add('A');

            PromotionMain.Rules.IRule rule2 = new PromotionMain.Rules.Rule2('B','C');
            Assert.True(rule2.IsApplicable(mycart));
        }

        [Fact]
        public void Check_If_Rule2_Apply_method_consumes_correct_number_of_elements()
        {
            List<char> mycart = new List<char>();
            mycart.Add('B');
            mycart.Add('C');
            mycart.Add('D');
            mycart.Add('A');
            mycart.Add('A');
            mycart.Add('A');

            PromotionMain.Rules.IRule rule2 = new PromotionMain.Rules.Rule2('B','C');
            Assert.Equal(4,rule2.Apply(mycart).Count);
        }
    }
}
