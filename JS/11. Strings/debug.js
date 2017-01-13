function solve(args) {
    let text = args[0],
        newTxt = "",
        upCa = false,
        lowCa = false,
        mixCa = false;
    for (let i = 0; i < text.length; i++) {
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
        if (text[i] == '<' && text[i + 1] == 'o') {
            i = i + 9;
            mixCa = true;
        }
        if (text[i] == '<' && text[i + 1] == '/' && text[i + 2] == 'o') {
            i = i + 10;
            mixCa = false;
        }
        if (upCa == true) {
            newTxt += text[i].toUpperCase();
        } else if (lowCa == true) {
            newTxt += text[i].toLowerCase();
        } else if (mixCa == true) {
            newTxt += text[i];
        } else {
            newTxt += text[i];
        }
    }
    console.log(newTxt);
}
let args = ["We <upcase>yellow <lowcase>anything</lowcase>submarine</upcase>. We <orgcase>dOn't</orgcase> have <lowcase>anything</lowcase> else."];
solve(args);