using System;
using Xunit;

namespace Promotion.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program p = new Program();
            List<SKU> list = p.BuildSKUs();
            Assert.Equal(list.size(),4);

        }
    }
}
