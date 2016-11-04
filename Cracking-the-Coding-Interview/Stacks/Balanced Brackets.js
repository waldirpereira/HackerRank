//https://www.hackerrank.com/challenges/ctci-balanced-brackets
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
  var t = parseInt(readLine());
  var strings = [];
  for(var a0 = 0; a0 < t; a0++){
    strings[a0] = readLine();
  }
  
  for(var i = 0; i < t; i++){
    var s = strings[i];
    console.log(isBalanced(s) ? "YES" : "NO");
  }
}

function isBalanced(s) {
  var start = ["{", "(", "["];
  var finish = ["}", ")", "]"];
  
  var opened = [];  
  
  for (var i = 0; i < s.length; i++) {
    var c = s[i];
    
    if (start.indexOf(c) >= 0) {
      opened.push(c);
      continue;
    }
    
    var indexOfFinished = finish.indexOf(c);
    if (indexOfFinished < 0) {
      continue;
    }
    
    if (opened.length === 0) {
      return false;
    }
    
    var indexOfLastOpened = start.indexOf(opened[opened.length - 1]);
    if (indexOfFinished === indexOfLastOpened) {
      opened.length--;
      continue;
    }
    
    return false;
  }
  return opened.length === 0;
}
