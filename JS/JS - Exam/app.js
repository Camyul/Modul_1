function solve(args) {
    let field,
        arr,
        row,
        col,
        dir,
        i, j,
        temp,
        isVisit,
        count = 0;

    arr = args[0].split(' ').map(Number);
    row = arr[0] - 1;
    col = arr[1] - 1;

    field = new Array(row);
    for (i = 0; i <= row; i += 1) {
        field[i] = new Array(col);
        temp = args[i + 1].split(' ').map(Number);
        for (j = 0; j <= col; j += 1) {
            field[i][j] = temp[j]
        }
    }
    isVisit = new Array(row);
    for (i = 0; i <= row; i += 1) {
        isVisit[i] = new Array(col);
        for (j = 0; j <= col; j += 1) {
            isVisit[i][j] = false;
        }
    }
    i = (row / 2) | 0;
    j = (col / 2) | 0;
    //console.log(isVisit);
    //console.log(field);
    while (true) {

        if (i < 0 || j < 0 || i >= row || j >= col) {
            console.log(`No rakiya, only JavaScript ${i} ${j}`);
            return;
        } else {
            if (isVisit[i][j] && count > 0) {
                console.log(`No JavaScript, only rakiya ${i} ${j}`);
                return;
            }
            if (((field[i][j] & 1) > 0) && (!isVisit[i - 1][j])) {
                isVisit[i][j] = true;
                i--;
            } else if (((field[i][j] >> 1) & 1 > 0) && !isVisit[i][j + 1]) {

                isVisit[i][j] = true;
                j++;
            } else if (((field[i][j] >> 2) & 1 > 0) && !isVisit[i + 1][j]) {

                isVisit[i][j] = true;
                i++;
            } else if (((field[i][j] >> 3) & 1 > 0) && !isVisit[i][j - 1]) {

                isVisit[i][j] = true;
                j--;
            }
            count++;
        }
        /*if (isVisit[i][j] && count > 0) {
            console.log(`No JavaScript, only rakiya ${i} ${j}`);
            return;
        } else if (i < 0 || j < 0 || i > row || j > col) {
            console.log(`No rakiya, only JavaScript ${i} ${j}`);
            return;
        }
        console.log(isVisit);
    console.log(field[i][j]);
    console.log(i);
    console.log(j);
    */
    }


}
solve([
    '7 5',
    '9 3 11 9 3',
    '10 12 4 6 10',
    '12 3 13 1 6',
    '9 6 11 12 3',
    '10 9 6 13 6',
    '10 12 5 5 3',
    '12 5 5 5 6'
]);