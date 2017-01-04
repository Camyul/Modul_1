function solve(args) {
    let arr = args[1].split(' '),
        l = arr.length,
        count = 0,
        number = args[2];
    count = appearance(number);

    console.log(count);

    function appearance(num) {
        for (let i = 0; i < l; i += 1) {
            if (arr[i] === num) {
                count += 1;
            }
        }
        return count;
    }
}
solve(['8', '28 6 21 6 -7856 73 73 -56', '73']);