﻿using System;

namespace PrimeNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing the 2D array of prime number between 0-1000");
            PrimeNumber prime = new PrimeNumber();
            prime.StorePrime();
            prime.Print();
        }
    }
}
