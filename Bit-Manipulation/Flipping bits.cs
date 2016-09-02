//https://www.hackerrank.com/challenges/flipping-bits
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      var T = Convert.ToInt32(Console.ReadLine());
      var numbers = new long[T];
      for (var i = 0; i < T; i++) {
        numbers[i] = Convert.ToInt64(Console.ReadLine());
      }
      
      for (var i = 0; i < T; i++){
        Console.WriteLine(Bin32ToInt(FlipBin(IntToBin32(numbers[i]))));
      }
    }
  
  private static string IntToBin32(long n) {
    var result = "";
    while (n > 0) {
      var resto = n % 2;
      result = resto.ToString() + result;
      n = n / 2;
    }
    
    for (var i = result.Length; i < 32; i++)
      result = "0" + result;
    return result;
  }
  
  private static string FlipBin(string b) {
    var result = "";
    for (var i = 0; i < b.Length; i++)
      result += b[i] == '1' ? '0' : '1';
    return result;
  }
  
  private static long Bin32ToInt(string b) {
    long n = 0;
    for (var i = 0; i < b.Length; i++){
      if (b[b.Length - i - 1] == '1')
        n += pow(2, i);
    }
    return n;
  }
  
  private static long pow(long n, int exp) {
    if (exp == 0)
      return 1;
    
    var result = n;
    for (var i = 1; i < exp; i++){
      result *= n;
    }
    
    return result;
  }
}
