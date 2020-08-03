using System;
using Xunit;
using PromotionMain;
using System.Collections.Generic;
using PromotionMain.Models;

namespace Promotion.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void Check_if_intial_population_of_SKUs_Work()
        {
            List<PromotionMain.Models.SKU> list = Program.PopulateSKUs();
            Assert.Equal(4,list.Count);
        }
    }
}
