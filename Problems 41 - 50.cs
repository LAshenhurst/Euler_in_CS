using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

using Functions;

namespace Euler_50 {
    class Euler_50 {
        public static void Problem_41()
            {
                List<BigInteger> PermArray = new List<BigInteger>();
                List<BigInteger> Permutation = new List<BigInteger>();
                int BiggestPanPrime = 0;
                for (BigInteger i = 1; i < 9; i++)
                {
                    PermArray.Add(i);
                    Permutation = Functions.Functions.Permutations(PermArray.ToArray<BigInteger>());
                    for (int j = 0; j <= Permutation.Count - 1; j++)
                    {
                        if (Functions.Functions.isPrime(Convert.ToInt32(Permutation[j])) && Permutation[j] > BiggestPanPrime) { BiggestPanPrime = Convert.ToInt32(Permutation[j]); }
                    }
                }
                Console.WriteLine("The largest number that is both pandigital and prime is " + BiggestPanPrime);
            }
            public static void Problem_42()
            {
                // Go to text file properties and make it an added resource to use below method of reading
                string TextFileName = "Problem42_Words.txt";
                string[] Words = System.IO.File.ReadAllText(TextFileName).Split(',');
                char[] Letters;
                int AlphaValueSum = 0, count = 0;
                foreach (string Word in Words)
                {
                    AlphaValueSum = 0;
                    Letters = Word.ToCharArray();
                    foreach (char Letter in Letters) { AlphaValueSum += Functions.Functions.AlphabeticalValue(Letter); }
                    if (Functions.Functions.isTriangle(AlphaValueSum)) { count++; }
                }
                Console.WriteLine(count);
            }
            public static void Problem_43()
            {
                List<BigInteger> Permutes = new List<BigInteger>();
                int[] Primes = { 2, 3, 5, 7, 11, 13, 17 };
                BigInteger[] PanDigits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
                bool SubstringDivisible = true;
                BigInteger Total = 0;
                char[] IntSplitTemp; string substring;
                Permutes = Functions.Functions.Permutations(PanDigits);
                foreach (BigInteger Permutation in Permutes)
                {
                    IntSplitTemp = Permutation.ToString().ToCharArray(); SubstringDivisible = true;
                    if (IntSplitTemp.Length == 9) { continue; }
                    for (int i = 0; i <= Primes.Length - 1; i++)
                    {
                        substring = IntSplitTemp[i + 1].ToString() + IntSplitTemp[i + 2].ToString() + IntSplitTemp[i + 3].ToString();
                        if (int.Parse(substring) % Primes[i] != 0) { SubstringDivisible = false; break; }
                    }
                    if (SubstringDivisible == true) { Total += Permutation; }
                }
                Console.WriteLine(Total);
            }
            public static void Problem_44()
            {
                int PentaCount = 0, Pentaj = 0, result = 0;
                bool done = false;
                for (int i = 1; ; i++)
                {
                    PentaCount = Convert.ToInt32(Functions.Functions.TriPentHexNumberConvert("Pent", i, 0));
                    for (int j = 1; j < i; j++)
                    {
                        Pentaj = Convert.ToInt32(Functions.Functions.TriPentHexNumberConvert("Pent", 0, j));
                        if (Functions.Functions.isPentagonal(PentaCount - Pentaj) && Functions.Functions.isPentagonal(PentaCount + Pentaj)) { result = PentaCount - Pentaj; done = true; break; }
                    }
                    if (done == true) { break; }
                }

                Console.WriteLine("The two pentagonal numbers whose difference and sum are pentagonal has difference " + result);
            }
            public static void Problem_45()
            {
                Double x, j, k;
                for (Double n = 286; ; n++)
                {
                    x = (n * (n + 1)) / 2;
                    j = (1 + Math.Sqrt((24 * x) + 1)) / 6;
                    k = (1 + Math.Sqrt((8 * x) + 1)) / 4;
                    if (j % 1.0 == 0.0 & k % 1.0 == 0.0) { break; }
                }
                Console.WriteLine(x);
            }
            public static void Problem_46()
            {
                int OddComposite = 7;
                string OddCompMinusSquare = "";
                bool Solved = false;
                do
                {
                    OddComposite += 2; if (Functions.Functions.isPrime(OddComposite)) { do { OddComposite += 2; } while (Functions.Functions.isPrime(OddComposite)); }
                    for (int i = 1; i <= Math.Sqrt(OddComposite / 2); i++)
                    {
                        OddCompMinusSquare = (OddComposite - 2 * Math.Pow(i, 2)).ToString();
                        if (Functions.Functions.isPrime(int.Parse(OddCompMinusSquare))) { break; }
                        if (i + 1 > Math.Sqrt(OddComposite / 2)) { Solved = true; }
                    }
                } while (Solved == false);
                Console.WriteLine("The first odd composite number that cannot be written as the sum of a prime and");
                Console.WriteLine("a square number is " + OddComposite);
            }
            public static void Problem_47()
            {
                List<List<int>> DistinctFactors = new List<List<int>>();
                int TestNumber = 1;
                bool Solved = false;
                do
                {
                    TestNumber++;
                    DistinctFactors.Add(new List<int>()); DistinctFactors[0] = Functions.Functions.PrimeFactors(TestNumber).Distinct<int>().ToList<int>();
                    if (DistinctFactors[0].Count != 4) { continue; }
                    DistinctFactors.Add(new List<int>()); DistinctFactors[1] = Functions.Functions.PrimeFactors(TestNumber + 1).Distinct<int>().ToList<int>();
                    if (DistinctFactors[1].Count != 4) { continue; }
                    DistinctFactors.Add(new List<int>()); DistinctFactors[2] = Functions.Functions.PrimeFactors(TestNumber + 2).Distinct<int>().ToList<int>();
                    if (DistinctFactors[2].Count != 4) { continue; }
                    DistinctFactors.Add(new List<int>()); DistinctFactors[3] = Functions.Functions.PrimeFactors(TestNumber + 3).Distinct<int>().ToList<int>();
                    if (DistinctFactors[3].Count == 4) { Solved = true; }
                } while (Solved == false);
                Console.WriteLine(TestNumber);
            }
            public static void Problem_48()
            {
                List<int> Digits = new List<int>();
                List<int> iDigits = new List<int>();
                string Result = "";
                for (int i = 1; i <= 1000; i++)
                {
                    iDigits = Functions.Functions.XtotheX(i);
                    while (Digits.Count < iDigits.Count) { Digits.Add(0); }
                    for (int j = 0; j <= iDigits.Count - 1; j++) { Digits[j] += iDigits[j]; }
                    for (int j = 0; j <= Digits.Count - 1; j++)
                    {
                        if (Digits[j] >= 10)
                        {
                            if (j < iDigits.Count - 1) { Digits[j + 1] += Digits[j] / 10; }
                            else { Digits.Add(Digits[j] / 10); }
                            Digits[j] %= 10;
                        }
                    }
                }
                for (int i = 9; i >= 0; i--) { Result += Digits[i].ToString(); }
                Console.WriteLine(Result);
            }
            public static void Problem_49()
            {
                List<BigInteger> Permutes = new List<BigInteger>();
                List<BigInteger> iDigits = new List<BigInteger>();
                int Temp;
                string result = "";
                for (int i = 1000; i <= 9999; i++)
                {
                    Temp = i;
                    if (Functions.Functions.isPrime(Temp) == false || Functions.Functions.isPrime(Temp + 3330) == false || Functions.Functions.isPrime(Temp + 6660) == false) { continue; }
                    do { iDigits.Add(Temp % 10); Temp /= 10; } while (Temp > 0);
                    iDigits.Reverse();
                    Permutes = Functions.Functions.Permutations(iDigits.ToArray<BigInteger>());
                    if (Permutes.Contains(i) && Permutes.Contains(i + 3330) && Permutes.Contains(i + 6660))
                    { result = Temp.ToString() + (Temp + 3330).ToString() + (Temp + 6660).ToString(); }
                }
                Console.WriteLine(result);
            }
            public static void Problem_50()
            {
                List<int> Primes = new List<int>();
                int result = 0, PrimesTotal = 0, count = 0;
                bool Done = false;
                Primes.Add(2); Primes.Add(3);
                do
                {
                    count = 0;
                    Primes.Add(Functions.Functions.FindNextPrime(Primes.Max()));
                    do
                    {
                        PrimesTotal = 0;
                        for (int i = count; i <= Primes.Count - 1; i++) { PrimesTotal += Primes[i]; }
                        count++;
                        if (PrimesTotal < result) { break; }
                        if (PrimesTotal > 1000000) { Done = true; break; }
                        else if (Functions.Functions.isPrime(PrimesTotal) && PrimesTotal > result) { result = PrimesTotal; }
                    } while (count < Primes.Count - 1);
                } while (Done == false);
                Console.WriteLine(result);
            }
    }
}