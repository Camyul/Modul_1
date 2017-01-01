function solve(args) {
    'use strict';
    let hexNum = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'],
        result = 0,
        l = args.length,
        str = args[0].toUpperCase();
    for (let i = 0; i < l; i += 1) {
        let digit = str[l - i - 1];
        let convSymbol = hexNum.indexOf(digit);
        result += convSymbol * Math.pow(16, i);
    }
    console.log(result);
}
solve('FE');