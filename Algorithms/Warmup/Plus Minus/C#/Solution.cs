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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        int positiveTotal = 0;
        int negativeTotal = 0;
        int zeroTotal = 0;

        if (arr.Length > 0 && arr.Length <= 100)
        {
            foreach(var a in arr)
            {
                if (a >= -100 && a <= 100)
                {
                    if (a > 0)
                    {
                        positiveTotal++;
                    }
                    else if (a < 0)
                    {
                        negativeTotal++;
                    }
                    else
                    {
                        zeroTotal++;
                    }
                }
            }
            Console.WriteLine(((double)positiveTotal/arr.Length).ToString("N6"));
            Console.WriteLine(((double)negativeTotal/arr.Length).ToString("N6"));
            Console.WriteLine(((double)zeroTotal/arr.Length).ToString("N6"));
        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
