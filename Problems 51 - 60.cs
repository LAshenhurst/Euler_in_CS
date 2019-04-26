using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

using Functions;

namespace Euler_60 {
    class Euler_60 {
        public static void Problem_51()
            {
                // Repeating digit has to be 0, 1, or 2. Otherwise can't get eight digit family.
                // Must have three repeating digits. Otherwise can't get eight digit family.
                List<int> Digits = new List<int>();
                int TestNumber = 56003, storage = 0, result = 0;
                do
                {
                    Digits.Clear();
                    TestNumber = Functions.Functions.FindNextPrime(TestNumber);
                    storage = TestNumber; do { Digits.Add(storage % 10); storage /= 10; } while (storage > 0); Digits.Reverse();
                    result = Functions.Functions.Problem_51_Family_Test(Digits);
                } while (result == 0);

                Console.WriteLine(result);
                Console.ReadKey();
            }
            public static void Problem_52()
            {
                int TestNumber, result = 0;
                List<int> TestDigits = new List<int>(), TestMultipliedDigits = new List<int>();
                bool Found = false;
                for (int i = 125874; ; i++)
                {
                    TestDigits.Clear(); TestMultipliedDigits.Clear();
                    TestNumber = i; do { TestDigits.Add(TestNumber % 10); TestNumber /= 10; } while (TestNumber > 0); TestDigits.Sort();
                    for (int j = 2; j <= 6; j++)
                    {
                        TestMultipliedDigits.Clear();
                        TestNumber = i * j; do { TestMultipliedDigits.Add(TestNumber % 10); TestNumber /= 10; } while (TestNumber > 0); TestMultipliedDigits.Sort();
                        if (TestDigits.Equals(TestMultipliedDigits) == false) { break; }
                        else if (j == 6) { Found = true; result = i; }
                    }
                    if (Found == true) { break; }
                }
                Console.WriteLine("The number that has the same digits for x, 2x, 3x, 4x, 5x, and 6x, is " + result);
            }
            public static void Problem_53()
            {
                BigInteger Combinatorial = 0;
                int result = 0;
                for (int i = 0; i <= 100; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Combinatorial = Functions.Functions.toFactorial(i) / (Functions.Functions.toFactorial(j) * Functions.Functions.toFactorial(i - j));
                        if (Combinatorial > 1000000) { result++; }
                    }
                }
                Console.WriteLine("For n <= 100, nCr is over one million " + result + " times.");
                Console.ReadKey();
            }
            public static void Problem_54()
            {
                string[] Hands = System.IO.File.ReadAllLines("Problem54_PokerHands.txt");
                List<string> PlayerOne_Hands = new List<string>();
                List<string> PlayerTwo_Hands = new List<string>();
                string[] PlayerOne_Hand = new string[5], PlayerTwo_Hand = new string[5], PlayerOne_OrderedHand = new string[5], PlayerTwo_OrderedHand = new string[5];
                string PlayerOne_Result = "", PlayerTwo_Result = "", RoundWinner = "";
                int count = 0;
                for (int i = 0; i <= Hands.Length - 1; i++) { PlayerOne_Hands.Add(Hands[i].Substring(0, 14)); PlayerTwo_Hands.Add(Hands[i].Substring(15)); }
                for (int i = 0; i <= PlayerOne_Hands.Count - 1; i++)
                {
                    PlayerOne_Hand = PlayerOne_Hands[i].Split(' '); PlayerTwo_Hand = PlayerTwo_Hands[i].Split(' ');
                    Functions.Functions.Problem54_HandEvaluator(PlayerOne_Hand, out PlayerOne_Result, out PlayerOne_OrderedHand);
                    Functions.Functions.Problem54_HandEvaluator(PlayerTwo_Hand, out PlayerTwo_Result, out PlayerTwo_OrderedHand);
                    Functions.Functions.Problem54_RoundWinner(PlayerOne_Result, PlayerOne_OrderedHand, PlayerTwo_Result, PlayerTwo_OrderedHand, out RoundWinner);
                    if (RoundWinner == "Player One") { count++; }
                }
                Console.WriteLine("Player One wins " + count + " times.");
            }
            public static void Problem_55()
            {
                List<int> Lychrel = new List<int>();
                BigInteger storage = 0;
                BigInteger PalinTest = 0;
                for (int i = 10; i < 10000; i++)
                {
                    storage = i;
                    for (int j = 0; j < 50; j++)
                    {
                        PalinTest = storage + Functions.Functions.Reversal(storage);
                        storage = PalinTest;
                        if (Functions.Functions.isPalindrome(PalinTest)) { break; }
                        else if (j == 49) { Lychrel.Add(i); }
                    }
                }
                Console.WriteLine("There are " + Lychrel.Count + "Lyrechal numbers under 10,000");
            }
            public static void Problem_56()
            {
                BigInteger Result = 0, Power = 0, PowerDigitSum = 0;
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Power = (BigInteger)Math.Pow(i, j); PowerDigitSum = 0;
                        do { PowerDigitSum += Power % 10; Power /= 10; } while (Power > 0);
                        if (PowerDigitSum > Result) { Result = PowerDigitSum; }
                    }
                }
                Console.WriteLine(Result);
            }
            public static void Problem_57()
            {
                int count = 0;
                BigInteger[] fraction = new BigInteger[2]; fraction[0] = 1; fraction[1] = 1;
                for (int i = 1; i <= 1000; i++)
                {
                    fraction[0] += 2 * fraction[1]; fraction[1] = fraction[0] - fraction[1];
                    if ((int)BigInteger.Log10(fraction[0]) > (int)BigInteger.Log10(fraction[1])) { count++; }
                }
                Console.WriteLine(count);
            }
            public static void Problem_58()
            {
                List<int> UpRight = new List<int>();
                List<int> DownRight = new List<int>();
                List<int> UpLeft = new List<int>();
                List<int> DownLeft = new List<int>();
                int SpiralLength = 7;
                int PrimesCount = 8;
                UpRight.Add(3); UpRight.Add(13); UpRight.Add(31);
                DownRight.Add(9); DownRight.Add(25); DownRight.Add(49);
                UpLeft.Add(5); UpLeft.Add(17); UpLeft.Add(37);
                DownLeft.Add(7); DownLeft.Add(21); DownLeft.Add(43);
                do
                {
                    SpiralLength += 2;
                    UpRight.Add(UpRight[UpRight.Count - 1] + (UpRight[UpRight.Count - 1] - UpRight[UpRight.Count - 2]) + 8);
                    UpLeft.Add(UpLeft[UpLeft.Count - 1] + (UpLeft[UpLeft.Count - 1] - UpLeft[UpLeft.Count - 2]) + 8);
                    DownRight.Add(DownRight[DownRight.Count - 1] + (DownRight[DownRight.Count - 1] - DownRight[DownRight.Count - 2]) + 8);
                    DownLeft.Add(DownLeft[DownLeft.Count - 1] + (DownLeft[DownLeft.Count - 1] - DownLeft[DownLeft.Count - 2]) + 8);
                    if (Functions.Functions.isPrime(UpRight[UpRight.Count - 1])) { PrimesCount++; }
                    if (Functions.Functions.isPrime(UpLeft[UpLeft.Count - 1])) { PrimesCount++; }
                    if (Functions.Functions.isPrime(DownRight[DownRight.Count - 1])) { PrimesCount++; }
                    if (Functions.Functions.isPrime(DownLeft[DownLeft.Count - 1])) { PrimesCount++; }
                } while (PrimesCount * 10 > UpRight.Count * 4);
                Console.WriteLine(SpiralLength);
            }
            public static void Problem_59()
            {

                string FileLocation = "Problem59_CipherText.txt";
                int[] CipherNumbers = Array.ConvertAll(System.IO.File.ReadAllText(FileLocation).Split(','), x => int.Parse(x));
                int[] Key = new int[3];
                int[] NewOption = new int[3];
                int[] DecryptAND = new int[3];
                int[] DecryptTHE = new int[3];
                bool KeyFound = false;
                for (int i = 97; i <= 123; i++)
                {
                    for (int j = 97; j <= 123; j++)
                    {
                        for (int k = 97; k <= 123; k++)
                        {
                            NewOption[0] = i; NewOption[1] = j; NewOption[2] = k;
                            DecryptAND[0] = 97 ^ i; DecryptAND[1] = 110 ^ j; DecryptAND[2] = 100 ^ k;
                            DecryptTHE[0] = 116 ^ i; DecryptTHE[1] = 106 ^ j; DecryptTHE[2] = 104 ^ k;
                            for (int x = 0; x <= CipherNumbers.Length - 3; x++)
                            {
                                if (CipherNumbers.Skip(i).Take(3).SequenceEqual(DecryptAND) || CipherNumbers.Skip(i).Take(3).SequenceEqual(DecryptTHE))
                                { Key = NewOption; KeyFound = true; }
                                if (KeyFound) { break; }
                            }
                            if (KeyFound) { break; }
                        }
                        if (KeyFound) { break; }
                    }
                    if (KeyFound) { break; }
                }

            }
            public static void Problem_60()
            {
                List<int> Primes = new List<int>();
                Primes.Add(2); Primes.Add(3); Primes.Add(5); Primes.Add(7);
                string Concat = "";
                bool result = true; int ResultSum = 0;
                do
                {
                    result = true;
                    Primes.Add(Functions.Functions.FindNextPrime(Primes[Primes.Count - 1]));
                    for (int i = Primes.Count - 5; i < Primes.Count - 1; i++)
                    {
                        Concat = Primes[i].ToString() + Primes[i + 1].ToString();
                        if (Functions.Functions.isPrime(int.Parse(Concat)) == false) { result = false; break; }
                        Concat = Primes[i + 1].ToString() + Primes[i].ToString();
                        if (Functions.Functions.isPrime(int.Parse(Concat)) == false) { result = false; break; }
                    }
                } while (result == false);
                ResultSum = Primes[Primes.Count - 4] + Primes[Primes.Count - 3] + Primes[Primes.Count - 2] + Primes[Primes.Count - 1] + Primes[Primes.Count];
            }
    }
}