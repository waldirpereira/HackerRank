//https://www.hackerrank.com/contests/university-codesprint/challenges/kindergarten-adventures
//score 3.27 of 30
function processData(input) {
  var lines = input.split('\n');
  var n = parseInt(lines[0]);
  var studentsTimes = lines[1].split(' ').map(Number);
  
  var studentsCompleted = [];
  var maxCompleted = 0;
  
  for (var i = 0; i < n; i++) {
    var num = 0;
    for (var j = 0; j < n; j++) {
      var studentTime = studentsTimes[(i + j) % n];
      if (studentTime <= j)
        num++;
    }
    if (num > maxCompleted)
      maxCompleted = num;
    studentsCompleted.push(num);
  }
  
  console.log(studentsCompleted.indexOf(maxCompleted) + 1);
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
