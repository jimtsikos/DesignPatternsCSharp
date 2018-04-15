﻿namespace DesignPatterns.GangOfFour.Creational.FactoryMethod
{
    using System;

    public class Audi : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Driving Audi.");
        }
    }
}