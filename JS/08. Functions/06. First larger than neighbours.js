function solve(args) {
    'use strict';
    let arr = args[1].split(' '),
        l = arr.length,
        i;

    for (i = 1; i < l - 1; i += 1) {
        if (largestThan(i, arr[i])) {
            break;
        }
    }
    console.log(i);

    function largestThan(j, element) {
        if ((+element > +arr[j - 1]) && (+element > +arr[j + 1])) {
            return true;
        } else {
            return false;
        }
    }
}
solve(['6', '-26 -25 -28 31 2 27']);