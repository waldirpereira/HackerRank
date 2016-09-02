//https://www.hackerrank.com/challenges/lisa-workbook

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
      var nk = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
      var n = nk[0];
      var k = nk[1];
      var problems = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
      
      var book = new int[n][];
      for(var i = 0; i < n; i++) {
        var pages = ((int) (problems[i] / k)) + (problems[i] % k == 0 ? 0 : 1);
        book[i] = new int[pages];
      }
      
      var page = 1;
      var spacials = 0;
      for(var i = 0; i < n; i++) {
        var pageInChapter = 0;
        for (var p = 1; p <= problems[i]; p++) {
          if (book[i][pageInChapter] == k) {
            pageInChapter++;
            page++;
          }
          book[i][pageInChapter]++;
          if (page == p)
            spacials++;
        }
        page++;
      }
      
      Console.Write(spacials);
    }
}
