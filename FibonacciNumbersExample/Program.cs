using System;
using System.Collections.Generic;

namespace FibonacciNumbersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            Console.WriteLine(fibonacciNumbers[0]);
            Console.WriteLine(fibonacciNumbers[1]);

            for (var i = 2; i < 20; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                var nextNum = previous + previous2;
                fibonacciNumbers.Add(nextNum);
                Console.WriteLine(fibonacciNumbers[i]);
            }

            /*MS Answer
             *var fibonacciNumbers = new List<int> {1, 1};

              while (fibonacciNumbers.Count < 20)
               {
                  var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                  var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                  fibonacciNumbers.Add(previous + previous2);
                }
               foreach(var item in fibonacciNumbers)
               Console.WriteLine(item);*/
        }
    }
}
