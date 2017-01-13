function solve(args) {
    let person = JSON.parse(args[0]);

    let text = args[1];


    //person.text = person.text.replace(/#/g, '$');


    //text = text.replace(/"|'/g, '`');
    console.log(text);
}
solve([
    '{ "name": "John", age: 13 }', // options as JSON
    'My name is #{name} and I am #{age}-years-old' // template
]);