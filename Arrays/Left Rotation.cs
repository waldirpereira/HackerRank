//https://www.hackerrank.com/challenges/array-left-rotation
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      
      var arrParameters = Console.ReadLine().Split(' ');
      var n = Convert.ToInt32(arrParameters[0]);
      var d = Convert.ToInt32(arrParameters[1]);
      var array = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
      var result = new int[n];
      
      for (var i = 0; i < n; i++)
        result[i] = array[(i+d)%n];
      
      for (var i = 0; i < n; i++)
        Console.Write("{0}{1}", result[i], i < n - 1 ? " " : "");
    }
}
