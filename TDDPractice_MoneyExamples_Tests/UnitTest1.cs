using NUnit.Framework;
using System;
using TDDPractice_MoneyExamples;

namespace TDDPractice_MoneyExamples_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void testMultiplication()
        {
            try
            {
                Dollar five = new Dollar(5);
                Assert.AreEqual(new Dollar(10), five.Times(2));
                Assert.AreEqual(new Dollar(15), five.Times(3));
            }
            catch(Exception e)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void testEquality()
        {
            try
            {
                //TODO: implement
                Assert.True(new Dollar(5).Equals(new Dollar(5)));
                Assert.False(new Dollar(5).Equals(new Dollar(6)));
            }
            catch(Exception e)
            {
                Assert.Fail();
            }
        }
    }
}