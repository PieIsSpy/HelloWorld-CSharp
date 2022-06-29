using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* These are variables.
              They contain data values. */
            int NumberA = 3;

            // Same type of variables
            char CharA = 'a', CharB = 'b', CharC = 'c';
            Console.WriteLine(CharA + "" + CharB + "" + CharC); // idk why or how but it just put numbers if i dont put ""

            // Same value for variables
            double DoubleA, DoubleB, DoubleC;
            DoubleA = DoubleB = DoubleC = 0.5;
            Console.WriteLine(DoubleA + DoubleB + DoubleC);

            // WriteLine codes
            Console.WriteLine("Hello World!");
            Console.WriteLine("Testing, testing.");

            // Write + WriteLine codes
            Console.Write("Among ");
            Console.WriteLine("Us");

            // Write codes
            Console.Write("2 + 2 is ");
            Console.Write(2 + 2);

            Console.WriteLine(" minus 1 is " + NumberA);
            Console.WriteLine("Quick maths");

            // This overrides 3
            NumberA = 28;
            Console.WriteLine(NumberA + " apples eaten by a man. I wonder who.");

            // const prevents NumberB to be overriden
            const int NumberB = 9;
            Console.WriteLine(NumberB + " lives for the cat.");

            // Convertion example
            double DoubleD = 5.5;
            int NumberC = (int)DoubleD;
            Console.WriteLine("This is a double: " + DoubleD);
            Console.WriteLine("This is an integer: " + NumberC);

            // User iput using Console.ReadLine()
            Console.WriteLine("Oh yeah, I haven't gotten your name yet. What is it?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello there, " + Name);

            // If-else statement
            Console.WriteLine("Have you seen the man who ate some apples, " + Name + "? (Y/N)");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(""); // Here just to make the rest write on the other line

            if (key.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Keep an eye out for them.");
            }
            else if (key.Key == ConsoleKey.N)
            {
                Console.WriteLine("Heard they came from a python repository called 'HelloWorld-Python'. Keep an eye out for them.");
            }
            else
            {
                Console.WriteLine("Sorry? I didn't understand. Just keep an eye out for them.");
            }
        }
    }
}