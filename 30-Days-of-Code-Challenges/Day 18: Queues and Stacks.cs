class Solution {
    //Write your code here
  
  private char[] stack = new char[0];
  private char[] queue = new char[0];
  
  private char[] addPosition(char[] arr, bool atBeginning = false) {
    var newArr = new char[arr.Length + 1];
    for(var i = 0; i < arr.Length; i++)
      newArr[i + (atBeginning ? 1 : 0)] = arr[i];
    return newArr;
  }
  
  private char[] removePosition(char[] arr) {
    var newArr = new char[arr.Length - 1];
    for(var i = 0; i < newArr.Length; i++)
      newArr[i] = arr[i];
    return newArr;
  }
  
  public void pushCharacter(char ch) {
    stack = addPosition(stack);
    stack[stack.Length-1] = ch;
  }
  
  public void enqueueCharacter(char ch) {
    queue = addPosition(queue, true);
    queue[0] = ch;
  }
  
  public char popCharacter() {
    var result = stack[stack.Length - 1];
    stack = removePosition(stack);
    return result;
  }
  
  public char dequeueCharacter() {
    var result = (char) queue[queue.Length - 1];
    queue = removePosition(queue);
    return result;
  }
