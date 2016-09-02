using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
      var T = Convert.ToInt32(Console.ReadLine());
      var arrayOfNs = new int[T];
      for (var i = 0; i < T; i++) {
        arrayOfNs[i] = Convert.ToInt32(Console.ReadLine());
      }
      
      for (var i = 0; i < T; i++) {
        var n = arrayOfNs[i];
        Console.WriteLine(isPrime(n) ? "Prime" : "Not prime");
      }
    }
  
  static bool isPrime(int n) {
    if (n == 1) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;
    
    var limit = (int)Math.Floor(Math.Sqrt(n));
    for (var j = 2; j <= limit; j++) {
      if (n % j == 0) return false;
    }
    return true;
  }
}
