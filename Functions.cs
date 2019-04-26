using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Functions {
    public class Functions
    {
        public static Boolean isPalindrome(BigInteger PalinTest)
        {
            char[] Reversed = PalinTest.ToString().ToCharArray(); Array.Reverse(Reversed);
            if (PalinTest.ToString() == new string(Reversed)) { return true; }
            else { return false; }
        }
        public static Boolean isPrime(int Number)
        {
            if (Number <= 1) { return false; }
            for (int i = 2; i * i <= Number; i++) { if (Number % i == 0) { return false; } }
            return true;
        }
        public static Boolean isPandigital(string n)
        {
	    if (n.Length == 1) { return false; }
            char[] digits = n.ToCharArray();
            Array.Sort(digits);
            string sorted = new string(digits);
            for (int i = 0; i < digits.Length; i++) { if (int.Parse(digits[i].ToString()) != i) { return false; } }
            return true;
        }
        public static Boolean isTriangle(int Number)
        {
            double discriminant = Math.Sqrt((8 * Number) + 1);
            int IntDiscriminant = 0;
            if (int.TryParse(discriminant.ToString(), out IntDiscriminant)) { if (-1 + IntDiscriminant % 2 == 0) { return true; } else { return false; } }
            else { return false; }
        }
        public static Boolean isPentagonal(int Number)
        {
            // P(n) = n(3n - 1) / 2
            // 3*n^2 - n - 2P(n) = 0
            // Quadratic formula on ^
            int result = 0;
            double Unpentagonal = Math.Sqrt((Number * 24) + 1);
            if (int.TryParse(Unpentagonal.ToString(), out result)) { if ((result + 1) % 6 == 0) { return true; } else { return false; } }
            else { return false; }
        }
        public static Boolean isHexagonal(int Number)
        {
            double Discriminant = Math.Sqrt(1 + 8 * Number);
            int IntDiscriminant = 0;
            if (int.TryParse(Discriminant.ToString(), out IntDiscriminant)) { if ((1 + IntDiscriminant) % 4 == 0) { return true; } else { return false; } }
            else { return false; }
        }
        public static Boolean isPermutation(List<int> n1, List<int> n2)
        {
            n1.Sort(); n2.Sort();
            if (n1.Equals(n2) & n2.Equals(n1)) { return true; }
            else { return false; }
        }

        public static List<List<int>> Problem_11_Table()
        {
            List<List<int>> Result = new List<List<int>>();
            int[] RowOne = { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75, 4, 5, 7, 78, 52, 12, 50, 77, 91, 8 };
            int[] RowTwo = { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 0 };
            int[] RowThree = { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 3, 49, 13, 36, 65 };
            int[] RowFour = { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24, 68, 56, 1, 32, 56, 71, 37, 2, 36, 91 };
            int[] RowFive = { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 };
            int[] RowSix = { 24, 47, 32, 60, 99, 3, 45, 2, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 };
            int[] RowSeven = { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 };
            int[] RowEight = { 67, 26, 20, 68, 2, 62, 12, 20, 95, 63, 94, 39, 63, 8, 40, 91, 66, 49, 94, 21 };
            int[] RowNine = { 24, 55, 58, 5, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 };
            int[] RowTen = { 21, 36, 23, 9, 75, 0, 76, 44, 20, 45, 35, 14, 0, 61, 33, 97, 34, 31, 33, 95 };
            int[] RowEleven = { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 3, 80, 4, 62, 16, 14, 9, 53, 56, 92 };
            int[] RowTwelve = { 16, 39, 5, 42, 96, 35, 31, 47, 55, 58, 88, 24, 0, 17, 54, 24, 36, 29, 85, 57 };
            int[] RowThirteen = { 86, 56, 0, 48, 35, 71, 89, 7, 5, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 };
            int[] RowFourteen = { 19, 80, 81, 68, 5, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 4, 89, 55, 40 };
            int[] RowFifteen = { 4, 52, 8, 83, 97, 35, 99, 16, 7, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 };
            int[] RowSixteen = { 88, 36, 68, 87, 57, 62, 20, 72, 3, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 };
            int[] RowSeventeen = { 4, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 8, 46, 29, 32, 40, 62, 76, 36 };
            int[] RowEighteen = { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 4, 36, 16 };
            int[] RowNineteen = { 20, 73, 35, 29, 78, 31, 90, 1, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 5, 54 };
            int[] RowTwenty = { 1, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 1, 89, 19, 67, 48 };
            Result.Add(RowOne.ToList<int>()); Result.Add(RowTwo.ToList<int>()); Result.Add(RowThree.ToList<int>());
            Result.Add(RowFour.ToList<int>()); Result.Add(RowFive.ToList<int>()); Result.Add(RowSix.ToList<int>());
            Result.Add(RowSeven.ToList<int>()); Result.Add(RowEight.ToList<int>()); Result.Add(RowNine.ToList<int>());
            Result.Add(RowTen.ToList<int>()); Result.Add(RowEleven.ToList<int>()); Result.Add(RowTwelve.ToList<int>());
            Result.Add(RowThirteen.ToList<int>()); Result.Add(RowFourteen.ToList<int>()); Result.Add(RowFifteen.ToList<int>());
            Result.Add(RowSixteen.ToList<int>()); Result.Add(RowSeventeen.ToList<int>()); Result.Add(RowEighteen.ToList<int>());
            Result.Add(RowNineteen.ToList<int>()); Result.Add(RowTwenty.ToList<int>()); return Result;
        }
        public static int AlphabeticalValue(char Letter)
        {
            if (Letter == '"') { return 0; } else { return (int)Letter % 32; }
        }
        public static BigInteger toFactorial(BigInteger i)
        {
            if (i == 0) { return 1; }
            BigInteger p = 1;
            for (BigInteger j = 1; j <= i; j++) { p *= j; }
            return p;
        }
        public static int GCD(int numerator, int demoninator)
        {
            int GreatestCommon = 1;
            int Remainder = numerator % demoninator;
            if (Remainder > 0) { GreatestCommon = GCD(demoninator, Remainder); }
            else if (Remainder == 0) { GreatestCommon = demoninator; }
            return GreatestCommon;
        }
        public static List<BigInteger> Permutations(BigInteger[] elements)
        {
            List<BigInteger> GivenElements = new List<BigInteger>();
            List<BigInteger> RecursiveResult = new List<BigInteger>();
            List<BigInteger> Result = new List<BigInteger>();
            BigInteger Temp = 0;
            GivenElements = elements.ToList<BigInteger>();
            for (int i = 0; i <= elements.Length - 1; i++) { if (elements[i] / 10 > 0) { return Result; } }
            if (elements.Length == 1) { Result.Add(elements[0]); return Result; }
            if (elements.Length == 2)
            {
                Result.Add((elements[0] * 10) + elements[1]); Result.Add((elements[1] * 10) + elements[0]);
                return Result;
            }
            for (int i = 0; i <= elements.Length - 1; i++)
            {
                GivenElements = elements.ToList<BigInteger>();
                GivenElements.RemoveAt(i);
                RecursiveResult = Permutations(GivenElements.ToArray<BigInteger>());
                foreach (BigInteger x in RecursiveResult) { Result.Add(x + (elements[i] * (BigInteger)Math.Pow(10, elements.Length - 1))); }
            }
            return Result;
        }
        public static List<int> PrimeFactors(int Number)
        {
            List<int> DivisiblePrimes = new List<int>();
            List<int> AllPrimes = new List<int>();
            int NumberTemp = Number;
            for (int i = 2; i <= Math.Sqrt(Number); i++)
            {
                if (Functions.isPrime(i))
                {
                    AllPrimes.Add(i);
                    if (Functions.isPrime(Number / i)) { AllPrimes.Add(Number / i); }
                }
            }
            for (int i = 0; i <= AllPrimes.Count - 1; i++)
            {
                if (NumberTemp == 1) { break; }
                while (NumberTemp % AllPrimes[i] == 0)
                {
                    NumberTemp /= AllPrimes[i];
                    DivisiblePrimes.Add(AllPrimes[i]);
                }
            }
            return DivisiblePrimes;
        }
        public static int FindNextPrime(int MaxPrime)
        {
            int count = MaxPrime;
            if (count % 2 == 0) { count++; if (isPrime(count)) { return count; } }
            do { count += 2; if (isPrime(count)) { return count; } } while (true);
        }
        public static double Decimal_Root_Two_Recursion(int RecursionCount, int MaxCount)
        {
            if (RecursionCount == 1) { return (double)1 / (double)2; }
            else if (RecursionCount > 1 && RecursionCount < MaxCount) { return (double)(1 / (2 + Decimal_Root_Two_Recursion(RecursionCount - 1, MaxCount))); }
            else if (RecursionCount == MaxCount) { return 1 + (double)(1 / (2 + Decimal_Root_Two_Recursion(RecursionCount - 1, MaxCount))); }
            else return 0;
        }
        public static int[] Fractional_Root_Two_Recursion(int Iterations)
        {
            int[] result = new int[2]; result[0] = 1; result[1] = 1;
            for (int i = 1; i <= Iterations; i++) { result[0] += 2 * result[1]; result[1] = result[0] - result[1]; }
            return result;
        }
        public static BigInteger Reversal(BigInteger Reverse)
        {
            BigInteger result = 0;
            BigInteger storage = Reverse;
            int length = Reverse.ToString().Length;
            if (Reverse < 10) { return Reverse; }
            for (int i = 1; i <= length; i++)
            {
                result += (storage % 10) * (BigInteger)Math.Pow(10, length - i);
                storage /= 10;
            }
            return result;
        }
        public static BigInteger TriPentHexNumberConvert(string Type, BigInteger toConvert, BigInteger Converted)
        {
            if (toConvert > int.MaxValue || Converted > int.MaxValue) { return 0; }
            if (Type == "Tri")
            {
                if (Converted == 0) { return ((toConvert * (toConvert + 1)) / 2); }
                if (toConvert == 0 && isTriangle(Convert.ToInt32(Converted))) { return (BigInteger)((-1 + Math.Sqrt((8 * Convert.ToInt32(Converted)) + 1)) / 2); }
                else { return 0; }
            }
            else if (Type == "Pent")
            {
                if (Converted == 0) { return ((toConvert * ((3 * toConvert) - 1)) / 2); }
                if (toConvert == 0 && isPentagonal(Convert.ToInt32(Converted))) { return (BigInteger)((1 + Math.Sqrt((Convert.ToInt32(Converted) * 24) + 1)) / 6); }
                else { return 0; }
            }
            else if (Type == "Hex")
            {
                if (Converted == 0) { return (toConvert * ((2 * toConvert) - 1)); }
                if (toConvert == 0 && isHexagonal(Convert.ToInt32(Converted))) { return (BigInteger)((1 + Math.Sqrt(1 + (8 * Convert.ToInt32(Converted)))) / 4); }
                else { return 0; }
            }
            else { return 0; }
        }
        public static List<int> XtotheX(int x)
        {
            // Returns Digits in reverse order
            List<int> Digits = new List<int>();
            int storage = x;
            do { Digits.Add(storage % 10); storage /= 10; } while (storage > 0);
            for (int i = 1; i <= x - 1; i++)
            {
                for (int j = 0; j <= Digits.Count - 1; j++) { Digits[j] *= x; }
                for (int j = 0; j <= Digits.Count - 1; j++)
                {
                    do
                    {
                        if (Digits[j] >= 10) { if (j == Digits.Count - 1) { Digits.Add(Digits[j] / 10); Digits[j] %= 10; } else { Digits[j + 1] += Digits[j] / 10; Digits[j] %= 10; } }
                    } while (Digits[j] >= 10);
                }
            }
            return Digits;
        }
        public static int Problem_51_Family_Test(List<int> Numbers)
        {
            List<int> Digits = Numbers;
            int storage = 0, PrimeCount = 0, smallest = 0;
            bool smallestrecorded = false;
            for (int i = 0; i <= Numbers.Count - 1; i++)
            {
                for (int j = i + 1; j <= Numbers.Count - 1; j++)
                {
                    for (int k = j + 1; k <= Numbers.Count - 1; k++)
                    {
                        for (int repeat = 0; repeat <= 2; repeat++)
                        {
                            smallestrecorded = false; Digits = Numbers; PrimeCount = 0;
                            for (int count = 0; count <= (9 - repeat); count++)
                            {
                                storage = 0;
                                Digits[i] = repeat + count; Digits[j] = repeat + count; Digits[k] = repeat + count;
                                for (int f = 0; f <= Numbers.Count - 1; f++) { storage = (storage * 10) + Numbers[f]; }
                                if (storage.ToString().Length < Numbers.Count) { continue; }
                                if (isPrime(storage)) { PrimeCount++; if (smallestrecorded == false) { smallest = storage; smallestrecorded = true; } }
                            }
                            if (PrimeCount == 8)
                            { return smallest; }

                        }
                    }
                }
            }
            if (PrimeCount == 8) { return storage; } else { return 0; }
        }
        public static void Problem54_HandEvaluator(string[] Player_Hand, out string Player_Result, out string[] Ordered_Hand)
        {
            Player_Result = ""; Ordered_Hand = new string[5];
            string[] CardValues = new string[5], CardSuits = new string[5]; int[] CardValue_Numbers = new int[5];
            char[] CardSplit = new char[2];
            if (Player_Hand.Length != 5) { return; }
            for (int i = 0; i <= 4; i++) { CardSplit = Player_Hand[i].ToCharArray(); CardValues[i] = CardSplit[0].ToString(); CardSuits[i] = CardSplit[1].ToString(); }
            CardValue_Numbers = Array.ConvertAll(Problem54_CardValues(CardValues, "Convert"), Value => int.Parse(Value)); Array.Sort(CardValue_Numbers); Array.Reverse(CardValue_Numbers);
            Ordered_Hand = Problem54_OrderedHand(Array.ConvertAll(CardValues, x => Convert.ToChar(x)), Array.ConvertAll(CardSuits, x => Convert.ToChar(x)), CardValue_Numbers);
            if (Player_Hand.Contains<string>("A") && Player_Hand.Contains<string>("K") && Player_Hand.Contains<string>("Q") && Player_Hand.Contains<string>("J") &&
                Player_Hand.Contains<string>("T") && CardSuits.Distinct().Count() == 1) { Player_Result = "Royal Flush"; return; }
            else if (Player_Hand.All(Card => Card.Contains("S"))) { Player_Result = "Flush Spades"; }
            else if (Player_Hand.All(Card => Card.Contains("H"))) { Player_Result = "Flush Hearts"; }
            else if (Player_Hand.All(Card => Card.Contains("D"))) { Player_Result = "Flush Diamonds"; }
            else if (Player_Hand.All(Card => Card.Contains("C"))) { Player_Result = "Flush Clubs"; }
            if (Player_Result != "" && Player_Result.Substring(0, 4) == "Flush" && !CardValue_Numbers.Select((i, j) => i - j).Distinct().Skip(1).Any()) { Player_Result = "Straight " + Player_Result; return; }
            if (Player_Result != "") { return; }
            string[] FrequencyOrder = CardValues.OrderByDescending(g => g.Count()).ToArray();
            int MostFrequentCount = Convert.ToInt32(CardValues.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First().Count());
            if (!CardValue_Numbers.Select((i, j) => i - j).Distinct().Skip(1).Any()) { Player_Result = "Straight " + Problem54_CardValues(Array.ConvertAll(CardValue_Numbers, x => x.ToString()), "Revert")[0]; }
            switch (CardValues.Distinct().Count())
            {
                case 2:
                    if (MostFrequentCount == 3) { Player_Result = "Full House " + FrequencyOrder[0] + " and " + FrequencyOrder[3]; return; }
                    if (MostFrequentCount == 4) { Player_Result = "Four of a Kind " + FrequencyOrder[0]; return; }
                    break;
                case 3:
                    if (MostFrequentCount == 2) { Player_Result = "Two Pair " + FrequencyOrder[0] + " and " + FrequencyOrder[1]; return; }
                    if (MostFrequentCount == 3) { Player_Result = "Three of a Kind " + FrequencyOrder[0]; return; }
                    break;
                case 4:
                    Player_Result = "Pair " + FrequencyOrder[0]; return;
                case 5:
                    Player_Result = "Highest Card " + Problem54_CardValues(Array.ConvertAll(CardValue_Numbers, Number => Number.ToString()), "Revert")[0]; return;
                default: break;
            }
            return;
        }
        public static string[] Problem54_OrderedHand(char[] CardValues, char[] CardSuits, int[] CardValue_Numbers)
        {
            string[] Result = new string[5];
            Result = Problem54_CardValues(Array.ConvertAll(CardValue_Numbers, x => x.ToString()), "Revert");
            for (int i = 0; i <= 4; i++) { for (int j = 0; j <= 4; j++) { if (Convert.ToChar(Result[i]) == CardValues[j]) { Result[i] += CardSuits[j]; break; } } }
            return Result;
        }
        public static void Problem54_RoundWinner(string PlayerOne_Result, string[] PlayerOne_Hand, string PlayerTwo_Result, string[] PlayerTwo_Hand, out string Winner)
        {
            Winner = "";
            string[] PlayerOne_CardSuits = new string[5], PlayerTwo_CardSuits = new string[5];
            string[] PlayerOne_CardValues = new string[5], PlayerTwo_CardValues = new string[5];
            char[] Cardsplit;
            for (int i = 0; i <= 4; i++)
            {
                Cardsplit = PlayerOne_Hand[i].ToCharArray(); PlayerOne_CardValues[i] = Cardsplit[0].ToString(); PlayerOne_CardSuits[i] = Cardsplit[1].ToString();
                Cardsplit = PlayerTwo_Hand[i].ToCharArray(); PlayerTwo_CardValues[i] = Cardsplit[0].ToString(); PlayerTwo_CardSuits[i] = Cardsplit[1].ToString();
            }
            if (PlayerOne_Result.Contains("Royal") && PlayerTwo_Result.Contains("Royal") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Royal") && PlayerOne_Result.Contains("Royal") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Straight Flush") && PlayerTwo_Result.Contains("Straight Flush") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Straight Flush") && PlayerOne_Result.Contains("Straight Flush") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Straight Flush") && PlayerTwo_Result.Contains("Straight Flush"))
            {
                PlayerOne_CardValues = Problem54_CardValues(PlayerOne_CardValues, "Convert"); PlayerTwo_CardValues = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(PlayerOne_CardValues.Max()) > int.Parse(PlayerTwo_CardValues.Max())) { Winner = "Player One"; return; }
                if (int.Parse(PlayerTwo_CardValues.Max()) > int.Parse(PlayerOne_CardValues.Max())) { Winner = "Player Two"; return; }
            }
            if (PlayerOne_Result.Contains("Four") && PlayerTwo_Result.Contains("Four") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Four") && PlayerOne_Result.Contains("Four") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Four") && PlayerTwo_Result.Contains("Four"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    PlayerOne_CardValues = Problem54_CardValues(PlayerOne_CardValues, "Convert"); PlayerTwo_CardValues = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                    if (int.Parse(PlayerOne_CardValues.Max()) > int.Parse(PlayerTwo_CardValues.Max())) { Winner = "Player One"; return; }
                    if (int.Parse(PlayerTwo_CardValues.Max()) > int.Parse(PlayerOne_CardValues.Max())) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("Full") && PlayerTwo_Result.Contains("Full") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Full") && PlayerOne_Result.Contains("Full") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Full") && PlayerTwo_Result.Contains("Full"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                    if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("Flush") && PlayerTwo_Result.Contains("Flush") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Flush") && PlayerOne_Result.Contains("Flush") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Flush") && PlayerTwo_Result.Contains("Flush"))
            {
                PlayerOne_CardValues = Problem54_CardValues(PlayerOne_CardValues, "Convert"); PlayerTwo_CardValues = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(PlayerOne_CardValues.Max()) > int.Parse(PlayerTwo_CardValues.Max())) { Winner = "Player One"; return; }
                if (int.Parse(PlayerTwo_CardValues.Max()) > int.Parse(PlayerOne_CardValues.Max())) { Winner = "Player Two"; return; }
            }
            if (PlayerOne_Result.Contains("Straight") && PlayerTwo_Result.Contains("Straight") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Straight") && PlayerOne_Result.Contains("Straight") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Straight") && PlayerTwo_Result.Contains("Straight"))
            {
                PlayerOne_CardValues = Problem54_CardValues(PlayerOne_CardValues, "Convert"); PlayerTwo_CardValues = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(PlayerOne_CardValues.Max()) > int.Parse(PlayerTwo_CardValues.Max())) { Winner = "Player One"; return; }
                if (int.Parse(PlayerTwo_CardValues.Max()) > int.Parse(PlayerOne_CardValues.Max())) { Winner = "Player Two"; return; }
            }
            if (PlayerOne_Result.Contains("Three") && PlayerTwo_Result.Contains("Three") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Three") && PlayerOne_Result.Contains("Three") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Three") && PlayerTwo_Result.Contains("Three"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    if (int.Parse(P1FrequencyOrder[3]) > int.Parse(P2FrequencyOrder[3])) { Winner = "Player One"; return; }
                    if (int.Parse(P2FrequencyOrder[3]) > int.Parse(P1FrequencyOrder[3])) { Winner = "Player Two"; return; }

                    if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                    if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("Two") && PlayerTwo_Result.Contains("Two") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("Two") && PlayerOne_Result.Contains("Two") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("Two") && PlayerTwo_Result.Contains("Two"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    if (int.Parse(P1FrequencyOrder[2]) > int.Parse(P2FrequencyOrder[2])) { Winner = "Player One"; return; }
                    if (int.Parse(P2FrequencyOrder[2]) > int.Parse(P1FrequencyOrder[2])) { Winner = "Player Two"; return; }
                    if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                    if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("One") && PlayerTwo_Result.Contains("One") == false) { Winner = "Player One"; return; }
            if (PlayerTwo_Result.Contains("One") && PlayerOne_Result.Contains("One") == false) { Winner = "Player Two"; return; }
            if (PlayerOne_Result.Contains("One") && PlayerTwo_Result.Contains("One"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (int.Parse(P1FrequencyOrder[0]) > int.Parse(P2FrequencyOrder[0])) { Winner = "Player One"; return; }
                if (int.Parse(P2FrequencyOrder[0]) > int.Parse(P1FrequencyOrder[0])) { Winner = "Player Two"; return; }
                if (int.Parse(P1FrequencyOrder[0]) == int.Parse(P2FrequencyOrder[0]))
                {
                    if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                    if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
                }
            }
            if (PlayerOne_Result.Contains("Highest") && PlayerTwo_Result.Contains("Highest"))
            {
                string[] P1FrequencyOrder = Problem54_CardValues(PlayerOne_CardValues, "Convert");
                string[] P2FrequencyOrder = Problem54_CardValues(PlayerTwo_CardValues, "Convert");
                if (Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player One"; return; }
                if (Array.ConvertAll(P2FrequencyOrder, x => int.Parse(x)).Max() > Array.ConvertAll(P1FrequencyOrder, x => int.Parse(x)).Max()) { Winner = "Player Two"; return; }
            }
        }
        public static string[] Problem54_CardValues(string[] CardNumbers, string Convert_Revert)
        {
            string[] result = new string[5];
            if (CardNumbers.Length < 5) { return null; }
            if (Convert_Revert == "Convert")
            {
                for (int i = 0; i <= 4; i++)
                {
                    switch (CardNumbers[i])
                    {
                        case "2": result[i] = "2"; break;
                        case "3": result[i] = "3"; break;
                        case "4": result[i] = "4"; break;
                        case "5": result[i] = "5"; break;
                        case "6": result[i] = "6"; break;
                        case "7": result[i] = "7"; break;
                        case "8": result[i] = "8"; break;
                        case "9": result[i] = "9"; break;
                        case "T": result[i] = "10"; break;
                        case "J": result[i] = "11"; break;
                        case "Q": result[i] = "12"; break;
                        case "K": result[i] = "13"; break;
                        case "A": result[i] = "14"; break;
                        default: break;
                    }
                }
            }
            else if (Convert_Revert == "Revert")
            {
                for (int i = 0; i <= 4; i++)
                {
                    switch (CardNumbers[i])
                    {
                        case "14": result[i] = "A"; break;
                        case "13": result[i] = "K"; break;
                        case "12": result[i] = "Q"; break;
                        case "11": result[i] = "J"; break;
                        case "10": result[i] = "T"; break;
                        case "9": result[i] = "9"; break;
                        case "8": result[i] = "8"; break;
                        case "7": result[i] = "7"; break;
                        case "6": result[i] = "6"; break;
                        case "5": result[i] = "5"; break;
                        case "4": result[i] = "4"; break;
                        case "3": result[i] = "3"; break;
                        case "2": result[i] = "2"; break;
                        default: break;
                    }
                }

            }

            return result;
        }
        public static int[] DecToFrac(double Dec)
        {
            int[] result = new int[2];
            int Divisor = 0;
            result[0] = (int)(Dec * 100);
            result[1] = 100;
            do
            {
                Divisor = GCD(result[0], result[1]);
                if (Divisor > 1) { result[0] /= Divisor; result[1] /= Divisor; }
            } while (Divisor != 1);
            return result;
        }
        public static int SqrtDecimals(int n, int DecimalPlaces)
        {
            // See https://en.wikipedia.org/wiki/Methods_of_computing_square_roots#Decimal_.28base_10.29
            List<int> Result = new List<int>();
            BigInteger y = 0, p = 0, c = 0;
            BigInteger remainder = 0;
            int count = n, total = 0;
            while (y == 0)
            {
                if (Math.Sqrt(count) % 1.0 == 0) { y = count; Result.Add((int)Math.Sqrt(count)); remainder = n - count; } else { count--; }
            }
            for (int i = 1; i < DecimalPlaces; i++)
            {
                p *= 10; p += Result[Result.Count - 1];
                c = remainder * 100;
                for (BigInteger j = 1; ; j++)
                {
                    if ((((20 * p) + j) * j) > c)
                    {
                        Result.Add((int)j - 1);
                        y = (((20 * p) + (j - 1)) * (j - 1));
                        remainder = c - y;
                        break;
                    }
                }
            }
            foreach (int DecimalInteger in Result) { total += DecimalInteger; }
            return total;
        }
        public static int RomanConvert(char Roman)
        {
            switch (Roman)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
        public static string RomanEfficient(string Roman)
        {
            char[] RomanChars = Roman.ToCharArray();
            int RomanCharsCount = RomanChars.Count();
            int[] RomanNumbers = new int[RomanCharsCount];
            int total = 0, converted = 0, temp = 0;
            string result = "";
            for (int i = 0; i <= RomanCharsCount - 1; i++) { converted = RomanConvert(RomanChars[i]); total += converted; RomanNumbers[i] = converted; }
            for (int i = 0; i <= RomanCharsCount - 1; i++)
            {
                if (RomanChars[i] == 'M') { result += "M"; continue; }
                if (RomanChars[i] == 'D')
                {
                    if (i == RomanCharsCount - 1) { result += "D"; continue; }
                    if (RomanChars[i + 1] == 'D') { result += "M"; total++; i++; continue; }
                    else { result += "D"; continue; }
                }
                if (RomanChars[i] == 'C')
                {
                    if (RomanChars[i + 1] == 'D') { result += "CD"; i++; continue; }
                    if (RomanChars[i + 1] == 'M') { result += "CM"; i++; continue; }
                    for (int j = i + 1; j <= RomanCharsCount - 1; j++)
                    {
                        if (RomanChars[j] == 'C') { temp++; continue; }
                        else
                        {
                            if (temp == 4) { result += "CD"; total += 2; break; }
                            for (int k = 0; k <= temp; k++) { result += "C"; }
                        }

                    }
                }
            }
            return "test";
        }
        public static int TriangleArea(int[] a, int[] b, int[] c)
        {
            return Math.Abs((a[0] - c[0]) * (b[1] - a[1]) - (a[0] - b[0]) * (c[1] - a[1]));
        }
        public static bool Figurate_Converter(double number, int figurate)
        {
            switch (figurate)
            {
                case 3: if ((-1 + Math.Sqrt(number * 8 + 1)) % 2 == 0) { return true; } else { return false; }
                case 4: if (Math.Sqrt(number) % 1 == 0) { return true; } else { return false; }
                case 5: if ((1 + Math.Sqrt(number * 8 + 1)) % 6 == 0) { return true; } else { return false; }
                case 6: if ((1 + Math.Sqrt(number * 4 + 1)) % 4 == 0) { return true; } else { return false; }
                case 7: if ((3 + Math.Sqrt(number * 40 + 9)) % 10 == 0) { return true; } else { return false; }
                case 8: if ((2 + Math.Sqrt(number * 12 + 4)) % 6 == 0) { return true; } else { return false; }
                default: return false;
            }
        }
        public static List<double> DistinctPrimeFactors(int number)
        {
            double Prime = 2, test = double.Parse(number.ToString());
            List<double> Primes = new List<double>();
            if (number == 1) { Primes.Add(1); return Primes; }
            do
            {
                if (test / Prime % 1 == 0) { Primes.Add(Prime); do { test /= Prime; } while (test / Prime % 1 == 0); Prime = 2; }
                else { Prime = FindNextPrime(int.Parse(Prime.ToString())); }
            } while (test != 1);
            Primes = Primes.Distinct().ToList();
            return Primes;
        }
        public static List<List<char>> PalindromeCalc(int MaxLength)
        {
            // MaxLength gives length of number given, so 100 returns 3, all one, two, and three digit Palindromes calculated. All Palindromes > Max are removed later.
            List<List<char>> Palindromes = new List<List<char>>(), Incomplete = new List<List<char>>();
            char[] Digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            List<char> TempPalindrome = new List<char>();
            // Create the single digit palindromes (i.e. 0 - 9)
            if (MaxLength >= 1) { for (int i = 0; i <= 9; i++) { Palindromes.Add(new List<char>()); Palindromes[Palindromes.Count - 1].Add(Digits[i]); } }
            if (MaxLength >= 2)
            {
                // Create the two-digit palindromes (i.e. xx for x in [1,9])
                for (int i = 1; i <= 9; i++)
                {
                    TempPalindrome.Clear(); TempPalindrome.Add(Digits[i]); TempPalindrome.Add(Digits[i]);
                    Palindromes.Add(new List<char>()); Palindromes[Palindromes.Count - 1].AddRange(TempPalindrome);
                }
            }
            if (MaxLength >= 3)
            {
                // For the rest copy the previous generation and insert new numbers, even number lengths have symmetry so just copy the middle digit and insert (i.e xyx -> xyyx for four-digit)
                // odd numbers don't, so insert [0,9] in middle of previous generation (i.e. xyyx -> xyzyx for five digit)
                // So three-digit takes the list of two-digit and adds another digit: 11 -> 101,111,121...; 22->202,212,222...
                for (int i = 3; i <= MaxLength; i++)
                {
                    Incomplete.Clear();
                    for (int j = 0; j <= Palindromes.Count - 1; j++)
                    {
                        if (Palindromes[j].Count == i - 1) { Incomplete.Add(new List<char>()); Incomplete[Incomplete.Count - 1].AddRange(Palindromes[j]); }
                    }
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j <= Incomplete.Count - 1; j++)
                        {
                            TempPalindrome.Clear(); TempPalindrome.AddRange(Incomplete[j]); TempPalindrome.Insert(TempPalindrome.Count() / 2, TempPalindrome[TempPalindrome.Count / 2]);
                            Palindromes.Add(new List<char>()); Palindromes[Palindromes.Count - 1].AddRange(TempPalindrome);
                        }
                    }
                    else
                    {
                        for (int j = 0; j <= Incomplete.Count - 1; j++)
                        {
                            for (int k = 0; k <= 9; k++)
                            {
                                TempPalindrome.Clear(); TempPalindrome.AddRange(Incomplete[j]); TempPalindrome.Insert((TempPalindrome.Count() / 2), Digits[k]);
                                Palindromes.Add(new List<char>()); Palindromes[Palindromes.Count - 1].AddRange(TempPalindrome);
                            }
                        }
                    }
                }
            }
            return Palindromes;
        }
        public static List<BigInteger> BigPalindromeList(List<List<char>> CharPalindromes, int Max)
        {
            List<BigInteger> IntPalindromes = new List<BigInteger>();
            string Temp = "";
            foreach (List<char> Palin in CharPalindromes) { Temp = new string(Palin.ToArray()); if (BigInteger.Parse(Temp) <= Max) { IntPalindromes.Add(BigInteger.Parse(Temp)); } }
            return IntPalindromes;
        }
        public static List<int> PalindromeList(List<List<char>> CharPalindromes, int Max)
        {
            List<int> IntPalindromes = new List<int>();
            string Temp = "";
            foreach (List<char> Palin in CharPalindromes) { Temp = new string(Palin.ToArray()); if (int.Parse(Temp) <= Max) { IntPalindromes.Add(int.Parse(Temp)); } }
            return IntPalindromes;
        }
        public static List<int> SieveOfEratosthenes(int n)
        {
            List<int> result = new List<int>() { 2 };
            // Enumerable.Range() arguments are start and count. So Range(3, 100) is 3 - 103, not 3 - 100.
            result.AddRange(Enumerable.Range(3, n - 3).Where(k => k % 2 != 0).ToList());
            List<int> primes = new List<int>() { 2 };
            int count = 1;
            List<int> nonduplicates = new List<int>();
            while (true)
            {
                nonduplicates.Clear();
                List<int> primemultiples = Enumerable.Range(result[count] * 2, result.Last() - 1).Where(k => k % result[count] == 0).ToList();
                nonduplicates.AddRange(primemultiples.Where(x => primes.TrueForAll(k => x % k != 0)).ToList());
                if (nonduplicates.Count() == 0) { break; }
                primes.Add(result[count]);
                result = result.Except(nonduplicates).ToList();
                count++;
            }
            return result;
        }
   }
}