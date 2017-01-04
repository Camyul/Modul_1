function solve(args) {
    let arr = args[1].split(' ').map(Number),
        l = arr.length,
        maxElement = [],
        max;

    for (let i = l - 1; i >= 0; i -= 1) { //Sort Array Asccending
        maxElement = findMaxElement(i);
        arr.splice(maxElement.index, 1);
        arr.splice(i, 0, maxElement.data);
    }

    /*for (let i = l - 2; i >= 0; i -= 1) {
        maxElement = findMaxElement(i);
        arr.splice(maxElement.index, 1);
        arr.push(maxElement.data);
    }*/


    console.log(maxElement.data);
    console.log(maxElement.index);

    function findMaxElement(endInd) {
        maxElement.data = Number.MIN_SAFE_INTEGER;
        for (let i = 0; i <= endInd; i += 1) {
            if (maxElement.data < arr[i]) {
                maxElement.data = arr[i];
                maxElement.index = i;
            }
        }
        return maxElement;
    }
}
solve(['6', '-26 -25 -28 31 27 2']);