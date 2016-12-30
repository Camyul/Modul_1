function solve(args) {
    n = +args[0];
    for (let i = 0, step = 0; i < n; i += 1, step += 1) {
        let result = '';
        for (let j = 1 + step; j <= n + step; j += 1) {
            result += j + ' ';
        }
        console.log(result);
    }
}
args = ['2'];
solve(args);