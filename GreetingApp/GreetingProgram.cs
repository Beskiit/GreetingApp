﻿namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the total number of your enrolled courses: ");
            int course = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Total enrolled courses: " + course);
            Console.WriteLine("Price of my favorite book: " + price);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}