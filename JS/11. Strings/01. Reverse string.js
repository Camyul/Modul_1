function solve(args) {
    let reversedStr = '',
        i;
    args = args.join('').trim();
    //reversedStr = args.split('').reverse().join('');
    for (i = args.length - 1; i >= 0; i -= 1) {
        reversedStr += args[i];
    }
    console.log(reversedStr);
}
solve('sample')