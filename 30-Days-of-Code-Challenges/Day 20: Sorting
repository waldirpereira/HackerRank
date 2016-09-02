using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
      int n = Convert.ToInt32(Console.ReadLine());
      string[] a_temp = Console.ReadLine().Split(' ');
      int[] a = Array.ConvertAll(a_temp,Int32.Parse);
      
      var numberOfSwaps = bubble(a);
      
      Console.WriteLine("Array is sorted in {0} swaps.", numberOfSwaps);
      Console.WriteLine("First Element: {0}", a[0]);
      Console.WriteLine("Last Element: {0}", a[n-1]);
    }
  
  private static int bubble(int[] a) {
    var n = a.Length;
    var totalOfSwaps = 0;
    for (int i = 0; i < n; i++) {
      int numberOfSwaps = 0;

      for (int j = 0; j < n - 1; j++) {
        if (a[j] > a[j + 1]) {
          var temp = a[j + 1];
          a[j + 1] = a[j];
          a[j] = temp;
          numberOfSwaps++;
        }
      }

      totalOfSwaps += numberOfSwaps;
      if (numberOfSwaps == 0) {
        break;
      }
    }
    return totalOfSwaps;
  }
}
