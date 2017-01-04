function solve(args) {
    let arr = args[1].split(' ').map(Number),
        l = arr.length,
        maxElement = [],
        max;

    sortArrAscending();

    console.log(arr.join(' '));

    sortArrDescending();
    console.log(arr.join(' '));


    function sortArrDescending() {
        for (let i = 0; i < l; i += 1) { //Sort Array Descending
            maxElement = findMaxElement(i, l - 1);
            arr.splice(maxElement.index, 1);
            arr.splice(i, 0, maxElement.data);
        }
    }

    function sortArrAscending() {
        for (let i = l - 1; i >= 0; i -= 1) { //Sort Array Ascending
            maxElement = findMaxElement(0, i);
            arr.splice(maxElement.index, 1);
            arr.splice(i, 0, maxElement.data);
        }
    }

    function findMaxElement(startInd, endInd) {
        maxElement.data = Number.MIN_SAFE_INTEGER;
        for (let i = startInd; i <= endInd; i += 1) {
            if (maxElement.data < arr[i]) {
                maxElement.data = arr[i];
                maxElement.index = i;
            }
        }
        return maxElement;
    }
}
solve(['6', '-26 -25 -28 31 27 2']);