using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

  internal class Case {
    public int N {get;set;}
    public int K {get;set;}
    public Case(int n, int k) {
      N = n;
      K = k;
    }
  }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
      var cases = new List<Case>();
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int _n = Convert.ToInt32(tokens_n[0]);
            int _k = Convert.ToInt32(tokens_n[1]);
          cases.Add(new Case(_n, _k));
        }
      
      foreach(var thisCase in cases) {
        var n = thisCase.N;
        var k = thisCase.K;
        var max = 0;
        for (var a = 1; a < n; a++) {
          for (var b = a + 1; b <= n; b++) {
            var aAndB = a & b;
            if (aAndB > max && aAndB < k)
              max = aAndB;
          }
        }
        Console.WriteLine(max);
      }      
    }
}
