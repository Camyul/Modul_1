function solve(args) { //non Sieve of Eratosthenes - 100/100
    'use strict';
    let n = +args[0],
        isPrime;
    for (let i = n; i >= 2; i -= 1) {
        isPrime = true;
        for (let j = 2; j < Math.sqrt(n); j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            console.log(i);
            break;
        }
    }
}
solve(['26']);
//with Sieve of Eratosthenes - 50/100 - Time Limmit
/*function solve(args) {
    'use strict';
    let n = +args[0],
        arr = [],
        step = 2,
        j = 0;
    for (let i = 2; i <= n; i += 1) {
        arr[i - 2] = i;
    }
    while (j <= n) {
        for (j = 2 * step; j <= n; j += step) {
            if (arr[j - 2] > 0) {
                arr[j - 2] = 0;
            }
        }
        j = step + 1;
        while (j <= n) {
            if (arr[j - 2] > 0) {
                step = arr[j - 2];
                break;
            }
            j += 1;
        }
    }
    for (let i = n - 1; i >= 0; i -= 1) {
        if (arr[i] > 0) {
            console.log(arr[i]);
            break;
        }
    }

}*/