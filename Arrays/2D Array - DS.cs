//https://www.hackerrank.com/challenges/2d-array
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
      var maxSum = int.MinValue;
      for (var row = 0; row < 4; row++) {
        for (var column = 0; column < 4; column++) {
          var hourglassSum = arr[row][column] + arr[row][column+1] + arr[row][column+2]
                                           + arr[row+1][column+1]
                           + arr[row+2][column] + arr[row+2][column+1] + arr[row+2][column+2];
          
          if (hourglassSum > maxSum)
            maxSum = hourglassSum;
        }
      }
      
      Console.WriteLine(maxSum);
    }
}
