using NUnit.Framework;

namespace SocialGoal.Tests
{
    public class MyTests
    {
        [Test]
        public void MyTest1()
        {
            var value = 2;
            Assert.True(IsOdd(value));
        }
        bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
    }
}