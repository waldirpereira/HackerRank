  private static int[][] values = new int[0][];
  static void levelOrder(Node root){
    storeLevel(root, 0);
      
    var levels = new string[values.Length];
    for (var i = 0; i < values.Length; i++){
      levels[i] = string.Join(" ", values[i]);
    }
    
    Console.Write(string.Join(" ", levels));
  }

  static void storeLevel(Node root, int level) {
    if (values.Length <= level)
      increaseValuesLength();
    
    var newArray = new int[values[level].Length + 1];
    for (var i = 0; i < values[level].Length; i++)
      newArray[i] = values[level][i];
    values[level] = newArray;
    
    var length = values[level].Length;
    values[level][length-1] = root.data;
    
    if (root.left != null)
      storeLevel(root.left, level+1);
    if (root.right != null)
      storeLevel(root.right, level+1);
  }

  static void increaseValuesLength() {
    var newArray = new int[values.Length + 1][];
    for (var i = 0; i < values.Length; i++)
      newArray[i] = values[i];
    newArray[newArray.Length-1] = new int[0];
    values = newArray;
  }
