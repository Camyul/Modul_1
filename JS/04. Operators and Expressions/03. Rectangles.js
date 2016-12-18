function solve(args){
    var height = args[0];
    var width = args[1];
    var area = (height * width).toFixed(2);
    var perimeter = ((2 * height) + (2 * width)).toFixed(2);
    return area + ' ' + perimeter;
}