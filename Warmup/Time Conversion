//https://www.hackerrank.com/challenges/time-conversion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
      var ampm = time.Substring(8);
      var hour = Convert.ToInt32(time.Substring(0, 2));
      var rest = time.Substring(2, 6);
      var newHour = ampm == "PM" ? (hour < 12 ? hour+12 : hour) : (hour < 12 ? hour : 0);
      Console.Write("{0:00}{1}", newHour, rest);
    }
}
