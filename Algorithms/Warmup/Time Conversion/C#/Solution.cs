using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        var am_pm = s.Substring(s.Length - 2);
        var hour = s.Substring(0, s.Length - 8);
        var minute = s.Substring(3, s.Length - 8);
        var second = s.Substring(6, s.Length - 8);
        var numHour = 0;

        if (am_pm == "PM" && Convert.ToInt32(hour) != 12)
        {
            numHour = Convert.ToInt32(hour) + 12;
        } 
        else if (am_pm == "AM" && Convert.ToInt32(hour) == 12)
        {
            numHour = 0;
        }
        else
        {
            numHour = Convert.ToInt32(hour);
        }

        return numHour.ToString().PadLeft(2, '0') + ":" + minute + ":" + second;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
