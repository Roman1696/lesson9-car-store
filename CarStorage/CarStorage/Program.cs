﻿using System;

namespace CarStorage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car[] cars = new Car[3];

            for (var i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Please input car's name");
                cars[i].Name = Console.ReadLine();

                Console.WriteLine("Please input car's name");
                cars[i].Price = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Input color");
                cars[i].Color = Console.ReadLine();

            }

            Console.WriteLine($"Source price: {cars[0].Price};Price after sale:{cars[0].GetSale()}");
        
        }
    }
}