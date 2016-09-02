	// Add your code here
  public Difference (int[] elems) {
    elements = elems;
  }

  public void computeDifference() {
    var maxDiff = 0;
    for (var i = 0; i < elements.Length; i++) {
      for (var j = i; j < elements.Length; j++) {
        var diff = (elements[i] - elements[j]);
        if (diff < 0) diff *= -1;
        if (diff > maxDiff) maxDiff = diff;
      }
    }
    
    maximumDifference = maxDiff;
  }
