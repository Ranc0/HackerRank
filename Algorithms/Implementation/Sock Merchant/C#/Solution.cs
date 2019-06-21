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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        int minValue = 1;
        int maxValue = 100;
        var pairsFound = 0;
        var sockColorDictionary = new Dictionary<int, int>();

        if (n >= minValue && n <= maxValue) 
        {
            if (ar.Length >= minValue && ar.Length <= maxValue
                && n >= minValue && n <= maxValue && n == ar.Length) 
            {
                foreach (var a in ar)
                {
                    if (sockColorDictionary.ContainsKey(a))
                    {
                        pairsFound++;
                        sockColorDictionary.Remove(a);
                    }
                    else
                        sockColorDictionary.Add(a, 1);
                }
                return pairsFound;
            }
        }
        return pairsFound;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
