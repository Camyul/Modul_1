function solve(args) {
    let expression = args[0].toLowerCase(),
        count = 0,
        index = 0,
        text = args[1].toLowerCase();

    index = text.indexOf(expression, index);
    while (index > -1) {
        index = text.indexOf(expression, index + 1);
        count += 1;
    }
    console.log(count);
}

solve(['in', 'We are living In an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.']);