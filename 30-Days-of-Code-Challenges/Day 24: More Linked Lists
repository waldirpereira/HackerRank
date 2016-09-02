  public static Node removeDuplicates(Node head){
    var node = head;
    
    while (node.next != null) {
      node.next = findNext(node);
      if (node.next != null)
        node = node.next;
    }
    
    return head;
  }

  private static Node findNext(Node node) {
    var data = node.data;
    while (node.next != null) {
      if (node.next.data == data) {
        node = node.next;
        continue;
      }
      break;
    }
    
    return node.next;
  }
