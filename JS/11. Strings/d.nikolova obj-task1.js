var arr = [
    '7', '7', '2', '2',
    '5', '6', '2', '2',
    '95', '-14.5', '0', '-0.123'
];

function coords(arr) {
    var points1 = arr.slice(0, 4),
        points2 = arr.slice(4, 8),
        points3 = arr.slice(8, 12),
        line1 = new Line(points1),
        line2 = new Line(points2),
        line3 = new Line(points3),
        a = +calculateDistance(line1),
        b = +calculateDistance(line2),
        c = +calculateDistance(line3),
        isTriangle = '';
    if ((a + b) > c && (a + c) > b && (b + c) > a) {
        isTriangle = 'Triangle can be built';
    } else {
        isTriangle = 'Triangle can not be built';
    }
    console.log(isTriangle)
        //return isTriangle;

    function Line(points) {
        var pointsArr = points.map(Number);
        this.x1 = pointsArr[0];
        this.y1 = pointsArr[1];
        this.x2 = pointsArr[2];
        this.y2 = pointsArr[3];
    }

    function calculateDistance(line) {
        var d = Math.sqrt((line.x2 - line.x1) * (line.x2 - line.x1) + (line.y2 - line.y1) * (line.y2 - line.y1));
        console.log(d.toFixed(2));
        return d.toFixed(2);
    }
}
coords(arr);