//https://www.hackerrank.com/challenges/circular-array-rotation
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
     /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      var arrFirstLine = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
      var n = arrFirstLine[0];
      var k = arrFirstLine[1];
      var q = arrFirstLine[2];
      
      var arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
      var queries = new int[q];
      for(var i = 0; i < q; i++)
        queries[i] = Convert.ToInt32(Console.ReadLine());
      
      var newArr = new int[n];
      for (var i = 0; i < n; i++) {
        newArr[(i+k)%n] = arr[i];
      }
      
      for(var i = 0; i < q; i++) 
        Console.WriteLine(newArr[queries[i]]);
    }
}
