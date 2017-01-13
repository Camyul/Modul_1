function solve(args) {
    let text,
        endTad,
        newText = '',
        i, j,
        len = args.length;

    //text = text.replace(/\s+/gi, ' ');
    for (j = 0; j < len; j += 1) {
        text = args[j].trim();
        for (i = 0; i < text.length; i += 1) {
            if (text[i] === '<') {
                endTad = false;
                continue;
            } else if (text[i] === '>') {
                endTad = true;
                continue;
            }

            if (endTad) {
                newText += text[i];
            }
        }
        //newText = newText.trim();
    }
    console.log(newText);
}
/*function solveRegex(args) {
    let output = '',
        match = /<.*?>/ig;

    for (var line of args) {
        output += line.replace(match, '').trim();
    }

    console.log(output);
}*/

solve([
    '<html>',
    '  <head>',
    '    <title>Sample site</title>',
    '  </head>',
    '  <body>',
    '    <div>text',
    '      <div>more text</div>',
    '      and more...',
    '    </div>',
    '    in body',
    '  </body>',
    '</html>'
])