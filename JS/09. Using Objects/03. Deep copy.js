function clone(args) {
    'use strict';
    let newObj = args.constructor(),
        i;
    if (args == null || typeof(args) != 'object') {
        console.log(args);
        return args;
    }
    for (var prop in args) {
        newObj[prop] = args[prop];
    }
    console.log(newObj);
    return newObj;
}
let gosho = {
    first: 'Pesho',
    last: 'Peshov',
    age: 32
};
clone(gosho);