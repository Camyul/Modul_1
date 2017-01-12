function solve(args) {
    for (var i = 0; i < text.length; i++) {
        if (text[i] == '<' && text[i + 1] == 'u') {
            i = i + 8;
            upCa = true;
        }
        if (text[i] == '<' && text[i + 1] == '/' && text[i + 2] == 'u') {
            i = i + 9;
            upCa = false;
        }
        if (text[i] == '<' && text[i + 1] == 'l') {
            i = i + 9;
            lowCa = true;
        }
        if (text[i] == '<' && text[i + 1] == '/' && text[i + 2] == 'l') {
            i = i + 10;
            lowCa = false;
        }
        if (text[i] == '<' && text[i + 1] == 'm') {
            i = i + 9;
            mixCa = true;
        }
        if (text[i] == '<' && text[i + 1] == '/' && text[i + 2] == 'm') {
            i = i + 10;
            mixCa = false;
        }
        if (upCa == true) {
            newTxt += text[i].toUpperCase();
        } else if (lowCa == true) {
            newTxt += text[i].toLowerCase();
        } else if (mixCa == true) {
            if (i & 1 == 1) {
                newTxt += text[i].toLowerCase();
            } else {
                newTxt += text[i].toUpperCase();
            }
        } else {
            newTxt += text[i];
        }
    }
    return newTxt;
}

//console.log(solve(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.']));
console.log(solve(['<upcase>tetet<lowcase>MAMA<orgcase>hIhII</orgcase></lowcase></upcase>']));