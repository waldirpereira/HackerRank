static int getHeight(Node root){
      //Write your code here
    var hLeft = root.left != null ? getHeight(root.left) : -1;
    var hRight = root.right != null ? getHeight(root.right) : -1;
      var h = 1 + Math.Max(hLeft, hRight);
    return h;
    }
  
