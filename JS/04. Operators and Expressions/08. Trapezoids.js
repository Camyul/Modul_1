function solve(args) {
    'use strict';
    var a = Number(args[0]);
    var b = Number(args[1]);
    var h = Number(args[2]);
    var area = ((a + b) / 2) * h;
    return area.toFixed(7);
}