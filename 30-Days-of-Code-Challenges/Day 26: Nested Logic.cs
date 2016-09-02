using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
      var actuallyArray = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
      var expectedArray = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
      var actuallyDate = new DateTime(actuallyArray[2], actuallyArray[1], actuallyArray[0]);
      var expectedDate = new DateTime(expectedArray[2], expectedArray[1], expectedArray[0]);
      
      Console.WriteLine(calculateFine(actuallyDate, expectedDate));
    }
  
  static int calculateFine(DateTime actuallyDate, DateTime expectedDate) {
    if (actuallyDate <= expectedDate)
      return 0;
    
    if (actuallyDate.Year > expectedDate.Year)
      return 10000;
    
    if (actuallyDate.Month > expectedDate.Month)
      return 500 * (actuallyDate.Month - expectedDate.Month);
    
    return 15 * (actuallyDate.Day - expectedDate.Day);
  }
}
