using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace Euler_70 {
    class Euler_70 {
        public static void Problem_61()
            {
                List<List<int>> Figurates = new List<List<int>>();
                List<int[,]> Combo = new List<int[,]>();
                List<List<int>> Possible = new List<List<int>>();
                List<int> toSkip = new List<int>();
                int[,] Storage = new int[1, 2];
                int[] MinN = { 45, 32, 26, 23, 21, 20 };
                Double Test = 0;
                int result = 0;
                for (int i = 0; i <= 5; i++)
                {
                    Figurates.Add(new List<int>());

                    for (int n = MinN[i]; ; n++)
                    {
                        switch (i)
                        {
                            case 0: Test = (n * (n + 1)) / 2; break;
                            case 1: Test = n * n; break;
                            case 2: Test = (n * (3 * n - 1)) / 2; break;
                            case 3: Test = (n * (2 * n - 1)); break;
                            case 4: Test = (n * (5 * n - 3)) / 2; break;
                            case 5: Test = (n * (3 * n - 2)); break;
                            default: break;
                        }
                        if (Test < 10000) { Figurates[i].Add(int.Parse(Test.ToString())); }
                        else if (Test > 10000) { break; }
                    }
                }
                for (int i = 0; i <= Figurates[0].Count - 1; i++)
                {
                    toSkip.Add(0);
                    CyclicFinder(Figurates, Figurates[0][i] % 100, toSkip, out Possible);
                }
                foreach (int[,] Fourdigit in Combo) { result += Fourdigit[0, 0]; }
                Console.WriteLine(result);
            }
            public static void CyclicFinder(List<List<int>> Figurates, int Cyclicindicator, List<int> toSkip, out List<List<int>> Possible)
            {
                Possible = new List<List<int>>();
                List<List<int>> NextIteration = new List<List<int>>();
                List<int> toSkipStorage = new List<int>();
                List<int> Storage = new List<int>();
                for (int i = 0; i <= 5; i++)
                {
                    if (toSkip.Contains(i)) { continue; }
                    for (int j = 0; j <= Figurates[i].Count() - 1; j++)
                    {
                        Storage.Clear();
                        if (Figurates[i][j] / 100 == Cyclicindicator)
                        {
                            Storage.Add(Figurates[i][j]); Storage.Add(i);
                            Possible.Add(new List<int>()); Possible[Possible.Count - 1].AddRange(Storage);
                        }
                    }
                }
                for (int i = 0; i <= Possible.Count - 1; i++) { if (Possible[i][0] % 100 < 10) { Possible.Remove(Possible[i]); } }
                if (Possible.Count == 0) { return; }
                for (int i = 0; i <= Possible.Count - 1; i++)
                {
                    toSkipStorage.Clear(); toSkipStorage.AddRange(toSkip); toSkipStorage.Add(Possible[i][1]);
                    if (toSkipStorage.Count == 6)
                    { }
                    CyclicFinder(Figurates, Possible[i][0] % 100, toSkipStorage, out NextIteration);
                    if (NextIteration.Count == 0) { Possible.Clear(); return; }

                }
            }
            public static void Problem_62()
            {
                int CubeCount = 0;
                BigInteger Cube = 0, MaxCube = 0, TestCube = 0, result = 0;
                List<BigInteger> CubeDigits = new List<BigInteger>();
                for (BigInteger x = 345; ; x++)
                {
                    Cube = x * x * x; CubeCount = 0; MaxCube = 0;
                    do { CubeDigits.Add(Cube % 10); Cube /= 10; } while (Cube > 0);
                    CubeDigits.Sort(); CubeDigits.Reverse();
                    foreach (BigInteger i in CubeDigits) { MaxCube = (MaxCube * 10) + i; }
                    for (BigInteger i = x; ; i++)
                    {
                        Cube = i * i * i; CubeDigits.Clear(); TestCube = 0;
                        if (Cube > MaxCube) { break; }
                        do { CubeDigits.Add(Cube % 10); Cube /= 10; } while (Cube > 0);
                        CubeDigits.Sort(); CubeDigits.Reverse();
                        foreach (BigInteger k in CubeDigits) { TestCube = (TestCube * 10) + k; }
                        if (MaxCube == TestCube) { CubeCount++; }
                    }
                    if (CubeCount == 5) { result = (x * x * x); break; }
                }
                Console.WriteLine(result);
            }
            public static void Problem_63()
            {
                int result = 0;
                BigInteger Pow = 0;
                bool Done = false;
                for (int n = 1; ; n++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        Pow = (BigInteger)Math.Pow(j, n);
                        if (Pow.ToString().Length == n) { result++; continue; }
                        if (j == 9 && Pow.ToString().Length < n) { Done = true; break; }
                    }
                    if (Done) { break; }
                }
                Console.WriteLine(result);
            }
            public static void Problem_64()
            {

            }
            public static void Problem_65()
            {
                List<int> FractionList = new List<int>();
                do
                {
                    if (FractionList[FractionList.Count - 1] % 2 == 0) { FractionList.Add(1); }
                    else if (FractionList.Count == 2) { FractionList.Add(2); }
                    else if (FractionList.Count > 2) { FractionList.Add(FractionList[FractionList.Count - 2] + 2); }
                } while (FractionList.Count < 100);
            }
            public static void Problem_66()
            {
                double D = 1, Greatestx = 0, GreatestD = 0, UpperY = 0;
                double x = 0;
                for (double UpperX = 2; ; UpperX++)
                {
                    if (Math.Sqrt(((UpperX * UpperX) - 1) / 1000) % 1.0 == 0) { UpperY = Math.Sqrt(((UpperX * UpperX) - 1) / 1000); break; }
                }
                do
                {
                    do { D++; } while (Math.Sqrt(D) % 1.0 == 0);
                    for (double y = 1; y <= UpperY; y++)
                    {
                        x = Math.Sqrt(1 + D * (y * y));
                        if (x % 1.0 == 0) { if (x > Greatestx) { Greatestx = Convert.ToInt32(x); GreatestD = D; break; } break; }
                    }

                } while (D <= 1000);
                Console.WriteLine("Greatest D <= 1000 is " + GreatestD);
                Console.ReadKey();
            }
            public static void Problem_67()
            {
                string file = "Problem67_BigTriangle.txt";
                string[] Numbers = System.IO.File.ReadAllLines(file);
                List<List<int>> Triangle = new List<List<int>>();
                for (int i = 0; i <= Numbers.Length - 1; i++) { Triangle.Add(Array.ConvertAll(Numbers[i].Split(' '), int.Parse).ToList()); }
                for (int i = Triangle.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j <= Triangle[i].Count - 2; j++)
                    {
                        Triangle[i - 1][j] += Math.Max(Triangle[i][j], Triangle[i][j + 1]);
                    }
                }
                Console.WriteLine("The path through the given triangle with the largest value is " + Triangle[0][0]);
            }
            public static void Problem_68()
            {
                Console.WriteLine("We want to maximise our answer, so all the numbers on the outside of the polygon need to be largest, so 6 - 10.");
                Console.WriteLine("Leaving 1 - 5 on the points of the polygon. 2 * (1+2+3+4+5) + (6+7+8+9+10) = 70. 70 / 5 = 14. Each line of three needs to add to 14.");
                Console.WriteLine("So, for 6, we need to find an additional 8 from the numbers 1 - 5. So use 5 & 3.");
                Console.WriteLine("For 10, we need to find 4 using 3 and another number. Obviously 1.");
                Console.WriteLine("This continues until you get five operations of three digits, making the string 653/1031/914/842/725");
            }
            public static void Problem_69()
            {
                // Finding all Co-Primes of a number is too slow, too many calculations.
                // Quicker answer comes from realising that the the more prime factors a number has, the less Co-Primes it has.
                // i.e. 50 is divisible by 2, so any number that is also divisible by 2 cannot be Co-Prime to it.
                // 60 is divisible by 2 and 3, so any number divisible by 2 or 3 cannot be Co-Prime.
                // Low number of Co-Primes means high ratio. So we just need to find the number with the most distinct prime factors, that is smaller than 1,000,000.
                int result = 2, prime = 3;
                while ((result * prime) < 1000000)
                {
                    result *= prime;
                    prime = Functions.Functions.FindNextPrime(prime);
                }
                Console.WriteLine("The number with the highest Euler's Totient ratio is " + result);
            }
            public static void Problem_70()
            {
                int store, result = 0;
                List<int> nDigits = new List<int>(), PhiNDigits = new List<int>();
                double nOverPhiN = 0;
                for (int n = 10000000; n > 0; n--)
                {
                    nDigits.Clear(); PhiNDigits.Clear();
                    if (!Functions.Functions.isPrime(int.Parse(n.ToString()))) { continue; }
                    store = n; do { nDigits.Add(store % 10); store /= 10; } while (store > 0);
                    PhiNDigits = nDigits; PhiNDigits[PhiNDigits.Count() - 1]--;
                    if (Functions.Functions.isPermutation(nDigits, PhiNDigits))
                    {
                        if (nOverPhiN == 0) { nOverPhiN = n / n - 1; result = n; }
                        else if ((n / n - 1) < nOverPhiN) { nOverPhiN = n / n - 1; result = n; }
                    }
                }
                Console.WriteLine(result);
            }
    }
}