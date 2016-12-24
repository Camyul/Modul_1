function solve(args) {
    'use strict';
    let a = args[0] * 1;
    let b = args[1] * 1;
    let c = args[2] * 1;
    let diskriminant = Math.pow(b, 2) - (4 * a * c);
    if (diskriminant < 0) {
        console.log('no real roots');
    } else {
        if (diskriminant === 0) {
            let result = -b / (2 * a);
            console.log('x1=x2=' + result.toFixed(2));
        } else {
            let x1 = (-b - Math.sqrt(diskriminant)) / (2 * a);
            let x2 = (-b + Math.sqrt(diskriminant)) / (2 * a);
            console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
        }
    }
}