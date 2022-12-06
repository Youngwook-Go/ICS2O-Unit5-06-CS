// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets lengths of three side of triangle to answer properly

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        int first;
        int second;
        int count = 0;
        int answer = 0;

        Console.WriteLine("Enter simple multiplication question.\n");

        Console.Write("Enter the fisrt number : "); first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the fisrt number : "); second = Convert.ToInt32(Console.ReadLine());

        // output
        while (count < second)
        {
            answer = answer + first;
            count = count + 1;
        }

        Console.WriteLine("\nThe answer is : " + answer + " .");
        Console.WriteLine("\ndone.");
    }
}
