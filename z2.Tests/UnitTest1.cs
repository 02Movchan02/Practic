using System;
using Xunit;

namespace z2.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            usl u = new usl(9);

            Assert.Equal(1, u.res1);
                   
        }
        [Fact]
        public void Test2()
        {
            usl u = new usl(7);

            Assert.Equal("Нет решения", u.NonR);
        }
        [Fact]
        public void Test3()
        {
            usl u = new usl(-6);

            Assert.Equal(6, u.res2);
        }
        [Fact]
        public void Test4()
        {
            usl u = new usl(-7);

            Assert.Equal("Нет решения", u.NonR);
        }
        [Fact]
        public void Test5()
        {
            usl u = new usl(4);

            Assert.Equal(1, u.res3);
        }
        [Fact]
        public void Test6()
        {
            usl u = new usl(3);

            Assert.Equal("Нет решения", u.NonR);
        }
    }
}
