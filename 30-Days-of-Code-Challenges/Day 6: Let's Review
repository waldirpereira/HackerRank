using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
     /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      var T = Convert.ToInt32(Console.ReadLine());
      var result = new List<string>();
      for (var i = 0; i < T; i++){
        var S = Console.ReadLine();
        var even = "";
        var odd = "";
        for (var j = 0; j < S.Length; j++){
          if (j % 2 == 0) {
            even += S[j];
            continue;
          }
          odd += S[j];
        }
        result.Add(string.Format("{0} {1}", even, odd));
      }
      result.ForEach(Console.WriteLine);
    }
}
