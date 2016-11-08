//https://www.hackerrank.com/challenges/ctci-find-the-running-median?h_r=next-challenge&h_v=zen
process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();    
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

/////////////// ignore above this line ////////////////////

function main() {
  var calcMedian = function(arr) {
    var len = arr.length;
    if (len % 2 === 0)
      return (arr[len / 2] + arr[(len / 2) - 1]) / 2;
    return arr[(len - 1) / 2];
  };
  //find the index for insert by binary search
  var findInsertIndex = function(arr, a) {
    var left = 0;
    var right = arr.length - 1;
    if (left === right)
      return arr[left] < a ? 1 : 0;
    
    var index = parseInt((right - left) / 2) + left;
    while (left <= right) {
      if (arr[index] === a)
        return index;
      if (arr[index] > a) {
        right = index - 1;
        index = parseInt((right - left) / 2) + left;
        continue;
      }
      left = index + 1;
      index = parseInt((right - left) / 2) + left;
    }
    return index;
  };
  var add = function(arr, a) {
    var index = findInsertIndex(arr, a);
    arr.splice(index, 0, a);
  };
  var arr = [];
  var arrResult = [];
  var n = parseInt(readLine());
  for (var i = 0; i < n; i++) {
    var a = parseInt(readLine().split(' '));
    add(arr, a);
    console.log(calcMedian(arr).toFixed(1));
  }
}
