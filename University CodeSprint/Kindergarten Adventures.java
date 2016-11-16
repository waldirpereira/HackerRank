//https://www.hackerrank.com/contests/university-codesprint/challenges/kindergarten-adventures
//score 4.36 of 30
import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
      Scanner scan = new Scanner(System.in);
      int n = scan.nextInt();
      int[] studentsTimes = new int[n];
      for(int i=0; i < n; i++){
        studentsTimes[i] = scan.nextInt();
      }
      scan.close();
      
      int[] studentsCompleted = new int[n];
      int maxCompleted = 0;

      for (int i = 0; i < n; i++) {
        int num = 0;
        for (int j = 0; j < n; j++) {
          int studentTime = studentsTimes[(i + j) % n];
          if (studentTime <= j)
            num++;
        }
        if (num > maxCompleted)
          maxCompleted = num;
        studentsCompleted[i] = num;
        if (num == n) {
          break;
        }
      }

      int result = 0;
      for (result = 0; result < n; result++) {
        if (studentsCompleted[result] == maxCompleted) {
          result++;
          break;
        }
      }
      
      System.out.print(result);
    }
}