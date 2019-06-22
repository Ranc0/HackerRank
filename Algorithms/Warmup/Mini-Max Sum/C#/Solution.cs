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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        var arrLong = arr.Select(item => (long)item).ToArray();
        Array.Sort(arrLong);

        var minArray = arrLong.Take(arr.Count() - 1).ToArray();
        var maxArray = arrLong.Skip(1).ToArray();
        long minTotal = minArray.Sum();
        long maxTotal = maxArray.Sum();

        Console.WriteLine(minTotal + " " + maxTotal);
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
