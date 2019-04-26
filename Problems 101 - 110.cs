using System;

using Functions;

namespace Euler_110 {
    class Euler_110 {
        public static void Problem_102()
            {
                // If (0,0) is in the triangle, the area made by the three triangles using A, B, C, and (0,0) will add to the area of (A, B, C)
                string[] Lines = System.IO.File.ReadAllLines("Problem102_Triangles.txt");
                int result = 0;
                foreach (string line in Lines)
                {
                    string[] Coords = line.Split(',');
                    int[] A = { int.Parse(Coords[0]), int.Parse(Coords[1]) };
                    int[] B = { int.Parse(Coords[2]), int.Parse(Coords[3]) };
                    int[] C = { int.Parse(Coords[4]), int.Parse(Coords[5]) };
                    int[] P = { 0, 0 };
                    if (Functions.Functions.TriangleArea(A, B, C) == Functions.Functions.TriangleArea(A, B, P) + Functions.Functions.TriangleArea(A, P, C) + Functions.Functions.TriangleArea(P, B, C)) { result++; }
                }
                Console.WriteLine(result);
            }
    }
}