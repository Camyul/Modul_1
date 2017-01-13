function solve(args) {
    let input = args[0],
        up = false,
        low = false,
        org = false,
        doNothing = false,
        result = '',
        inTag = false;

    input = input.replace(/\\/g, '');
    //console.log(input);

    for (let i = 0, len = input.length; i < len; i += 1) {
        let currSymbol = input[i];

        if (currSymbol == '<') {
            inTag = true;

            if (input[i + 1] == '/') {
                inTag = true;
                doNothing = true;
                continue;
            }

            if (input[i + 1] == 'u') {
                up = true;
                low = false;
                org = false;
            } else if (input[i + 1] == 'l') {
                low = true;
                up = false;
                org = false;
            } else if (input[i + 1] == 'o') {
                org = true;
                up = false;
                low = false;
            }
            continue;
        } else if (currSymbol == '>') {
            inTag = false;
            if (doNothing) {
                up = false;
                low = false;
                org = false;
            }
            doNothing = false;
            continue;
        }

        if (inTag) {
            continue;
        } else {
            if (up) {
                result += currSymbol.toUpperCase();
            } else if (low) {
                result += currSymbol.toLowerCase();
            } else if (org) {
                result += currSymbol;
            } else {
                result += currSymbol;
            }
        }
    }

    return result;
}

console.log(solve(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.']));
console.log(solve(['<upcase>tet<lowcase>MAMA<orgcase>hIhII</orgcase></lowcase></upcase>']));