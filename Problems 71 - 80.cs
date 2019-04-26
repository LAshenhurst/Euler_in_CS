using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

using Functions;

namespace Euler_80 {
    class Euler_80 {
        static void Problem_71()
            {
                List<int[]> Fractions = new List<int[]>();
                int[] Fraction = new int[2];
                int[] ConstFraction = { 3, 7 };
                double Fract = 0, ConstFract = (3.0 / 7.0);
                int result = 0;
                for (int i = 2; i <= 1000000; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        if (Functions.Functions.GCD(j, i) == 1)
                        {
                            Fraction[0] = j; Fraction[1] = i;
                            Fract = Convert.ToDouble(j) / Convert.ToDouble(i);
                            if (Fract < ConstFract) { Fractions.Add(Fraction); }
                        }
                    }
                }
                Fractions.OrderBy(x => x[1] / x[2]);
                if (Fractions.Contains(ConstFraction)) { result = Fractions[Fractions.IndexOf(ConstFraction) - 1][0]; }
            }
            static void Problem_74()
            {
                List<BigInteger> Factorials = new List<BigInteger>();
                List<BigInteger> Digits = new List<BigInteger>();
                BigInteger Factorial = 0, Storage = 0;
                bool RepeatFound = false;
                int result = 0;
                for (int i = 69; i < 1000000; i++)
                {
                    RepeatFound = false; Factorials.Clear(); Factorials.Add(i);
                    do
                    {
                        Digits.Clear(); Storage = Factorials[Factorials.Count - 1];
                        do { Digits.Add(Storage % 10); Storage /= 10; } while (Storage > 0);
                        Factorial = 0;
                        for (int j = 0; j <= Digits.Count - 1; j++) { Factorial += Functions.Functions.toFactorial(Digits[j]); }
                        if (Factorials.Contains(Factorial)) { RepeatFound = true; }
                        else { Factorials.Add(Factorial); }
                    } while (RepeatFound == false);
                    if (Factorials.Count == 60) { result++; }
                }
                Console.WriteLine(result);
            }
            static void Problem_76()
            {
                // Must use dynamic programming to easily get full answer.
                const int target = 100;
                int[] ways = new int[target + 1];
                ways[0] = 1;
                for (int i = 1; i <= target - 1; i++) { for (int j = i; j <= target; j++) { ways[j] += ways[j - i]; } }
                Console.WriteLine(ways[100]);
            }
            static void Problem_79()
            {
                // Answer is 73162890. Doesn't need to be coded.
                string AttemptsFile = "Problem79_PasscodeAttempts.txt";
                string[] Attempts = System.IO.File.ReadAllLines(AttemptsFile); Attempts = Attempts.Distinct().ToArray();
                char[][] AttemptsChars = Array.ConvertAll(Attempts, x => x.ToCharArray());
                char[] FirstValues = new char[Attempts.Length], SecondValues = new char[Attempts.Length], ThirdValues = new char[Attempts.Length];
                List<char> AllValuesinCode = new List<char>(), FirstByCount = new List<char>(), ExceptionsSearch = new List<char>(), Answer = new List<char>();
                for (int i = 0; i <= AttemptsChars.Length - 1; i++) { FirstValues[i] = AttemptsChars[i][0]; SecondValues[i] = AttemptsChars[i][1]; ThirdValues[i] = AttemptsChars[i][2]; }
                AllValuesinCode.AddRange(FirstValues.Union(SecondValues).Union(ThirdValues));
                FirstByCount = FirstValues.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).Distinct().ToList();
                // 7 is most common first value. It is first value in passcode. To prove, we check if 7 appears in the array of second values.
                for (int j = 0; j <= SecondValues.Length - 1; j++)
                {
                    if (SecondValues[j] == FirstByCount[0])
                    { Console.WriteLine("Shit be broken."); return; }
                    if (j == SecondValues.Length - 1) { Answer.Add(FirstByCount[0]); AllValuesinCode.Remove(FirstByCount[0]); }
                }
                for (int k = 1; k <= FirstByCount.Count - 1; k++)
                {
                    ExceptionsSearch.Clear();
                    // To find other values, search for exceptions. 3 is second most common. If 3 is not second value in answer, there will be an entry "x3y" where x != 7
                    for (int i = 1; i <= SecondValues.Length - 1; i++) { if (SecondValues[i] == FirstByCount[k]) { ExceptionsSearch.Add(FirstValues[i]); } }
                    for (int i = 0; i <= ExceptionsSearch.Count - 1; i++)
                    {
                        if (Answer.Contains(ExceptionsSearch[i]) == false)
                        {
                            Answer.Add(ExceptionsSearch[i]); AllValuesinCode.Remove(ExceptionsSearch[i]);
                            AllValuesinCode.Remove(ExceptionsSearch[i]); FirstByCount.Remove(ExceptionsSearch[i]); k--; break;
                        }
                        else if (i == ExceptionsSearch.Count - 1) { Answer.Add(FirstByCount[k]); AllValuesinCode.Remove(FirstByCount[k]); }
                    }
                }
                // This leaves two digits left. One will be the last digit. Therefore can only be found in third set of values.
                if (SecondValues.Contains(AllValuesinCode[0])) { Answer.Add(AllValuesinCode[0]); AllValuesinCode.Remove(AllValuesinCode[0]); }
                else { Answer.Add(AllValuesinCode[1]); AllValuesinCode.Remove(AllValuesinCode[1]); }
                Answer.Add(AllValuesinCode[0]);
                Console.WriteLine("Code is " + new string(Answer.ToArray()));
            }
            static void Problem_80()
            {
                int Total = 0;
                for (int i = 2; i <= 100; i++)
                {
                    if (Math.Sqrt(i) % 1.0 == 0.0) { continue; }
                    else { Total += Functions.Functions.SqrtDecimals(i, 100); }
                }
                Console.WriteLine(Total);
            }
    }
}