using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
      var N = Convert.ToInt32(Console.ReadLine());
      var dic = new Dictionary<string, string>();
      var queries = new List<string>();

      for (var i = 0; i < N; i++){
        var pair = Console.ReadLine().Split(' ');
        var name = pair[0];
        var phone = pair[1];
        dic.Add(name, phone);
      }
      
      var query = Console.ReadLine();
      while (!string.IsNullOrEmpty(query)) {
        queries.Add(query);        
        query = Console.ReadLine();
      }
      
      queries.ForEach(q => {
        if (dic.ContainsKey(q)) {
          Console.WriteLine("{0}={1}", q, dic[q]);
          return;
        }
        Console.WriteLine("Not found");
      });
    }
}
