function solve(args){
'use strict';
var a = args[0] * 1;
var b = args[1] * 1;
var c = args[2] * 1;
if (a > b) {
    if (a > c) {
        console.log(a);
    } else {
        console.log(c);
    }
} else {
    if (b > c) {
        console.log(b);
    } else {
        console.log(c);
    }
}
}