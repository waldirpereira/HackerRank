//https://www.hackerrank.com/challenges/equal-stacks
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n1 = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(tokens_n1[0]);
        int n2 = Convert.ToInt32(tokens_n1[1]);
        int n3 = Convert.ToInt32(tokens_n1[2]);
        string[] h1_temp = Console.ReadLine().Split(' ');
        int[] h1 = Array.ConvertAll(h1_temp,Int32.Parse);
        string[] h2_temp = Console.ReadLine().Split(' ');
        int[] h2 = Array.ConvertAll(h2_temp,Int32.Parse);
        string[] h3_temp = Console.ReadLine().Split(' ');
        int[] h3 = Array.ConvertAll(h3_temp,Int32.Parse);
      
      var index1 = 0;
      var index2 = 0;
      var index3 = 0;
      
      var heigth1 = Heigth(h1);
      var heigth2 = Heigth(h2);
      var heigth3 = Heigth(h3);
      
      while (heigth1 != heigth2 || heigth2 != heigth3 || n1 == 0 || n2 == 0 || n3 == 0) {
        var maxH = MaxH(heigth1, heigth2, heigth3);
        if (heigth1 == maxH) {
          heigth1 -= h1[index1++];
          continue;
        }  
        if (heigth2 == maxH) {
          heigth2 -= h2[index2++];
          continue;
        }  
        if (heigth3 == maxH) {
          heigth3 -= h3[index3++];
          continue;
        }        
      }
      
      Console.WriteLine(heigth1);
    }
  
  private static int MaxH(int n1, int n2, int n3) {
    return (n1 > n2 
            ? (n1 > n3 ? n1 : (n2 > n3 ? n2 : n3))
            : (n2 > n3 ? n2 : n3));
  }
  
  private static int Heigth(int[] h) {
    var result = 0;
    for (var i = 0; i < h.Length; i++)
      result += h[i];
    return result;
  }
}
