function solve(args) {
    let count = 1,
        maxCount = 0,
        i,
        l;
    args.splice(0, 1);
    l = args.length;
    for (i = 0; i < l - 1; i += 1) {
        if (+args[i] < +args[i + 1]) {
            count += 1;
            if (maxCount < count) {
                maxCount = count;
            }
        } else {
            count = 1;
        }
    }
    console.log(maxCount);
}
solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);