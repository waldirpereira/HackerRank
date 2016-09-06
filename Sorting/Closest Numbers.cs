//https://www.hackerrank.com/challenges/closest-numbers
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
  internal class Pair {
    public long Prev {get;set;}
    public long Next {get;set;}
    public Pair (long prev, long next) {
      Prev = prev;
      Next = next;
    }
  }
  internal class Group {
    public long Diff {get;set;}
    private ICollection<Pair> _pairs = new List<Pair>();
    public ICollection<Pair> Pairs {
      get { return _pairs; }
      set { _pairs = value; }
    }
    public Group(long diff) {
      Diff = diff;
    }
  }
    static void Main(String[] args) {
      var n = Convert.ToInt32(Console.ReadLine());
      var numbers = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt64);
      var orderedNumbers = new List<long>(numbers);
      orderedNumbers.Sort();
      
      var groups = new List<Group>();
      var minDiff = long.MaxValue;
      for(var i = 0; i < orderedNumbers.Count - 1; i++) {
        var diff = Math.Abs(orderedNumbers[i+1] - orderedNumbers[i]);
        if (diff < minDiff) {
          minDiff = diff;
        }
        var pair = new Pair(orderedNumbers[i], orderedNumbers[i+1]);
        var thisGroup = groups.FirstOrDefault(g => g.Diff == diff);
        if (thisGroup == null) {
          thisGroup = new Group(diff);
          groups.Add(thisGroup);
        }
        thisGroup.Pairs.Add(pair);
      }
      
      var minDiffGroup = groups.FirstOrDefault(g => g.Diff == minDiff);
      var result = "";
      foreach(var pair in minDiffGroup.Pairs) {
        result += string.IsNullOrEmpty(result) ? "" : " ";
        result += pair.Prev + " " + pair.Next;
      }
      Console.WriteLine(result);
    }
}
