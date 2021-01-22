﻿using System;

namespace RefKeyword
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;

            int result = Add(ref number1, number2);

            Console.WriteLine(result);
            Console.WriteLine(number1);
        }

        private static int Add(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}