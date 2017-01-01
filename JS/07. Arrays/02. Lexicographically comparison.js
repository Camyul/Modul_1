function solve(args) {
    let a = args[0],
        b = args[1],
        i,
        result;
    for (i = 0; i < Math.min(a.length, b.length); i += 1) {
        if (a[i] > b[i]) {
            result = ">";
            break;
        }
        if (a[i] < b[i]) {
            result = "<";
            break;
        }
        if (a[i] === b[i]) {
            result = "=";
        }
    }
    if ((a.length !== b.length) && (result === "=")) {
        result = a.length > b.length ? ">" : "<";
    }
    console.log(result);
}
args = ['foods', 'food'];
solve(args);