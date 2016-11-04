//https://www.hackerrank.com/challenges/ctci-ransom-note
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
  var m_temp = readLine().split(' ');
  var m = parseInt(m_temp[0]);
  var n = parseInt(m_temp[1]);
  magazine = readLine().split(' ');
  ransom = readLine().split(' ');

  magazine = magazine.sort();
  ransom = ransom.sort();
  
  if (n > m) {
    console.log("No");
    return;
  }
  
  var result = true;
  var indexOf = -1;
  for (var i = 0; i < n; i++) {
    indexOf = magazine.indexOf(ransom[i], indexOf + 1);
    if (indexOf < 0) {
      result = false;
      break;
    }
  }  
  
  console.log(result ? "Yes" : "No");
}
