﻿namespace DesignPatterns.GangOfFour.Behavioral.Mediator.Tests
{
    using DesignPatterns.GangOfFour.Behavioral.Mediator;

    using NUnit.Framework;

    [TestFixture]
    public class MediatorTest
    {
        [Test]
        public void TestMediator()
        {
            var mediator = new Mediator<string>();

            var colleague1 = new Colleague<string>("Colleague 1");
            var colleague2 = new Colleague<string>("Colleague 2");
            var colleague3 = new Colleague<string>("Colleague 3");

            mediator.Register(colleague1);
            mediator.Register(colleague2);
            mediator.Register(colleague3);

            colleague1.SendMessage(mediator, "Test message 1");

            // OUTPUT: Colleague 2 received Test message 1.

            // OUTPUT: Colleague 3 received Test message 1.
        }
    }
}