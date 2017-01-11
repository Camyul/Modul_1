function solve(args) {
    let len = args.length,
        newArr = [],
        people = [],
        person,
        i;
    for (i = 0; i < len; i += 3) { //Create array of persons
        person = createPerson(args[i], args[i + 1], +args[i + 2]);
        people.push(person);
    }

    newArr = people
        .filter(x => x.age > 18)
        .map(x => x)
        .forEach(x => console.log(x));


    function createPerson(fName, lName, age) { //Create person
        return {
            firstName: fName,
            lastName: lName,
            age: age
        }
    }
}
var args = [
    'Gosho', 'Petrov', '32',
    'Bay', 'Ivan', '81',
    'John', 'Doe', '42'
];
var args2 = [
    'Penka', 'Hristova', '61',
    'System', 'Failiure', '88',
    'Bat', 'Man', '16',
    'Malko', 'Kote', '72'
];
solve(args2);