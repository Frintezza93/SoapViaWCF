using System;
using TestProj.CalculatorReference;

namespace TestProj
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var client = new CalculatorClient())
            {
                Console.WriteLine(client.Addition(1, 4));
                var complexAdditionResult = client.ComplexAddition(
                    new ComplexNumber
                    {
                        Real = 2,
                        Imagine = 4
                    }, new ComplexNumber
                    {
                        Real = 1,
                        Imagine = 3,
                    });

                Console.WriteLine($"Real: {complexAdditionResult.Real}; Imagine: {complexAdditionResult.Imagine}i");
            }
        }
    }
}
