function solve(args) {
    let name = args;
    sayName(name);

    function sayName(n) {
        console.log('Hello, <' + n + '>!');
    };
}
solve("What's up");