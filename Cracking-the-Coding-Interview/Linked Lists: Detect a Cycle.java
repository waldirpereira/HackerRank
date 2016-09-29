//https://www.hackerrank.com/challenges/ctci-linked-list-cycle
/*
Detect a cycle in a linked list. Note that the head pointer may be 'null' if the list is empty.

A Node is defined as: 
    class Node {
        int data;
        Node next;
    }
*/

boolean hasCycle(Node head) {
  if (head == null) {
    return false;
  }
  
  int nodesLength = 0;
  Node[] visitedNodes = new Node[nodesLength];
  Node node = head;
  boolean result = false;
  do {
    int indexOf = java.util.Arrays.asList(visitedNodes).indexOf(node);
    if (indexOf >= 0) {
      return true;
    }
    visitedNodes = Arrays.copyOf(visitedNodes, visitedNodes.length + 1);
    visitedNodes[visitedNodes.length - 1] = node;
    node = node.next;
  } while (node.next != null);
  
  return false;
}
