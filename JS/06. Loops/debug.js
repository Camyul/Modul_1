function solve(args) {
    'use strict';
    let a = args[0] * 1,
        b = args[1] * 1,
        c = args[2] * 1,
        min = Number.MAX_VALUE,
        max = Number.MIN_VALUE,
        sum = 0,
        avg = 0,
        i = 0;
    if (a < Math.min(b, c)) {
        min = a;
    } else {
        if (b < c) {
            min = b;
        } else {
            min = c;
        }
    }
    for (i = 0; i < 3; i++) {
        if (max < args[i] * 1) {
            max = args[i] * 1;
        }
    }
    i = 0;
    while (i < 3) {
        sum += args[i] * 1;
        i++;
    }
    avg = sum / 3;
    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}
solve(['2', '-1', '4']);