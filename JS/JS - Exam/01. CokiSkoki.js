function solve(args) {
    let numbers = args.map(Number),
        result = 1,
        i,
        len;
    for (i = 1, len = numbers.length; i < len; i += 1) {
        if ((numbers[i] % 2) > 0) {
            result *= numbers[i];

        } else {
            result = result + numbers[i];
            i += 1;
        }
        if (result > 1024) {
            result = result % 1024;
        }
    }
    console.log(result);
}
solve([
    '10',
    '1',
    '2',
    '3',
    '4',
    '5',
    '6',
    '7',
    '8',
    '9',
    '0'
]);
solve([
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9',
    '9'
]);