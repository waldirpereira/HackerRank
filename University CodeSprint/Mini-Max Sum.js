//https://www.hackerrank.com/contests/university-codesprint/challenges/mini-max-sum
function processData(input) {
  var sum = function(arr) {
    return arr.reduce(function(cur, next) { return cur + next });
  };
  
  var numbers = input
    .split(' ')
    .map(function(n) { return parseInt(n); })
    .sort(function(x, y) { return x - y; });
  
  var min = sum(numbers.slice(0, numbers.length - 1));
  var max = sum(numbers.slice(1, numbers.length));
  
  console.log(min + " " + max);
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
