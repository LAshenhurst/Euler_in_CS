using System;
using System.Collections.Generic;
using System.Linq;

using Functions;

namespace Euler_10 {
    public class Euler_10 {
        public static void Problem_1()
            {
                int Solution = Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
                Console.WriteLine("The sum of all multiples of 3 and 5 below 1000 is " + Solution);
            }
            public static void Problem_2()
            {
                int Solution = 0;
                int a = 1, b = 2, c = 0;
                Solution += b;
                do
                {
                    c = a + b; a = b; b = c;
                    if (c % 2 == 0) { Solution += c; }
                } while (a < 4000000 && b < 4000000);
                Console.WriteLine("Sum of all even fibonacci numbers under 4,000,000 is " + Solution);
            }
            public static void Problem_3()
            {
                long Storage = 600851475143;
                Console.WriteLine("The largest prime factor of 600851475143 is found by dividing it by the smallest factor to find what remains:");
                for (long i = 2; i <= Math.Sqrt(Storage); i++)
                {
                    if (Storage % i == 0)
                    {
                        Console.WriteLine(i + " is a factor of " + Storage + " so we divide it out. Giving " + (Storage / i));
                        Storage /= i;
                    }
                }
                Console.WriteLine("So the solution is: " + Storage);
            }
            public static void Problem_4()
            {
                int Solution = 0;
                for (int i = 100; i <= 999; i++) { for (int j = 100; j <= 999; j++) { if (Functions.Functions.isPalindrome(i * j) & (i * j) > Solution) { Solution = i * j; } } }
                Console.WriteLine("Largest palindromic number that's a product of two three digit numbers: " + Solution);
            }
            public static void Problem_5()
            {
                int Solution = 0;
                bool SolutionFound = false;
                for (int Test = 2; ; Test++)
                {
                    for (int i = 2; i <= 20; i++) { if (Test % i == 0) { if (i == 20) { Solution = Test; SolutionFound = true; } continue; } else { break; } }
                    if (SolutionFound) { break; }
                }
                Console.WriteLine("Smallest positive number evenly divisible by numbers 1 - 20 is: " + Solution);
            }
            public static void Problem_6()
            {
                int SumSquares = 0, SumSquared = 0, Difference = 0;
                for (int i = 0; i <= 100; i++) { SumSquares += (i * i); SumSquared += i; }
                Difference = Math.Max(SumSquared * SumSquared, SumSquares) - Math.Min(SumSquares, (SumSquared * SumSquared));
                Console.WriteLine("The difference is " + Difference);
            }
            public static void Problem_7()
            {
                int Prime = 2, count = 1;
                do { Prime = Functions.Functions.FindNextPrime(Prime); count++; } while (count <= 10000);
                Console.WriteLine("The 10,001st prime is: " + Prime);
            }
            public static void Problem_8()
            {
                char[] Text = System.IO.File.ReadAllText("Problem8_Numbers.txt").ToCharArray();
                List<int> Numbers = new List<int>();
                int TestSuccess = 0;
                long MaxProd = 0, Storage = 1;
                foreach (char Tester in Text) { if (int.TryParse(Tester.ToString(), out TestSuccess)) { Numbers.Add(TestSuccess); } }
                for (int j = 0; j < Numbers.Count - 14; j++)
                {
                    for (int i = 0; i < 13; i++) { Storage *= int.Parse(Numbers.ElementAt(j + i).ToString()); }
                    if (Storage > MaxProd) { MaxProd = Storage; }
                    Storage = 1;
                }
                Console.WriteLine("The largest product of 13 numbers in the given sequence is: " + MaxProd);
            }
            public static void Problem_9()
            {
                int Finala = 0; int Finalb = 0; int Finalc = 0;
                for (int a = 1; a < 1000; a++)
                {
                    for (int b = a + 1; b < 1000; b++)
                    {
                        int c = 1000 - a - b;
                        if ((a * a) + (b * b) == (c * c)) { Finala = a; Finalb = b; Finalc = c; break; }
                    }
                }
                Console.WriteLine("a = " + Finala + " b = " + Finalb + " c = " + Finalc + "a * b * c = " + (Finala * Finalb * Finalc));
            }
            public static void Problem_10()
            {
                int Solution = 0, Prime = 2;
                do
                {
                    Solution += Prime;
                    Prime = Functions.Functions.FindNextPrime(Prime);
                } while (Prime < 2000000);
                Console.WriteLine("Sum of all primes under 2,000,000 is " + Solution);
            }
    }
}