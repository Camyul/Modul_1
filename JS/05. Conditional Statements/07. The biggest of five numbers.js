function solve(args) {
    'use strict';
    let firstNum = args[0] * 1;
    let secondNum = args[1] * 1;
    let threeNum = args[2] * 1;
    let fourNum = args[3] * 1;
    let fiveNum = args[4] * 1;
    let bigestNum;
    if (firstNum > secondNum) {
        bigestNum = firstNum;
    } else {
        bigestNum = secondNum;
    }
    if (bigestNum < threeNum) {
        bigestNum = threeNum;
    }
    if (bigestNum < fourNum) {
        bigestNum = fourNum;
    }
    if (bigestNum < fiveNum) {
        bigestNum = fiveNum;
    }
    console.log(bigestNum);
}
let args = ['2', '3', '7', '-2', '0'];
solve(args);