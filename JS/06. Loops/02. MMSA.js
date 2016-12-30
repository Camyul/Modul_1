function solve(args) {
    'use strict';
    let min = 10000,
        max = -10000,
        sum = 0,
        avg = 0;
    for (let i = 0; i < args.length; i += 1) {
        if (max < +args[i]) {
            max = +args[i];
        }
        if (min > +args[i]) {
            min = +args[i];
        }
        sum += +args[i];
    }

    avg = sum / args.length;
    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}
args = ['2', '-1', '4'];
solve(args);