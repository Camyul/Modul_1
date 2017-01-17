function solve(args) {
    let person = JSON.parse(args[0]),
        text = `` + args[1],
        prop,
        startInd = 0,
        endInd = 0;

    while (true) {
        startInd = text.indexOf('#{') + 2;
        endInd = text.indexOf('}');
        if (endInd === -1) {
            break;
        }
        prop = text.slice(startInd, endInd);
        text = text.replace(/#\{.*?\}/, person[prop]);
    }
    console.log(text);
}
solve([
    '{ "name": "John", "age": 13 }',
    "My name is #{name} and I am #{age}-years-old"
]);