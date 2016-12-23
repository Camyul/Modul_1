function solve(args){
    'use strict';
  var firstNum = Number(args[0]);
  var secondNum = Number(args[1]);
    if (firstNum > secondNum) {
  var temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
}
console.log(firstNum + ' ' + secondNum);
}
