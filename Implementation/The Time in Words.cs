//https://www.hackerrank.com/challenges/the-time-in-words
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

  static string NumberToWord(int n){
    var a = new List<string> {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", 
             "twelve", "thirteen", "fourteen", "fiveteen", "sixteen", "seventeen", "eightteen", "nineteen" };
    var b = new List<string> {"ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};

    if (n < 1 || n > 59)
      return null;
    
    if (n < 20)
      return a[n-1];
    
    if (n % 10 == 0)
      return b[(n/10)-1];
    
    var bIndex = ((n-(n%10))/10)-1;
    var aIndex = (n%10)-1;
    return string.Format("{0} {1}", b[bIndex], a[aIndex]);
  }
    static void Main(String[] args) {
        int h = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
      
      
      if (m == 0) {
        Console.WriteLine("{0} o' clock", NumberToWord(h));
        return;
      }
      
      if (m == 15){
        Console.WriteLine("quarter past {0}", NumberToWord(h));
        return;
      }
      
      if (m == 30){
        Console.WriteLine("half past {0}", NumberToWord(h));
        return;
      }
      
      if (m < 30){
        Console.WriteLine("{0} minute{1} past {2}", NumberToWord(m), m > 1 ? "s" : "", NumberToWord(h));
        return;
      }
      
      if (m == 45){
        Console.WriteLine("quarter to {0}", NumberToWord(h+1));
        return;
      }
      
      Console.WriteLine("{0} minute{1} to {2}", NumberToWord(60-m), (60-m) > 1 ? "s" : "", NumberToWord(h+1));
    }
}
