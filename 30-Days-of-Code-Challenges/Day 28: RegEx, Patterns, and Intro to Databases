using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
class Solution {
  
  internal class User {
    public string FirstName {get;set;}
    public string EmailID {get;set;}
    public User(string firstName, string emailID) {
      FirstName = firstName;
      EmailID = emailID;
    }
  }
  
  static List<User> SortByName(List<User> users) {
    for (var i = 0; i < users.Count - 1; i++) {
      for (var j = i + 1; j < users.Count; j++) {
        if (string.Compare(users[i].FirstName, users[j].FirstName) > 0) {
          var temp = users[i];
          users[i] = users[j];
          users[j] = temp;
        }
      }
    }
    
    return users;
  }

    static void Main(String[] args) {
      int N = Convert.ToInt32(Console.ReadLine());
      var db = new List<User>();
      for(int a0 = 0; a0 < N; a0++){
          string[] tokens_firstName = Console.ReadLine().Split(' ');
          string firstName = tokens_firstName[0];
          string emailID = tokens_firstName[1];
        db.Add(new User(firstName, emailID));
      }
      
      var gmailPattern = @"[a-z\.]+(@gmail\.com)$";
      Regex gmailRegex = new Regex(gmailPattern);
      var gmailUsers = db.Where(u => gmailRegex.Matches(u.EmailID).Count > 0).ToList();
      
      var sortedGmailUsers = SortByName(gmailUsers);
      
      foreach(var user in sortedGmailUsers) {
        Console.WriteLine(user.FirstName);
      }
    }
}
