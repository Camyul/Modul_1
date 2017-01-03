function solve(args) {
    'use strict';
    let l,
        start = 0,
        end,
        mid,
        element = +args.pop();
    args.splice(0, 1);
    l = args.length;
    end = l;
    while (true) {
        mid = (((end - start) / 2) | 0) + start;
        if ((+args[end] > element) && (+args[end - 1] < element)) {
            mid = -1;
            break;
        } else if (element > +args[mid]) {
            start = mid;
        } else if (element < +args[mid]) {
            end = mid;
        } else {
            break;
        }
    }
    console.log(mid);
}
solve(['10', '1', '2', '4', '8', '14', '16', '31', '32', '64', '77', '99', '32']);