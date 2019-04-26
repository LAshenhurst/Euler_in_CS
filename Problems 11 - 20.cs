using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

using Functions;

namespace Euler_20 {
    class Euler_20 {
        public static void Problem_11()
            {
                List<List<int>> Table = new List<List<int>>();
                Table = Functions.Functions.Problem_11_Table();
                int BiggestProduct = 0;
                int Product = 0;
                // Left
                for (int j = 0; j < 20; j++)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        Product = Table[j][i] * Table[j][i + 1] * Table[j][i + 2] * Table[j][i + 3];
                        if (Product > BiggestProduct) { BiggestProduct = Product; }
                    }
                }
                // Right
                for (int j = 0; j < 20; j++)
                {
                    for (int i = 19; i > 3; i--)
                    {
                        Product = Table[j][i] * Table[j][i - 1] * Table[j][i - 2] * Table[j][i - 3];
                        if (Product > BiggestProduct) { BiggestProduct = Product; }
                    }
                }
                // Down
                for (int j = 0; j < 16; j++)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Product = Table[j][i] * Table[j + 1][i] * Table[j + 2][i] * Table[j + 3][i];
                        if (Product > BiggestProduct) { BiggestProduct = Product; }
                    }
                }
                // Up
                for (int j = 19; j < 3; j--)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Product = Table[j][i] * Table[j - 1][i] * Table[j - 2][i] * Table[j - 3][i];
                        if (Product > BiggestProduct) { BiggestProduct = Product; }
                    }
                }
                // Diagonal
                for (int j = 0; j < 16; j++)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        Product = Table[j][i] * Table[j + 1][i + 1] * Table[j + 2][i + 2] * Table[j + 3][i + 3];
                        if (Product > BiggestProduct) { BiggestProduct = Product; }
                    }
                }
                for (int j = 19; j > 3; j--)
                {
                    for (int i = 19; i > 3; i--)
                    {
                        Product = Table[j][i] * Table[j - 1][i - 1] * Table[j - 2][i - 2] * Table[j - 3][i - 3];
                        if (Product > BiggestProduct) { BiggestProduct = Product; }
                    }
                }
                Console.WriteLine(BiggestProduct);
            }
            public static void Problem_12()
            {
                int TriangleSize = 7;
                int TriangleNumber = 0;
                int Factors = 0;
                do
                {
                    TriangleSize++;
                    Factors = 0;
                    TriangleNumber = (TriangleSize * (TriangleSize + 1)) / 2;
                    for (int i = 1; i * i < TriangleNumber; i++)
                    {
                        if (TriangleNumber % i == 0) { Factors += 2; }
                    }
                } while (Factors < 500);
                Console.Write("First Triangle number with more than 500 factors is " + TriangleNumber);
            }
            public static void Problem_13()
            {
                string Problem13_Words = "Problem13_Numbers.txt";
                List<string> Numbers = System.IO.File.ReadAllLines(Problem13_Words).ToList();
                List<int> Digits = new List<int>(); int count = 0; char[] DigitChars;
                string result;
                BigInteger QuickResult = 0;
                do
                {
                    DigitChars = Numbers[count].ToCharArray();
                    if (count == 0) { for (int i = 0; i < DigitChars.Length; i++) { Digits.Add(int.Parse(DigitChars[i].ToString())); } }
                    else
                    {
                        for (int i = 49; i > 0; i--) { Digits[i] += int.Parse(DigitChars[i].ToString()); if (Digits[i] >= 10 && i > 0) { Digits[i - 1]++; Digits[i] %= 10; } }
                    }
                    count++;
                } while (count < 100);
                result = string.Join("", Digits);
                foreach (string Number in Numbers) { QuickResult += BigInteger.Parse(Number); }
                Console.WriteLine("Incorrect result, not using BigInteger:" + result);
                Console.WriteLine("Quick result, using BigInteger: " + QuickResult);
                Console.ReadLine();
            }
            public static void Problem_14()
            {
                long Collatz = 0;
                int CollatzChain = 0;
                int MaxCollatzChain = 0;
                int MaxCollatz = 0;
                for (int i = 1; i < 1000000; i++)
                {
                    Collatz = i;
                    CollatzChain = 0;
                    do
                    {
                        if (Collatz == 1) { break; }
                        if (Collatz % 2 == 0) { Collatz /= 2; CollatzChain += 1; }
                        if (Collatz % 2 == 1) { Collatz = ((Collatz * 3) + 1); CollatzChain += 1; }
                    } while (Collatz != 1);
                    if (CollatzChain > MaxCollatzChain) { MaxCollatzChain = CollatzChain; MaxCollatz = i; }
                }
                Console.WriteLine("The number under 1,000,000 that produces the largest Collatz chain is " + MaxCollatz);
                Console.WriteLine("Max Collatz chain for a number under 1,000,000 is " + MaxCollatzChain);
            }
            public static void Problem_15()
            {
                Console.WriteLine("The answer to this requires the use of the Binomial Coefficient.");
                Console.WriteLine("This is mathematically written as 40C20");
                Console.WriteLine("This is calculated by 40! / ((40-20)! 20!) which is 137,846,528,820");
            }
            public static void Problem_16()
            {
                BigInteger BigNumber = BigInteger.Pow(2, 1000), Total = 0;
                do { Total += BigNumber % 10; BigNumber /= 10; } while (BigNumber > 0);
                Console.WriteLine("2^1000 is " + BigInteger.Pow(2, 1000));
                Console.WriteLine("The sum of all the digits that make up 2^1000 is " + Total);
            }
            public static void Problem_17()
            {
                Console.WriteLine("The pattern used to solve this involves a certain amount of recursion.");
                Console.WriteLine("The numbers 1 - 9 written out add up to 36, the numbers 10 - 19 add up to 70");
                Console.WriteLine("We can use the 36 again to add up the digit values for 20 - 99, plus the ten prefixes");
                Console.WriteLine("This results in a total of 854 for the addition from 1 - 99");
                Console.WriteLine("Then we use what we have done here repeatedly to go from 100 - 999. And then add 11 for the 'one thousand'");
                Console.WriteLine("Giving the sum of all the letters used to write out the numbers 1 to 1000 as 21124");
            }
            public static void Problem_18()
            {
                string file = "Problem18_Numbers.txt";
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
            public static void Problem_19()
            {
                int Total = 0;
                for (int year = 1901; year <= 2000; year++)
                {
                    for (int month = 1; month <= 12; month++)
                    {
                        if ((new DateTime(year, month, 1)).DayOfWeek == DayOfWeek.Sunday) { Total++; }
                    }
                }
                Console.WriteLine(Total);
            }
            public static void Problem_20()
            {
                BigInteger Factorial = 1, Total = 0;
                for (int i = 1; i <= 100; i++) { Factorial *= i; }
                do { Total += Factorial % 10; Factorial /= 10; } while (Factorial > 0);
                Console.WriteLine("The sum of the digits in 100! is " + Total);
            }
    }
}