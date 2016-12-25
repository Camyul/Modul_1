function solve(args) {
    'use strict';
    let num = args[0] * 1;
    let result = '';
    if (num < 20) {
        result = numToString(num);
    } else {
        if ((num >= 20) && (num < 100)) {
            result = numToDozens(num);
        } else if ((num >= 100) && (num < 1000)) {
            result = numToHundreds(num);
        }

    }
    console.log(result);
}
let args = ['999'];
solve(args);

function numToHundreds(num) {
    let restDozens = num % 100;
    result = numToDozens(restDozens);
    switch ((num / 100) | 0) {
        case 1:
            result = 'One hundred and ' + result;
            return result;
            break;
        case 2:
            result = 'Two hundred and ' + result;
            return result;
            break;
        case 3:
            result = 'Three hundred and ' + result;
            return result;
            break;
        case 4:
            result = 'Four hundred and ' + result;
            return result;
            break;
        case 5:
            result = 'Five hundred and ' + result;
            return result;
            break;
        case 6:
            result = 'Six hundred and ' + result;
            return result;
            break;
        case 7:
            result = 'Seven hundred and ' + result;
            return result;
            break;
        case 8:
            result = 'Eight hundred and ' + result;
            return result;
            break;
        case 9:
            result = 'Nine hundred and ' + result;
            return result;
            break;

        default:
            break;
    }

}

function numToDozens(num) {
    let rest = num % 10;
    if (rest > 0) {
        result = numToString(rest);
    } else {
        result = '';
    }
    switch ((num / 10) | 0) {
        case 2:
            result = 'twenty ' + result;
            return result;
            break;
        case 3:
            result = 'thirty ' + result;
            return result;
            break;
        case 4:
            result = 'forty ' + result;
            return result;
            break;
        case 5:
            result = 'fifty ' + result;
            return result;
            break;
        case 6:
            result = 'sixty ' + result;
            return result;
            break;
        case 7:
            result = 'seventy ' + result;
            return result;
            break;
        case 8:
            result = 'eighty ' + result;
            return result;
            break;
        case 9:
            result = 'ninty ' + result;
            return result;
            break;
        default:
            break;

    }
}

function numToString(num) {
    switch (num) {
        case 0:
            result = 'zero';
            return result;
            break;
        case 1:
            result = 'one';
            return result;
            break;
        case 2:
            result = 'two';
            return result;
            break;
        case 3:
            result = 'three';
            return result;
            break;
        case 4:
            result = 'four';
            return result;
            break;
        case 5:
            result = 'five';
            return result;
            break;
        case 6:
            result = 'six';
            return result;
            break;
        case 7:
            result = 'seven';
            return result;
            break;
        case 8:
            result = 'eight';
            return result;
            break;
        case 9:
            result = 'nine';
            return result;
            break;
        case 10:
            result = 'ten';
            return result;
            break;
        case 11:
            result = 'eleven';
            return result;
            break;
        case 12:
            result = 'twelve';
            return result;
            break;
        case 13:
            result = 'thirteen';
            return result;
            break;
        case 14:
            result = 'fourteen';
            return result;
            break;
        case 15:
            result = 'fifteen';
            return result;
            break;
        case 16:
            result = 'sixteen';
            return result;
            break;
        case 17:
            result = 'seventeen';
            return result;
            break;
        case 18:
            result = 'eighteen';
            return result;
            break;
        case 19:
            result = 'nineteen';
            return result;
            break;
        default:
            break;
    }
}