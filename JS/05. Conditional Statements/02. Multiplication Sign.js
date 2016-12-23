function solve(args) {
    'use strict';
    var a = Number(args[0]);
    var b = Number(args[1]);
    var c = Number(args[2]);
    var result;
    if (a === 0 || b === 0 || c === 0) {
        result = 0;
    } else {
        var count = 0;
        for (var i = 0; i < args.length; i += 1) {
            if (Number(args[i]) < 0) {
                count++;
            }
        }
        count % 2 == 0 ? result = '+' : result = '-';
    }
    return result;
}