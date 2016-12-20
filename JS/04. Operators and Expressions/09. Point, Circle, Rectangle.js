function solve(args) {
    'use strict';
    var x = Number(args[0]);
    var y = Number(args[1]);
    var radius = Math.sqrt(((x - 1) * (x - 1) + ((y - 1) * (y - 1))));
    var result;
    if (radius <= 1.5) {
        result = 'inside circle ';
        if ((x >= -1) && (x <= 5) && ((y >= -1) && (y <= 1))) {
            result += 'inside rectangle';
        } else {
            result += 'outside rectangle';
        }
    } else {
        result = 'outside circle ';
        if ((x >= -1) && (x <= 5) && ((y >= -1) && (y <= 1))) {
            result += 'inside rectangle';
        } else {
            result += 'outside rectangle';
        }
    }
    return result;
}