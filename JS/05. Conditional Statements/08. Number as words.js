function solve(args) {
    'use strict';
    let num = args[0] * 1;
    let result = '';
    if (num < 20) {
        switch (num) {
            case 0:
                result = 'Zero';
                break;
            case 1:
                result = 'One';
                break;
            case 2:
                result = 'Two';
                break;
            case 3:
                result = 'Three';
                break;
            case 4:
                result = 'Four';
                break;
            case 5:
                result = 'Five';
                break;
            case 6:
                result = 'Six';
                break;
            case 7:
                result = 'Seven';
                break;
            case 8:
                result = 'Eight';
                break;
            case 9:
                result = 'Nine';
                break;
            case 10:
                result = 'Ten';
                break;
            case 11:
                result = 'Eleven';
                break;
            case 12:
                result = 'Twelve';
                break;
            case 13:
                result = 'Thirteen';
                break;
            case 14:
                result = 'Fourteen';
                break;
            case 15:
                result = 'Fifteen';
                break;
            case 16:
                result = 'Sixteen';
                break;
            case 17:
                result = 'Seventeen';
                break;
            case 18:
                result = 'Eighteen';
                break;
            case 19:
                result = 'Nineteen';
                break;
            default:
                break;
        }
    } else {
        if ((num >= 20) && (num < 100)) {
            let rest = num % 10;
            switch (rest) {
                case 1:
                    result = 'one';
                    break;
                case 2:
                    result = 'two';
                    break;
                case 3:
                    result = 'three';
                    break;
                case 4:
                    result = 'four';
                    break;
                case 5:
                    result = 'five';
                    break;
                case 6:
                    result = 'six';
                    break;
                case 7:
                    result = 'seven';
                    break;
                case 8:
                    result = 'eight';
                    break;
                case 9:
                    result = 'nine';
                    break;
                default:
                    result = '';
                    break;
            }
            switch ((num / 10) | 0) {
                case 2:
                    result = 'Twenty ' + result;
                    break;
                case 3:
                    result = 'Thirty ' + result;
                    break;
                case 4:
                    result = 'Forty ' + result;
                    break;
                case 5:
                    result = 'Fifty ' + result;
                    break;
                case 6:
                    result = 'Sixty ' + result;
                    break;
                case 7:
                    result = 'Seventy ' + result;
                    break;
                case 8:
                    result = 'Eighty ' + result;
                    break;
                case 9:
                    result = 'Ninety ' + result;
                    break;
                default:
                    result = '';
                    break;
            }
        } else if ((num >= 100) && (num < 1000)) {
            let resthundred = num % 100;

            if (resthundred < 20) {
                switch (resthundred) {
                    case 1:
                        result = ' and one';
                        break;
                    case 2:
                        result = ' and two';
                        break;
                    case 3:
                        result = ' and three';
                        break;
                    case 4:
                        result = ' and four';
                        break;
                    case 5:
                        result = ' and five';
                        break;
                    case 6:
                        result = ' and six';
                        break;
                    case 7:
                        result = ' and seven';
                        break;
                    case 8:
                        result = ' and eight';
                        break;
                    case 9:
                        result = ' and nine';
                        break;
                    case 10:
                        result = ' and ten';
                        break;
                    case 11:
                        result = ' and eleven';
                        break;
                    case 12:
                        result = ' and twelve';
                        break;
                    case 13:
                        result = ' and thirteen';
                        break;
                    case 14:
                        result = ' and fourteen';
                        break;
                    case 15:
                        result = ' and fifteen';
                        break;
                    case 16:
                        result = ' and sixteen';
                        break;
                    case 17:
                        result = ' and seventeen';
                        break;
                    case 18:
                        result = ' and eighteen';
                        break;
                    case 19:
                        result = ' and nineteen';
                        break;
                    default:
                        result = '';
                        break;
                }
            } else {
                let rest = resthundred % 10;
                switch (rest) {
                    case 1:
                        result = 'one';
                        break;
                    case 2:
                        result = 'two';
                        break;
                    case 3:
                        result = 'three';
                        break;
                    case 4:
                        result = 'four';
                        break;
                    case 5:
                        result = 'five';
                        break;
                    case 6:
                        result = 'six';
                        break;
                    case 7:
                        result = 'seven';
                        break;
                    case 8:
                        result = 'eight';
                        break;
                    case 9:
                        result = 'nine';
                        break;
                    default:
                        result = '';
                        break;
                }
                switch ((resthundred / 10) | 0) {
                    case 2:
                        result = ' and twenty ' + result;
                        break;
                    case 3:
                        result = ' and thirty ' + result;
                        break;
                    case 4:
                        result = ' and forty ' + result;
                        break;
                    case 5:
                        result = ' and fifty ' + result;
                        break;
                    case 6:
                        result = ' and sixty ' + result;
                        break;
                    case 7:
                        result = ' and seventy ' + result;
                        break;
                    case 8:
                        result = ' and eighty ' + result;
                        break;
                    case 9:
                        result = ' and ninety ' + result;
                        break;
                    default:
                        result = '' + result;
                        break;
                }
            }
            switch ((num / 100) | 0) {
                case 1:
                    result = 'One hundred' + result;
                    break;
                case 2:
                    result = 'Two hundred' + result;
                    break;
                case 3:
                    result = 'Three hundred' + result;
                    break;
                case 4:
                    result = 'Four hundred' + result;
                    break;
                case 5:
                    result = 'Five hundred' + result;
                    break;
                case 6:
                    result = 'Six hundred' + result;
                    break;
                case 7:
                    result = 'Seven hundred' + result;
                    break;
                case 8:
                    result = 'Eight hundred' + result;
                    break;
                case 9:
                    result = 'Nine hundred' + result;
                    break;
                default:
                    break;
            }

        }

    }
    console.log(result);
}
//let args = ['347'];
//solve(args);