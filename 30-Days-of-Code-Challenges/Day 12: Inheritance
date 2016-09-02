class Student : Person{
    private int[] testScores;  
  public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id) {
    testScores = scores;
  }
  public char calculate() {
    var total = 0;
    for (var i = 0; i < testScores.Length; i++)
      total += testScores[i];
    
    var avg = (float)total / testScores.Length;
    
    if (avg >= 90.0)
      return 'O';
    if (avg >= 80.0)
      return 'E';
    if (avg >= 70.0)
      return 'A';
    if (avg >= 55.0)
      return 'P';
    if (avg >= 40.0)
      return 'D';
    return 'T';    
  }
}
