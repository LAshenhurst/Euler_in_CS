using System;
using System.Collections.Generic;

using Functions;

namespace Euler_40 {
    class Euler_40 {
        public static void Problem_31()
            {
                int target = 200;
                int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
                int[] ways = new int[target + 1];
                // Dynamic programming solution solves all the simpler versions of the problem and adds them together
                // i.e. All ways of making 5p with only 1p coins, then 5p using 1p and 2p coins etc etc
                ways[0] = 1;
                for (int i = 0; i < coins.Length; i++)
                {
                    for (int j = coins[i]; j <= target; j++)
                    {
                        ways[j] += ways[j - coins[i]];
                    }
                }
                Console.WriteLine("£2 can be made " + ways[200] + " ways using any number of coins.");
            }
            public static void Problem_32()
            {
                int total = 0;
                List<int> Pandigitals = new List<int>();
                for (int i = 0; i <= 10000; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            if (Functions.Functions.isPandigital(j.ToString() + i.ToString() + (i / j).ToString()) == true && Pandigitals.Contains(i) == false) { total += i; Pandigitals.Add(i); }
                        }
                    }
                }
                Console.WriteLine("Sum of all z such that x * y = z uses all digits 1 - 9 is " + total);
            }
            public static void Problem_33()
            {
                int Answer = 0;
                int numer = 1; int denom = 1;
                for (int i = 10; i <= 100; i++)
                {
                    for (int j = 10; j < i; j++)
                    {
                        int n0 = j % 10; int n1 = j / 10;
                        int d0 = i % 10; int d1 = i / 10;
                        if (n1 == d0 && n0 * i == d1 * j || n0 == d1 && n1 * i == d0 * j) { numer *= j; denom *= i; }
                    }
                }
                Answer = Functions.Functions.GCD(numer, denom);
                Console.WriteLine("The product of the fractions obtained by digit cancelling has denominator " + Answer);
            }
            public static void Problem_34()
            {
                int[] Factorials = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
                int Factoriand, TempTotal = 0, Answer = 0;
                for (int i = 0; i <= 9999999; i++)
                {
                    Factoriand = i; TempTotal = 0;
                    do
                    {
                        TempTotal += Convert.ToInt32(Functions.Functions.toFactorial(Factoriand % 10));
                        Factoriand /= 10;
                    } while (Factoriand > 0);
                    if (TempTotal == i && i > 2) { Answer += i; }
                }
                Console.WriteLine("Sum of all numbers equal to the sum of the factorial of their digits is " + Answer);
            }
            public static void Problem_35()
            {
                int TotalCircularPrimes = 0;
                string Prime;
                bool Circular;
                for (int i = 2; i <= 1000000; i++)
                {
                    Circular = true;
                    if (Functions.Functions.isPrime(i))
                    {
                        Prime = i.ToString();
                        if (Prime.Length == 1) { TotalCircularPrimes += 1; continue; }
                        for (int j = 0; j < Prime.Length; j++)
                        {
                            if (Functions.Functions.isPrime(int.Parse(Prime.Substring(j) + Prime.Substring(0, j))) == false) { Circular = false; }
                        }
                        if (Circular) { TotalCircularPrimes += 1; }
                    }
                }
                Console.WriteLine("There are " + TotalCircularPrimes + " circular primes under 1,000,000");
            }
            public static void Problem_36()
            {
                int Answer = 0;
                int Dec; string DecReversed = "";
                char[] DecChars; char[] BinChars;
                string Bin; string BinReversed = "";
                for (int i = 0; i < 1000000; i++)
                {
                    Dec = i; DecChars = Dec.ToString().ToCharArray(); DecReversed = "";
                    for (int j = DecChars.Length - 1; j >= 0; j--) { DecReversed += DecChars[j]; }
                    if (Dec == int.Parse(DecReversed))
                    {
                        Bin = Convert.ToString(Dec, 2); BinReversed = "";
                        BinChars = Bin.ToCharArray();
                        for (int j = Bin.Length - 1; j >= 0; j--) { BinReversed += BinChars[j]; }
                        if (Bin == BinReversed) { Answer += i; }
                    }
                }
                Console.WriteLine("The sum of all circular primes is " + Answer);
            }
            public static void Problem_37()
            {
                int Count = 0, Prime = 11;
                bool Truncatable = true;
                int Answer = 0;
                do
                {
                    for (int i = 1; i < Math.Floor(Math.Log10(Prime) + 1); i++)
                    {
                        Truncatable = true;
                        if (Functions.Functions.isPrime(Prime / Convert.ToInt32(Math.Pow(10, i))) == false) { Truncatable = false; break; }
                        if (Functions.Functions.isPrime(Prime % Convert.ToInt32(Math.Pow(10, i))) == false) { Truncatable = false; break; }
                    }
                    if (Truncatable) { Answer += Prime; Count++; }
                    Prime = Functions.Functions.FindNextPrime(Prime);
                } while (Count < 11);
                Console.WriteLine("The sum of all truncatable primes is " + Answer);
            }
            public static void Problem_38()
            {
                int Count = 1;
                string Concatenated = "", LargestPandigital = "0";
                for (int i = 1; i < 100000000; i++)
                {
                    Concatenated = ""; Count = 1;
                    do
                    {
                        Concatenated += (i * Count).ToString();
                        Count += 1;
                    } while (Concatenated.Length < 9);
                    if (Concatenated.Length == 9 && Functions.Functions.isPandigital(Concatenated)) { if (int.Parse(Concatenated) > int.Parse(LargestPandigital)) { LargestPandigital = Concatenated; } }
                }
                Console.WriteLine("The largest pandigital number made from a concatenated product is " + LargestPandigital);
            }
            public static void Problem_39()
            {
                int MaxSolutions = 0; int Solutions; int Maxp = 0;
                List<string> AllSolutions = new List<string>();
                for (int i = 0; i <= 1000; i++)
                {
                    Solutions = 0;
                    for (int a = 0; a <= i; a++)
                    {
                        for (int b = a; b <= i; b++)
                        {
                            for (int c = b; c <= i; c++)
                            {
                                if (a + b + c == i && (a * a) + (b * b) == (c * c)) { Solutions += 1; AllSolutions.Add(a.ToString() + b.ToString() + c.ToString()); }
                            }
                        }
                    }
                    if (Solutions > MaxSolutions) { MaxSolutions = Solutions; Maxp = i; }
                }
                Console.WriteLine("Right-angled Triangle with perimeter " + Maxp + " has the most solutions");
            }
            public static void Problem_40()
            {
                int TotalDigits = 0, Answer = 1, Count = 1;
                int[] nDigits = { 9, 99, 999, 9999, 99999, 999999 };
                List<int> NeededDigits = new List<int>();
                char[] DigitsToChar;
                string StringDigits = "";
                do
                {
                    NeededDigits.Add(Count);
                    TotalDigits += Count.ToString().Length;
                    Count++;
                } while (TotalDigits < 1000000);
                foreach (int Number in NeededDigits) { StringDigits += Number.ToString(); }
                DigitsToChar = StringDigits.ToCharArray();
                for (int i = 0; i < nDigits.Length - 1; i++) { Answer *= int.Parse(DigitsToChar[nDigits[i]].ToString()); }
                Console.WriteLine(Answer);
            }
    }
}