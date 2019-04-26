using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using TestArea;

using Euler_10;
using Euler_20;
using Euler_30;
using Euler_40;
using Euler_50;
using Euler_60;
using Euler_70;
using Euler_80;
using Euler_90;
using Euler_100;
using Euler_110;
using Euler_120;
using Euler_130;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            string current_directory = Directory.GetCurrentDirectory();
            if (!File.Exists(current_directory + "/Problem_Definitions.txt")) { throw new FileNotFoundException("Problem Definitions file not found."); }
            if (!Directory.Exists(current_directory + "/Data files/")) { throw new DirectoryNotFoundException("Data files directory not found."); }
            List<string> Problems = new List<string>(File.ReadAllLines(current_directory + "/Problem_Definitions.txt"));
            Console.WriteLine("Which problem? Enter a number, or 'List' to view problems, or type 'exit' to close.");
            string choice = Console.ReadLine();
            Switch_Choice(Problems, choice);
        }

        static void Switch_Choice(List<string> Problems, string Choice)
        {
            int ChoiceInt;
            if (int.TryParse(Choice, out ChoiceInt) && ChoiceInt < Problems.Count - 1) { Console.WriteLine(Problems[ChoiceInt - 1]); }
            switch (Choice)
            {
                case "1": Euler_10.Euler_10.Problem_1(); break;
                case "2": Euler_10.Euler_10.Problem_2(); break;
                case "3": Euler_10.Euler_10.Problem_3(); break;
                case "4": Euler_10.Euler_10.Problem_4(); break;
                case "5": Euler_10.Euler_10.Problem_5(); break;
                case "6": Euler_10.Euler_10.Problem_6(); break;
                case "7": Euler_10.Euler_10.Problem_7(); break;
                case "8": Euler_10.Euler_10.Problem_8(); break;
                case "9": Euler_10.Euler_10.Problem_9(); break;
                case "10": Euler_10.Euler_10.Problem_10(); break;
                case "11": Euler_20.Euler_20.Problem_11(); break;
                case "12": Euler_20.Euler_20.Problem_12(); break;
                case "13": Euler_20.Euler_20.Problem_13(); break;
                case "14": Euler_20.Euler_20.Problem_14(); break;
                case "15": Euler_20.Euler_20.Problem_15(); break;
                case "16": Euler_20.Euler_20.Problem_16(); break;
                case "17": Euler_20.Euler_20.Problem_17(); break;
                case "18": Euler_20.Euler_20.Problem_18(); break;
                case "19": Euler_20.Euler_20.Problem_19(); break;
                case "20": Euler_20.Euler_20.Problem_20(); break;
                case "21": Euler_30.Euler_30.Problem_21(); break;
                case "22": Euler_30.Euler_30.Problem_22(); break;
                case "23": Euler_30.Euler_30.Problem_23(); break;
                case "24": Euler_30.Euler_30.Problem_24(); break;
                case "25": Euler_30.Euler_30.Problem_25(); break;
                case "26": Euler_30.Euler_30.Problem_26(); break;
                case "27": Euler_30.Euler_30.Problem_27(); break;
                case "28": Euler_30.Euler_30.Problem_28(); break;
                case "29": Euler_30.Euler_30.Problem_29(); break;
                case "30": Euler_30.Euler_30.Problem_30(); break;
                case "31": Euler_40.Euler_40.Problem_31(); break;
                case "32": Euler_40.Euler_40.Problem_32(); break;
                case "33": Euler_40.Euler_40.Problem_33(); break;
                case "34": Euler_40.Euler_40.Problem_34(); break;
                case "35": Euler_40.Euler_40.Problem_35(); break;
                case "36": Euler_40.Euler_40.Problem_36(); break;
                case "37": Euler_40.Euler_40.Problem_37(); break;
                case "38": Euler_40.Euler_40.Problem_38(); break;
                case "39": Euler_40.Euler_40.Problem_39(); break;
                case "40": Euler_40.Euler_40.Problem_40(); break;
                case "41": Euler_50.Euler_50.Problem_41(); break;
                case "42": Euler_50.Euler_50.Problem_42(); break;
                case "43": Euler_50.Euler_50.Problem_43(); break;
                case "44": Euler_50.Euler_50.Problem_44(); break;
                case "45": Euler_50.Euler_50.Problem_45(); break;
                case "46": Euler_50.Euler_50.Problem_46(); break;
                case "47": Euler_50.Euler_50.Problem_47(); break;
                case "48": Euler_50.Euler_50.Problem_48(); break;
                case "49": Euler_50.Euler_50.Problem_49(); break;
                case "50": Euler_50.Euler_50.Problem_50(); break;
                case "52": Euler_60.Euler_60.Problem_52(); break;
                case "53": Euler_60.Euler_60.Problem_53(); break;
                case "55": Euler_60.Euler_60.Problem_55(); break;
                case "56": Euler_60.Euler_60.Problem_56(); break;
                case "57": Euler_60.Euler_60.Problem_57(); break;
                case "58": Euler_60.Euler_60.Problem_58(); break;
                case "59": Euler_60.Euler_60.Problem_59(); break;
                case "62": Euler_70.Euler_70.Problem_62(); break;
                case "63": Euler_70.Euler_70.Problem_63(); break;
                case "69": Euler_70.Euler_70.Problem_69(); break;
                case "92": Euler_100.Euler_100.Problem_92(); break;
                case "97": Euler_100.Euler_100.Problem_97(); break;
                case "99": Euler_100.Euler_100.Problem_99(); break;
                case "102": Euler_110.Euler_110.Problem_102(); break;
                case "124": Euler_130.Euler_130.Problem_124(); break;
                case "125": Euler_130.Euler_130.Problem_125(); break;
                case "List": List_All(Problems); break;
                case "test": TestArea.TestArea.Test(); break;
                case "exit": Environment.Exit(1); break;
            }
        }
        static void List_All(List<string> Problems)
        {
            int index = 1;
            int max_val = int.Parse(Problems.Last().Split('.')[0]);
            List<int> show_problems_limit = new List<int>();
            for (int i = 0; index + (max_val / 4) <= max_val; i++)
            {
                Console.WriteLine((i + 1) + ". list problems " + index + " - " + (index + (max_val / 4)));
                index += max_val / 4;
                show_problems_limit.Add(i + 1);
            }
            string input = Console.ReadLine();
            while (!int.TryParse(input, out index) || show_problems_limit.Contains(index) == false) { input = Console.ReadLine(); }
            Show_problems(Problems, int.Parse(input) * (max_val / 4));
        }

        static void Show_problems(List<string> Problems, int input)
        {
            List<int> problem_numbers = Problems.Select(r => int.Parse(r.Split('.')[0])).ToList();
            int problems_to_show = problem_numbers.Where(p => (p <= input)).Count();
            for (int i = 0; i <= problems_to_show; i++) { Console.WriteLine(Problems[i]); }
        }
    }
}
