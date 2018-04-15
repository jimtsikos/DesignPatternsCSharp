﻿namespace DesignPatterns.GangOfFour.Structural.Proxy.Tests
{
    using DesignPatterns.GangOfFour.Structural.Proxy;

    using NUnit.Framework;

    [TestFixture]
    public class ProxyTest
    {
        [Test]
        public void TestDriveWithAdultDriver()
        {
            var carProxy = new CarProxy(new Driver(21));

            carProxy.Drive();

            // OUTPUT: Driving car.
        }

        [Test]
        public void TestDriveWithYoungDriverThrowsInvalidArgumentException()
        {
            var carProxy = new CarProxy(new Driver(16));

            Assert.That(() => carProxy.Drive(), Throws.ArgumentException);
        }
    }
}