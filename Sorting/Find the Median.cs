//https://www.hackerrank.com/challenges/find-the-median
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
      var n = Convert.ToInt32(Console.ReadLine());
      var ar = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
      var list = new List<int>(ar);
      list.Sort();
      Console.Write(list[list.Count/2]);
    }
}
