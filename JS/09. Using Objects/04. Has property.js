function hasProperty(args) {
    'use strict';
    let gosho = {
        first: 'Pesho',
        last: 'Peshov',
        age: 32
    };
    if (gosho.hasOwnProperty(args)) {
        console.log(true);
        return true;
    } else {
        console.log(false);
        return false;
    }
}
hasProperty('aage');