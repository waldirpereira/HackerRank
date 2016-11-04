//https://www.hackerrank.com/challenges/ctci-making-anagrams
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {
  private static String sortString(String s) {
    char[] chars = s.toCharArray();
    Arrays.sort(chars);
    return new String(chars);
  }
  
  public static int numberNeeded(String first, String second) {
    int numberOfDeletedChars = 0;
    String sortedFirst = sortString(first);
    String sortedSecond = sortString(second);
        
    while (true) {
      if (sortedFirst.length() == 0) {
        numberOfDeletedChars += sortedSecond.length();
        break;
      }
      if (sortedSecond.length() == 0) {
        numberOfDeletedChars += sortedFirst.length();
        break;
      }
      
      char charFirst = sortedFirst.charAt(0);
      char charSecond = sortedSecond.charAt(0);
            
      if (charFirst == charSecond) {
        sortedFirst = sortedFirst.substring(1);
        sortedSecond = sortedSecond.substring(1);
        continue;
      }
      if (charFirst < charSecond) {
        sortedFirst = sortedFirst.substring(1);
        numberOfDeletedChars++;
        continue;
      }
      
      sortedSecond = sortedSecond.substring(1);
      numberOfDeletedChars++;
    }
        
    return numberOfDeletedChars;
  }

  public static void main(String[] args) {
    Scanner in = new Scanner(System.in);
    String first = in.next();
    String second = in.next();
    System.out.println(numberNeeded(first, second));
  }
}
