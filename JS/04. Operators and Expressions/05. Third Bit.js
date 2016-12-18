function solve(args) {
    var number = args[0];
    var mask = 1 << 3;
    var nAndMask = number & mask;
    return nAndMask >> 3;
}