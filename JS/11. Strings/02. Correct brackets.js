function solve(args) {
    let expression = args[0],
        openIndex = 0,
        closeIndex = 0;

    openIndex = expression.indexOf('(', openIndex)
    closeIndex = expression.indexOf(')', closeIndex)
    while (true) {
        if (openIndex > closeIndex) {
            console.log('Incorrect');
            return;
        }
        openIndex = expression.indexOf('(', openIndex + 1)
        closeIndex = expression.indexOf(')', closeIndex + 1)
        if ((openIndex === -1) && (closeIndex === -1)) {
            console.log('Correct');
            return;
        }
    }
}

solve(['((a+b)/5-d)']); //correct
solve([')(a+b))']); //incorrect
solve([')(a+b)(']); //incorrect
solve([')((a+b)']); //incorrect
solve(['))a + b((']); //incorrect
solve(['(a+b)+d+)(b( * c)']); //correct - obviously not
solve([')(a+b))']); //incorrect
solve(['(a+b+(b*c)+(d/s) + (-5)) + ()()']); //correct
solve(['((a + (b * c))*(())']); // incorrect