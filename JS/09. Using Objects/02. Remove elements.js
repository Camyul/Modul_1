function solve(args) {
    var element = args[0];
    Array.prototype.removeElements = function(element) {
        var index = this.indexOf(element);
        while (!(index === -1)) {
            this.splice(index, 1);
            index = this.indexOf(element);
        }
    }
    args.removeElements(element);
    console.log(args.join('\n'));
}
var args = ['1', '2', '1', '1', '1', '2', '1', '1', '1', '10', '11', '12'];
//var args = ['7', '7', '2', '7', '5', '6', '7', '2', '95', '-14.5', '0', '-0.123'];
solve(args);