//https://www.hackerrank.com/challenges/dynamic-array
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
     /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      
      var arrFirstLine = Console.ReadLine().Split(' ');
      var N = Convert.ToInt32(arrFirstLine[0]);
      var Q = Convert.ToInt32(arrFirstLine[1]);
      
      var seqList = new long[N][];
      for (var i = 0; i < N; i++)
        seqList[i] = new long[0];
      long lastAns = 0;
      
      var queries = new string[Q];
      for (var i = 0; i < Q; i++) {
        queries[i] = Console.ReadLine();
      }
      
      for (var i = 0; i < Q; i++) {
        var queryValues = queries[i].Split(' ');
        var queryType = Convert.ToInt32(queryValues[0]);
        var x = Convert.ToInt64(queryValues[1]);
        var y = Convert.ToInt64(queryValues[2]);
        
        var index = (long) ((x^lastAns)%N);
                
        if (queryType == 1) {
          seqList[index] = Push(seqList[index], y);
          
          continue;
        }
        
        var seq = seqList[index];
        var size = seq.Length;
        var elementValue = seq[(long)y%size];
        lastAns = elementValue;
        Console.WriteLine(lastAns);
      }
    }
  
  private static long[] Push(long[] array, long value) {
    var newLength = array.Length + 1;
    var newArray = new long[newLength];
    for (var i = 0; i < array.Length; i++)
      newArray[i] = array[i];
    newArray[newLength-1] = value;
    return newArray;
  }
}
