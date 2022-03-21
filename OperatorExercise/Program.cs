using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value for a");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer value for b");
            var b = int.Parse(Console.ReadLine());

            var addResult = a + b;
            var subResult = a - b;
            var multResult = a * b;
            var divResult = a / b;
            var modResult = a % b;

            Console.WriteLine($"Addition Result: {addResult}.\nSubtraction Result: {subResult}.\n" +
                $"Multiplication Result: {multResult}.\nDivision Result: {divResult}.\nModulus Result: {modResult}.");

            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("Enter radius to find area:");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area of circle is {area}");

        }
    }
}

//Create a simple program named OperatorExercise in your repos folder to write out the results of addition, subtraction, multiplication, division, and modulus operations.
//For division, create two integer variables called a and b.
//Create a third integer variable and name it quotient (the result of a division) that stores the result of the division of a and b, and another integer variable named remainder that stores the remainder (using the % operator). Write out the results using Console.WriteLine or Console.Write to write out the results in the following form: if a = 17 and b = 4, print the following:
//The result should say: 17 / 4 is 4 remainder 1