using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b) {
        var minValue = 1;
        var maxValue = 100;
        int pointsA = 0;
        int pointsB = 0;
        var points = new List<int>();
        var lengthArray = a.Count == b.Count ? a.Count : 0;

        for (var i = 0; i < lengthArray; i++)
        {
            if (a[i] >= minValue && a[i] <= maxValue &&
                b[i] >= minValue && b[i] <= maxValue)
            {
                if (a[i] > b[i])
                    pointsA++;
                else if (a[i] < b[i])
                    pointsB++;
            }
        }
        points.Add(pointsA);
        points.Add(pointsB);
        return points;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
