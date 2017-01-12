function solve(args) {
    let text = args[0],
        inTag = false,
        openTag = false,
        newText = '',
        org = false,
        low = false,
        up = false,
        len,
        i;
    text = text.replace(/\\/g, '');
    for (i = 0, len = text.length; i < len; i += 1) {
        if (text[i] === '<') {
            inTag = true;
            openTag = true;
            if (text[i + 1] === '/') {
                if (text[i + 2] === 'o') {
                    openTag = false;
                    org = false;
                } else if (text[i + 2] === 'u') {
                    openTag = false;
                    up = false;
                } else if (text[i + 2] === 'l') {
                    openTag = false;
                    low = false;
                }
            } else if (text[i + 1] === 'o') {
                org = true;
                up = false;
                low = false;
            } else if (text[i + 1] === 'u') {
                org = false;
                up = true;
                low = false;
            } else if (text[i + 1] === 'l') {
                org = false;
                up = false;
                low = true;
            }
        } else if (text[i] === '>') {
            inTag = false;
            if (!openTag) {
                org = false;
                up = false;
                low = false;
            }
            continue;
        }
        if (inTag) {
            continue;
        } else {
            if (up && openTag) {
                newText += text[i].toUpperCase();
            } else if (low && openTag) {
                newText += text[i].toLowerCase();
            } else {
                newText += text[i];
            }
        }
    }
    console.log(newText);
}

solve(['a <u>ye</u>. We <lowcase>anything</lowcase> else.']);
//console.log(solve(['<upcase>tetet<lowcase>MAMA<orgcase>hIhII</orgcase></lowcase></upcase>']));
solve(['<upcase>tetet<lowcase>MAMA<orgcase>hIhII</orgcase></lowcase></upcase>']);
//solve(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.'])