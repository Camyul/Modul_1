function solve(args) {
    'use strict';
    let arr = args[1].split(' '),
        l = arr.length,
        count = 0;

    for (let i = 1; i < l - 1; i += 1) {
        if (largestThan(i, arr[i])) {
            count++;
        }
    }
    console.log(count);

    function largestThan(j, element) {
        if ((+element > +arr[j - 1]) && (+element > +arr[j + 1])) {
            return true;
        } else {
            return false;
        }
    }
}
solve(['8', '-26 -25 -28 31 2 27']);