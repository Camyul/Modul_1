function solve(args) {
    let hexNum = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'],
        result = 0,
        str = args.toString(),
        l = str.length;
    for (let i = 0; i < l; i += 1) {
        let digit = str[l - i - 1];
        let convSymbol = hexNum.indexOf(digit);
        result += convSymbol * Math.pow(16, i);
    }
    console.log(result);
}
solve('FE');