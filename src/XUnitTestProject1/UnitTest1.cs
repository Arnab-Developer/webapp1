using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var name = "jon";
            var helloName = $"hello {name}";
            Assert.Equal("hello jon", helloName);
        }
    }
}
