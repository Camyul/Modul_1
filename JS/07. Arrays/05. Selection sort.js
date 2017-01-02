function solve(args) {
    let min,
        l,
        i,
        j,
        temp,
        index;
    args.splice(0, 1);
    l = args.length;
    for (i = 0; i < l; i += 1) {
        min = Number.MAX_VALUE;
        for (j = 0 + i; j < l; j += 1) {
            if (min > +args[j]) {
                min = +args[j];
                index = j;
            }
        }
        if (args[i] > min) {
            temp = +args[i];
            args[i] = min;
            args[index] = temp;
        }
    }
    for (i = 0; i < l; i += 1) {
        console.log(args[i]);
    }
}
solve(['8', '7', '3', '2', '3', '4', '2', '2', '-4']);