function solve(args) {
    'use strict';
    let l,
        start = 1,
        end,
        mid,
        element = +args.pop();
    //args.splice(0, 1);
    l = args.length;
    end = l;
    while (true) {
        mid = (((end - start) / 2) | 0) + start;
        if (element > +args[mid]) {
            start = mid;
        } else if (element < +args[mid]) {
            end = mid;
        } else {
            break;
        }
    }
    console.log(mid - 1);
}
solve(['10', '1', '2', '4', '8', '14', '16', '31', '32', '64', '77', '99', '32']);