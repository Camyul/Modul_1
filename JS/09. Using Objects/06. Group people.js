function solve(args) {
    'use strict';
    let associativeArray = {};

    for (const person of args) {
        if (!associativeArray[person.age]) {
            associativeArray[person.age] = [person];
        } else {
            associativeArray[person.age].push(person);
        }
    }

    console.log(associativeArray);
}
var args = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'John', lastname: 'Doe', age: 42 },
    { firstname: 'Pesho', lastname: 'Pesho', age: 22 },
    { firstname: 'Asdf', lastname: 'Xyz', age: 81 },
    { firstname: 'Gosho', lastname: 'Gosho', age: 22 }
];


solve(args);