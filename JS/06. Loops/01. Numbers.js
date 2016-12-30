function solve(args) {
    'use strict';
    let n = args[0] * 1,
        result = '';
    for (let i = 1; i <= n; i += 1) {
        result += i + ' ';

    }
    console.log(result);
}
solve('4')