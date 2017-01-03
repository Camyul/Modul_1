function solve(args) {
    'use strict';
    let l,
        i,
        freqNum = '',
        freqCount = 0;
    args.shift();
    l = args.length;
    for (i = 0; i < l; i += 1) {
        let num = args[i];
        let count = 1;
        for (let j = i + 1; j < l; j += 1) {
            if (num === args[j]) {
                count++;
            }
        }
        if (freqCount < count) {
            freqCount = count;
            freqNum = num;
        }
    }
    console.log(freqNum + ' (' + freqCount + ' times)');
}
solve(['13', '2', '1', '1', '4', '2', '3', '4', '4', '1', '4', '4', '9', '3']);