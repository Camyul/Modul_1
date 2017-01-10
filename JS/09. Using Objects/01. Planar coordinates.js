function solve(args) {
    var points = args,
        len = points.length,
        line = [];

    function CalcLineLength(a, b, c, d) {
        var fSide = c - a,
            sSide = d - b;

        return Math.sqrt((fSide * fSide) + (sSide * sSide));
    }
    for (var i = 0, j = 0; i < len; i += 4, j += 1) {
        line[j] = CalcLineLength(points[i], points[i + 1], points[i + 2], points[i + 3]).toFixed(2);
    }
    console.log(line.join('\n'));
    line = line.map(Number);
    isTriangle(line[0], line[1], line[2]);

    function isTriangle(a, b, c) {
        if (a < (b + c) && b < (a + c) && c < (a + b)) {
            console.log('Triangle can be built');
        } else {
            console.log('Triangle can not be built');
        }
    }
}
//var args = ['5', '6', '7', '8', '1', '2', '3', '4', '9', '10', '11', '12'];
var args = ['7', '7', '2', '2', '5', '6', '2', '2', '95', '-14.5', '0', '-0.123'];
solve(args);