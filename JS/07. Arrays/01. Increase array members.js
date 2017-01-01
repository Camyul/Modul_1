function solve(args) {
    'use strict';
    let n = +args[0],
        i,
        arr = [];

    for (i = 0; i < n; i += 1) {
        arr[i] = i * 5;
    }
    for (i = 0; i < arr.length; i += 1) {
        console.log(arr[i]);
    }
}
solve('5');