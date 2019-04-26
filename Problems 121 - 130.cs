using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

using Functions;

namespace Euler_130 {
    class Euler_130 {
        public static void Problem_124()
            {
                int[] Rads = new int[100000]; List<int> DistinctRads = new List<int>();
                int[] Places = new int[100000];
                List<int> Storage = new List<int>(), n = new List<int>();
                List<double> DistinctPrimes = new List<double>();
                for (int i = 1; i <= 99999; i++)
                {
                    Places[i] = i; Rads[i] = 1;
                    DistinctPrimes = Functions.Functions.DistinctPrimeFactors(i);
                    foreach (int Prime in DistinctPrimes) { Rads[i] *= Prime; }
                }
                DistinctRads.AddRange(Rads.Distinct());
                Array.Sort(Rads, Places);
                for (int i = 0; i <= DistinctRads.Count - 1; i++)
                {
                    Storage.Clear();
                    for (int j = 0; j <= Rads.Length - 1; j++) { if (Rads[j] == DistinctRads[i]) { Storage.Add(Places[j]); } }
                    Storage.Sort(); n.AddRange(Storage);
                }
                Console.WriteLine(n[9999]);
            }
            public static void Problem_125()
            {
                List<int> Palindromes = new List<int>(), Squares = new List<int>();
                int NumOfSquares = 0, SquareSubtractStore = 0;
                BigInteger result = 0;
                int Limit = 100000000, LimitLength = (int)Math.Floor(Math.Log10(Limit) + 1);
                bool SumPossible = true, done = false;
                Palindromes.AddRange(Functions.Functions.PalindromeList(Functions.Functions.PalindromeCalc(LimitLength), Limit));
                for (int i = 0; i <= Palindromes.Count - 1; i++)
                {
                    Squares.Clear(); SumPossible = true; done = false;
                    for (int j = 1; ; j++) { if (j * j < Palindromes[i]) { Squares.Add(j * j); } else if (j * j > Palindromes[i]) { break; } }
                    NumOfSquares = Squares.Count; if (NumOfSquares == 0) { continue; }
                    do
                    {
                        SquareSubtractStore = Palindromes[i];
                        for (int k = NumOfSquares - 1; k >= 0; k--)
                        {
                            SquareSubtractStore -= Squares[k];
                            if (SquareSubtractStore < 0) { NumOfSquares--; break; }
                            else if (SquareSubtractStore == 0) { result += Palindromes[i]; done = true; break; }
                            else if (k == 0 && SquareSubtractStore > 0) { SumPossible = false; break; }
                        }
                    } while (SumPossible && done == false);
                }
                Console.WriteLine(result);
        }
    }
}