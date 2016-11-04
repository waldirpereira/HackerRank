//https://www.hackerrank.com/challenges/ctci-contacts
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
  var contacts = {};
  
  var add = function(name) {
    var obj = contacts;
    for (var i = 0; i < name.length; i++) {
      obj[name[i]] = obj[name[i]] || {count: 0};
      obj[name[i]].count++;
      obj = obj[name[i]];
    }
  };
  var find = function(str) {
    var count = 0;
    var obj = contacts;
    for (var i = 0; i < str.length; i++) {
      if (!obj[str[i]]) {
        obj = {count: 0};
        break;
      }
      obj = obj[str[i]];
    }
    return obj.count;
  }

  var n = parseInt(readLine());
  for(var a0 = 0; a0 < n; a0++){
    var op_temp = readLine().split(' ');
    var op = op_temp[0];
    var contact = op_temp[1];
    
    switch (op) {
      case 'add':
        add(contact);
        break;
      case 'find':
        console.log(find(contact));
        break;
      default:
    }
  }
}

