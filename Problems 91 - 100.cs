using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler_100 {
    class Euler_100 {
        public static void Problem_92()
            {
                int count = 0, store = 0;
                List<int> SplitNumber = new List<int>();
                for (int i = 2; i <= 10000000; i++)
                {
                    store = i;
                    do
                    {
                        if (store > 10)
                        {
                            SplitNumber = Array.ConvertAll(store.ToString().ToCharArray(), x => int.Parse(x.ToString())).ToList();
                            store = 0;
                            for (int j = 0; j <= SplitNumber.Count - 1; j++) { store += SplitNumber[j] * SplitNumber[j]; }
                        }
                        else { store *= store; }
                        if (store == 1) { break; } else if (store == 89) { count++; break; }
                    } while (true);
                }
                Console.WriteLine(count);
            }
            public static void Problem_97()
            {
                int[] Digits = new int[10];
                string result;
                Digits[0] = 2;
                for (int i = 2; i <= 7830457; i++)
                {
                    for (int j = 0; j <= 9; j++) { if (Digits[j] != 0) { Digits[j] *= 2; } }
                    for (int j = 0; j <= 9; j++)
                    {
                        if (Digits[j] > 10 & j < 9) { Digits[j + 1] += Digits[j] / 10; Digits[j] %= 10; }
                        if (j == 9 & Digits[j] > 10) { Digits[j] %= 10; }
                    }

                }
                for (int i = 0; i <= 9; i++)
                {
                    Digits[i] *= 28433;
                    if (i < 9) { Digits[i + 1] %= Digits[i]; Digits[i] /= 10; }
                    else { Digits[i] /= 10; }
                }
                Digits[0]++;
                result = String.Join("", Digits);
            }
            public static void Problem_99()
            {
                double[][] Numbers = new double[1000][];
                Double Highest = 0;
                int result = 0;
                Numbers = Array.ConvertAll(System.IO.File.ReadAllLines("Problem99_Numbers.txt"), x => Array.ConvertAll(x.Split(','), y => double.Parse(y)));
                for (int i = 0; i < 1000; i++)
                {
                    do { Numbers[i][1] /= 10; } while (Numbers[i][1] > 1);
                    if (Highest < Math.Pow(Numbers[i][0], Numbers[i][1])) { Highest = Math.Pow(Numbers[i][0], Numbers[i][1]); result = i + 1; }
                }
                Console.WriteLine("Line " + result + " has the highest numeric value.");
            }
    }
}