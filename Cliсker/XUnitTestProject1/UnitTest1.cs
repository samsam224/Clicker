using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PointTest()
        {
            long point = 250;
            int click = 5;
            Assert.True(Cliker.ClickClass.ClickMethod(5, 5, ref point, ref click));
            Assert.True(Cliker.ClickClass.ClickMethod(2, 2, ref point, ref click));
            Assert.False(Cliker.ClickClass.ClickMethod(100, 1000, ref point, ref click));
        }
    }
}
