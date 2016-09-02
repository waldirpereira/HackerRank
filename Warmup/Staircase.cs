//https://www.hackerrank.com/challenges/staircase
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
      
      for (var i = 0; i < n; i++) {
        for (var s = 0; s < n; s++) {
          Console.Write((s < n - i - 1) ? " " : "#");
        }
        Console.WriteLine("");
      }
    }
}
