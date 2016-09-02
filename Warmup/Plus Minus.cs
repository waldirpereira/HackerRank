//https://www.hackerrank.com/challenges/plus-minus
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
      
      var pos = 0;
      var neg = 0;
      var zero = 0;
      for (var i = 0; i < n; i++){
        if (arr[i] == 0) {
          zero++;
          continue;
        }
        if (arr[i] > 0) {
          pos++;
          continue;
        }
        neg++;
      }
      
      var total = pos + neg + zero;
      Console.WriteLine("{0:0.000000}", (decimal)pos/total);
      Console.WriteLine("{0:0.000000}", (decimal)neg/total);
      Console.WriteLine("{0:0.000000}", (decimal)zero/total);
    }
}
