using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        //Write a method that will print to the console all numbers 1000 through -1000.
        public static void Thousand()
        {
            Console.WriteLine("Hello World!");
            for (int i = 1000; i > -1001; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
        public static void ByThree()
        {
            //Write a method that will print to the console numbers 3 through 999 by 3 each time.
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }

        }

        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static void IsEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y}");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void IsEvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even");
            }
            else
            {
                Console.WriteLine($"{x} is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative.

        public static void PositiveOrNegative(int x)
        {
            if (x < 0)
            {
                Console.WriteLine($"{x} is negative");
            }

            else
            {
                Console.WriteLine($"{x} is positive");
            }
           
        }

        //Write a method to read the age of a candidate and determine whether they can vote. Hint: use Parse()... or the safer TryParse() for an extra challenge!!
        public static void VotingAgeChecker()
        {
            Console.WriteLine("Enter in age of candidate: ");
            var candidate = int.TryParse(Console.ReadLine(), out int age);

            if (age >= 18)
            {
                Console.WriteLine($"This person is old enough to vote at {age} years old!");
            }
            else
            {
                Console.WriteLine($"This person is not old enough to vote at {age} years old");
            }
        }
        //Write a method to check if an integer (from the user) is in the range -10 to 10.
        public static void IsInRange()
        {
            Console.WriteLine("Enter in a random number");
            var number = int.Parse(Console.ReadLine());
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is in range");
            }
            else
            {
                Console.WriteLine($"{number} is not in range");
            }
        }

        //Write a method to display the multiplication
        //table(from 1 to 12) of a given integer.

        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter in a number: ");
            var number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number *i }");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1000 to -1000 printed out: ");
            Thousand();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("3 through 999 counted by 3 printed out: ");
            ByThree();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter two random numbers. (A series of calculations will then follow)");
            Console.WriteLine("Enter in your first number");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter in your second number");
            var num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            IsEqual(num1, num2);
            Console.WriteLine("------------------------------------------");
            IsEvenOrOdd(num1);
            IsEvenOrOdd(num2);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            PositiveOrNegative(num1);
            PositiveOrNegative(num2);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            VotingAgeChecker();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            IsInRange();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            MultiplicationTable();
        }

    }
}
