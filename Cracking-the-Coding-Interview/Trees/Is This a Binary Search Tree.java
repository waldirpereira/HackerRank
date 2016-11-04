//https://www.hackerrank.com/challenges/ctci-is-binary-search-tree
/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

The Node class is defined as follows:
    class Node {
        int data;
        Node left;
        Node right;
     }
*/
  boolean checkBST(Node root) {
    if (root == null)
      return true;
        
    if (root.left != null && getMax(root.left) >= root.data)
      return false;
        
    if (root.right != null && getMin(root.right) <= root.data)
      return false;
        
    if (!checkBST(root.left) || !checkBST(root.right))
      return false;
    
    return true;
  }

  int getMin(Node node) {
    int min = node.data;
    if (node.left != null) {
      int minLeft = getMin(node.left);
      min = min < minLeft ? min : minLeft;
    }
    if (node.right != null) {
      int minRight = getMin(node.right);
      min = min < minRight ? min : minRight;
    }     
    
    return min;
  }

  int getMax(Node node) {
    int max = node.data;
    if (node.left != null) {
      int maxLeft = getMax(node.left);
      max = max > maxLeft ? max : maxLeft;
    }
    if (node.right != null) {
      int maxLeft = getMax(node.right);
      max = max > maxLeft ? max : maxLeft;
    }
    
    return max;
  }

  