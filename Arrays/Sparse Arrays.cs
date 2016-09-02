//https://www.hackerrank.com/challenges/sparse-arrays
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      var N = Convert.ToInt32(Console.ReadLine());
      var strings = new string[N];
      for (var i = 0; i < N; i++) {
        strings[i] = Console.ReadLine();
      }
      var Q = Convert.ToInt32(Console.ReadLine());
      var result = new int[Q];
      for (var i = 0; i < Q; i++) {
        var query = Console.ReadLine();
        result[i] = CountOccurrences(strings, query);
      }
      for (var i = 0; i < Q; i++)
        Console.WriteLine(result[i]);
    }
  private static int CountOccurrences(string[] strings, string value){
    var count= 0;
    for (var i = 0; i < strings.Length; i++)
      if (strings[i] == value)
        count++;
    return count;
  }
}
