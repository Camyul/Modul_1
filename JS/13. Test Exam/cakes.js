function solve(args) {
    let sum = +args[0],
        cakeOne = +args[1],
        cakeTwo = +args[2],
        cakeThree = +args[3],
        answer = 0,
        i,
        j,
        k,
        tempSum;

    for (i = 0; i < sum / cakeThree; i += 1) {

        for (j = 0; j < sum / cakeTwo; j += 1) {

            for (k = 0; k < sum / cakeOne; k += 1) {

                tempSum = k * cakeOne + j * cakeTwo + i * cakeThree;
                if (tempSum <= sum) {
                    answer = Math.max(answer, tempSum);
                }

                //console.log(`${i} cakes with price ${cakeOne}
                //${j} cakes with price ${cakeTwo} and
                //${k} cakes with price ${cakeThree}`);
                //return `${i} cakes with price ${cakeOne}
                //${j} cakes with price ${cakeTwo} and
                //${k} cakes with price ${cakeThree}`

                //return tempSum;
                else if (tempSum > sum) {
                    tempSum = 0;
                }

            }

        }
    }
    console.log(answer);
}
solve(['110', '13', '15', '17']);
solve(['20', '11', '200', '300']);
solve(['110', '19', '29', '39']);