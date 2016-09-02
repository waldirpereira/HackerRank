using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      
      double mealCost;
      int tip;
      int tax;
      
      mealCost = Convert.ToDouble(Console.ReadLine());
      tip = Convert.ToInt32(Console.ReadLine());
      tax = Convert.ToInt32(Console.ReadLine());
      
      int totalCost = Convert.ToInt32(Math.Round(mealCost * (1 + ((tip+tax)/100.0))));
      Console.Write(string.Format("The total meal cost is {0} dollars.", totalCost));
    }
}
