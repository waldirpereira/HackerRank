using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      var N = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(factorial(N));
    }
  
  static int factorial(int N){
    if (N <= 1)
      return 1;
    
    return N * factorial(N - 1);
  }
}
