using System;
using System.Collections.Generic;
using System.Numerics;

using Functions;

namespace Euler_30 {
    class Euler_30 {
        public static void Problem_21()
            {
                List<int> SumOfFactors = new List<int>();
                List<int> ListOfAmicablePairs = new List<int>();
                int Sum = 0; int AmicableSum = 0;
                int SumOfAmicablePairs = 0;
                for (int i = 1; i <= 10000; i++)
                {
                    Sum = 0; AmicableSum = 0;
                    for (int j = 1; j < Math.Sqrt(i); j++) { if (i % j == 0) { Sum += j; if ((j != 1) && (i / j != j)) { Sum += i / j; }; } }
                    for (int j = 1; j < Math.Sqrt(Sum); j++) { if (Sum % j == 0) { AmicableSum += j; if ((j != 1) && (Sum / j != j)) { AmicableSum += Sum / j; } } }
                    if (AmicableSum == i && i != Sum) { SumOfAmicablePairs += i; }
                }
                Console.Clear();
                Console.WriteLine("An amicable pair is a pair of numbers where the sum of their divisors add up to each other.");
                Console.WriteLine("Example?");
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Example: Divisors of 220 = 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, and 110. Sum is 284.");
                    Console.WriteLine("Example: Divisors of 284 = 1, 2, 4, 71, and 142. Sum is 220.");
                    Console.WriteLine("Example: These are an amicable pair.");
                }
                Console.WriteLine("The sum of all amicable pairs under 10,000 is " + SumOfAmicablePairs);
            }
            public static void Problem_22()
            {
                string Problem_22_File = "Problem22_Names.txt";
                string NamesString = System.IO.File.ReadAllText(Problem_22_File);
                string[] NamesArray = NamesString.Split(','); Array.Sort(NamesArray);
                char[] NameChars;
                int NameTotal = 0, Total = 0;
                for (int i = 0; i <= NamesArray.Length - 1; i++)
                {
                    NameTotal = 0;
                    NameChars = NamesArray[i].ToCharArray();
                    for (int j = 0; j <= NameChars.Length - 1; j++) { NameTotal += Functions.Functions.AlphabeticalValue(NameChars[j]); }
                    NameTotal *= (i + 1);
                    Total += NameTotal;
                }
                Console.WriteLine("Sum of the alphabetical value of the names in the given text file is " + Total);
            }
            public static void Problem_23()
            {
                List<int> AbundantNumbers = new List<int>();
                Boolean[] SumPossibilites = new bool[28123];
                int total = 0;
                int SumDivisors = 0;
                int TotalPoint = 0;
                for (int i = 0; i <= 28123; i++)
                {
                    SumDivisors = 0;
                    for (int j = 1; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0) { SumDivisors += j; if (j != 1 && (i / j != j)) { SumDivisors += (i / j); } }
                    }
                    if (SumDivisors > i) { AbundantNumbers.Add(i); }
                }
                for (int i = 0; i <= AbundantNumbers.Count - 1; i++)
                {
                    for (int j = 0; j <= AbundantNumbers.Count - 1; j++)
                    {
                        if ((AbundantNumbers[i] + AbundantNumbers[j]) < 28123) { SumPossibilites[(AbundantNumbers[i] + AbundantNumbers[j])] = true; }
                    }
                }
                for (int i = TotalPoint; i < 28123; i++)
                {
                    if (SumPossibilites[i] == false) { total += i; TotalPoint = i; }
                }
                Console.WriteLine("Sum of all positive integers that cannot be written as sum of two abundant numbers is " + total);
            }
            public static void Problem_24()
            {
                // This works by reducing the range in which the millionth permutation is in
                // until that range reaches one number.
                int[] perm = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int N = 10;
                string permNum = "";
                int Remain = 999999;
                List<int> Numbers = new List<int>();
                for (int i = 0; i < N; i++) { Numbers.Add(i); }
                for (int i = 1; i < N; i++)
                {
                    int j = Convert.ToInt32(Remain / Functions.Functions.toFactorial(N - i));
                    Remain %= Convert.ToInt32(Functions.Functions.toFactorial(N - i));
                    permNum += Numbers[j];
                    Numbers.RemoveAt(j);
                    if (Remain == 0) { break; }
                }
                for (int i = 0; i < Numbers.Count; i++) { permNum += Numbers[i]; }
                Console.WriteLine("The millionth entry in the lexicographic permutation is " + permNum);
            }
            public static void Problem_25()
            {
                List<BigInteger> FibonacciNumbers = new List<BigInteger>();
                BigInteger FibNumber = 0;
                FibonacciNumbers.Add(1);
                FibonacciNumbers.Add(1);
                int Temp = 2;
                do
                {
                    FibNumber = 0;
                    FibNumber = FibonacciNumbers[Temp - 1] + FibonacciNumbers[Temp - 2];
                    Temp++;
                    FibonacciNumbers.Add(FibNumber);
                } while (FibNumber.ToString().Length < 1000);
                Console.WriteLine(FibonacciNumbers.Count + " is the index of the first Fibonacci number with over 1000 digits");
            }
            public static void Problem_26()
            {
                int count = 1, maxcount = 0, nextremainder = 0;
                List<int> Remainder = new List<int>();
                bool endfound = false;
                for (int denominator = 2; denominator < 1000; denominator++)
                {
                    count = 1; Remainder.Clear(); Remainder.Add(1); endfound = false;
                    do
                    {
                        nextremainder = (Remainder[count - 1] * 10) % denominator;
                        if (Remainder.Contains(nextremainder)) { Remainder.Add(nextremainder); count++; endfound = true; }
                        else { Remainder.Add(nextremainder); count++; }
                    } while (endfound == false);
                    if (count > maxcount) { maxcount = count; }
                }
                Console.WriteLine("The d < 1000 for which 1/d has the largest recurring cycle is " + maxcount);
            }
            public static void Problem_27()
            {
                long result = 0;
                int first = 0, second = 0, n = 0;
                int highestcount = 0;
                int FunctionResult = 0;
                bool NonPrimeFound = false;
                for (int a = -1000; a < 1000; a++)
                {
                    for (int b = -1000; b < 1000; b++)
                    {
                        n = 0;
                        NonPrimeFound = false;
                        do
                        {
                            FunctionResult = ((n * n) + (a * n) + b);
                            if (FunctionResult > 0 && Functions.Functions.isPrime(FunctionResult) == false) { NonPrimeFound = true; }
                            if (FunctionResult < 0) { NonPrimeFound = true; }
                            if (FunctionResult >= 0 && NonPrimeFound == false) { n += 1; }
                        } while (NonPrimeFound == false);
                        if (n > highestcount) { highestcount = n; result = a * b; first = a; second = b; }
                    }
                }
                Console.WriteLine("Product of a and b that create highest number of consecutive primes is " + result);
                Console.WriteLine("The function is n^2 + " + first + "*n + " + second);
            }
            public static void Problem_28()
            {
                int total = 1;
                //Top right corner of ring has value n^2
                //Top left has value n^2 - (n - 1)
                //Bottom left has value n^2 - 2(n - 1)
                //Bottom right has value n^2 - 3(n - 1)
                //Sum for ring is 4n^2 - 6(n - 1)
                //Can use this to add up each ring for total.
                for (int i = 3; i <= 1001; i += 2) { total += (4 * i * i) - (6 * (i - 1)); }
                Console.WriteLine("Sum of all diagonals in a 1001 by 100 spiral are " + total);
            }
            public static void Problem_29()
            {
                List<double> Terms = new List<double>();
                double Power = 0;
                for (int a = 2; a <= 100; a++)
                {
                    for (int b = 2; b <= 100; b++)
                    {
                        Power = Math.Pow(a, b);
                        if (Terms.Contains(Power) == false) { Terms.Add(Power); }
                    }
                }
                Console.WriteLine(Terms.Count);
            }
            public static void Problem_30()
            {
                int FinalResult = 0;
                int a = 0, Total = 0, Temp = 0;
                for (int i = 2; i < 1000000; i++)
                {
                    Temp = 0; Total = 0; a = i;
                    do
                    {
                        Temp = a % 10;
                        Total += (Temp * Temp * Temp * Temp * Temp);
                        a = a / 10;
                    } while (a != 0);
                    if (Total == i) { FinalResult += i; }
                }
                Console.WriteLine("Sum of all numbers that can be written as the sum of the fifth power of their digits is " + FinalResult);
            }
    }
}