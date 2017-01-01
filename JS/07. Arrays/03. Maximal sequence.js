function solve(args) {
    let count = 1,
        maxCount = 0,
        i,
        l;
    args.splice(0, 1);
    l = args.length;
    for (i = 0; i < l - 1; i += 1) {
        if (args[i] === args[i + 1]) {
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
solve(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);