﻿namespace DesignPatterns.GangOfFour.Behavioral.Interpreter.Tests
{
    using System.Collections.Generic;

    using DesignPatterns.GangOfFour.Behavioral.Interpreter;

    using NUnit.Framework;

    [TestFixture]
    public class InterpreterTest
    {
        [TestCase("+ 10 2", 12)]
        [TestCase("+ - 10 2 3", 11)]
        [TestCase("- + 10 5 - 8 2", 9)]
        public void TestInterpreter(string tokenString, int expectedResult)
        {
            var tokenList = new List<string>(tokenString.Split(' '));
            var expression = new TokenReader().ReadToken(tokenList);

            Assert.That(expression.Interpret(), Is.EqualTo(expectedResult));
        }
    }
}