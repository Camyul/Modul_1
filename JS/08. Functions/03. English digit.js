function solve(args) {
    let number = args[0],
        digit,
        strDigit;
    digit = getLastDigit(number);
    strDigit = convertToWord(digit);
    console.log(strDigit);

    function getLastDigit(number) {
        digit = number % 10;
        return digit;
    }

    function convertToWord(digit) {
        switch (digit) {
            case 0:
                return 'zero';
                break;
            case 1:
                return 'one';
                break;
            case 2:
                return 'two';
                break;
            case 3:
                return 'three';
                break;
            case 4:
                return 'four';
                break;
            case 5:
                return 'five';
                break;
            case 6:
                return 'six';
                break;
            case 7:
                return 'seven';
                break;
            case 8:
                return 'eight';
                break;
            case 9:
                return 'nine';
                break;
            default:
                return;
                break;
        }
    }
}
solve(['548']);