function solve(args){
var num = args[0];
num = Math.floor(num / 100);
num =num % 10;
if (num == 7) {
        return true;
    } else {
        return false + ' ' + num; 
    }
}