using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
      
        if (N % 2 == 1) {
           Console.Write("Weird");
          return;
        }
      
        if (N > 20 || N <= 5) {
           Console.Write("Not Weird");
          return;
        }
      
      Console.Write("Weird");
    }
}
