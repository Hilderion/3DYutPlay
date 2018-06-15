using System;
using FinalProject;
using NUnit.Framework;

namespace FinalTest.UnitTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void SetUp()
        {
            Board.Instance.InitializeForTest();
        }
        
        [Test]
        public void Test1()
        {
            Assert.True(true);
        }
    }
}