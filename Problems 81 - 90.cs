using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

using Functions;

namespace Euler_90 {
    class Euler_90 {
        static void Problem_81()
            {
                // Must solve this problem in a similar way to the triangle in 18
                // Simply adding to min to get from one corner to another is "greedy minimal picking", and sub-optimal
                // Below adds the bottom and right rows up, and then you go from the bottom up, adding as you go along
                // Basically, solving the smaller problems, and then adding the solutions up to get the correct answer at (0,0) in the grid
                List<List<int>> Grid = new List<List<int>>();
                string[] GridStore = System.IO.File.ReadAllLines("Problem81_Grid.txt");
                for (int i = 0; i <= GridStore.Length - 1; i++) { Grid.Add(new List<int>()); Grid[i] = Array.ConvertAll(GridStore[i].Split(','), k => int.Parse(k)).ToList(); }
                for (int i = 78; i >= 0; i--)
                {
                    Grid[79][i] += Grid[79][i + 1];
                    Grid[i][79] += Grid[i + 1][79];
                }

                for (int i = 78; i >= 0; i--)
                {
                    for (int j = 78; j >= 0; j--)
                    {
                        Grid[i][j] += Math.Min(Grid[i + 1][j], Grid[i][j + 1]);
                    }
                }
                Console.WriteLine(Grid[0][0]);
            }
            static void Problem_87()
            {
                List<int> Primes = new List<int>();
                List<string> Combos = new List<string>();
                int Limit = 49999976;
                bool PrimesDone = false;
                int Prime = 0;
                BigInteger PowerTriple = 0;
                Primes.Add(2); Primes.Add(3); Primes.Add(5);
                do
                {
                    Prime = Functions.Functions.FindNextPrime(Primes.Max());
                    if ((int)Math.Pow(Prime, 2) < Limit) { Primes.Add(Prime); } else { PrimesDone = true; }
                } while (PrimesDone != true);
                for (int i = 0; i <= Primes.Count - 1; i++)
                {
                    for (int j = 0; j <= Primes.Count - 1; j++)
                    {
                        for (int k = 0; k <= Primes.Count - 1; k++)
                        {
                            if ((int)Math.Pow(Primes[k], 4) > 50000000) { break; }
                            PowerTriple = (BigInteger)(Math.Pow(Primes[i], 2) + Math.Pow(Primes[j], 3) + Math.Pow(Primes[k], 4));
                            if (PowerTriple < 50000000)
                            { Combos.Add(PowerTriple.ToString()); }
                        }
                    }
                }
                Combos = Combos.Distinct().ToList();
                Console.WriteLine(Combos.Count());
                GC.Collect();
            }
    }
}