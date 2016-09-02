using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

  static int[] ResizeArray(int[] array, int newLength){
    var newArray = new int[newLength];
    for (var i = 0; i < array.Length; i++) {
      newArray[i] = array[i];
    }
    return newArray;
  }
    static void Main(String[] args) {
      int n = Convert.ToInt32(Console.ReadLine());
      var pilha = new int[1];
      var count = 0;
      while (n > 0) {
        var resto = n % 2;
        if (count > 0)
          pilha = ResizeArray(pilha, pilha.Length + 1);
        pilha[pilha.Length - 1] = resto;
        n = (int) (((int)(n - resto)) / 2);
        count++;
      }
      var maxOnes = 0;
      var firstOne = -1;
      for (var i = 0; i < pilha.Length; i++){
        if (pilha[i] == 1) {
          if (firstOne < 0)
            firstOne = i;
          
          if (i == pilha.Length - 1) {
            var qtyOnes = i - firstOne + 1;
            if (qtyOnes > maxOnes)
              maxOnes = qtyOnes;
          }
          
          continue;
        }
        if (firstOne >= 0) {
          var qtyOnes = i - firstOne;
          if (qtyOnes > maxOnes)
            maxOnes = qtyOnes;
        }
        firstOne = -1;
      }
      Console.WriteLine(maxOnes);
    }
}
