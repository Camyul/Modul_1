function solve(args) {
    var len = args.length,
        youngest,
        people = [],
        person,
        i;
    for (i = 0; i < len; i += 3) { //Create array of persons
        person = createPerson(args[i], args[i + 1], +args[i + 2]);
        people.push(person);
    }

    //people.sort((x, y) => x.age > y.age); //Sort array by age asccendind
    youngest = people[0];
    len = people.length;
    for (i = 1; i < len; i += 1) {
        if (youngest.age > people[i].age) {
            youngest = people[i];
        }
    }

    console.log(youngest.firstName + ' ' + youngest.lastName); //Print youngest person

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