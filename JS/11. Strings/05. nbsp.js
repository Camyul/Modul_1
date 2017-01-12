function solve(args) {
    let text = args[0],
        index = 0;
    index = text.indexOf(' ', index);
    while (index > -1) {
        text = text.replace(" ", "&nbsp;");
        index = text.indexOf(' ', index + 1);

    }

    console.log(text);
}
solve(['This text contains 4 spaces!!'])