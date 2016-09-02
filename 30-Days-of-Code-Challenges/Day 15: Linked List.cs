	public static  Node insert(Node head,int data)
	{
      //Complete this method
    
    if (head == null)
      return new Node(data);
    else {
      var node = head;
      while (node.next != null) {
        node = node.next;
      }
      node.next = new Node(data);
      return head;
    }
  }
