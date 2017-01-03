function solve(args) {
    let numbers = args[0].split(' '),
        numOne = +numbers[0],
        numTwo = +numbers[1],
        numThree = +numbers[2];
    if (numThree > getMax(numOne, numTwo)) {
        return numThree;
    } else {
        return getMax(numOne, numTwo);
    }
}

function getMax(first, second) {
    if (first > second) {
        return first;
    } else if (second > first) {
        return second;
    } else {
        return -1;
    }
}
//console.log(solve(['8 3 6']));
console.log(solve(['7 19 19']));