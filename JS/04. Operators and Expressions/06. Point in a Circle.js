//function solve(args){
     var args = [];
    args[0] = '-3';
     args[1] = '2';
var x = Number(args[0]);
var y = Number(args[1]);
var x = -3;
var y = 2;
var radius = Math.sqrt((x * x) + (y * y));
if (radius <= 2) {
    console.log(yes + ' ' + radius.toFixed(2));
} else {
    console.log(no + ' ' + radius.toFixed(2));
}
//}