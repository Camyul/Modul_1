function solve(args) {
    let expression = args[0],
        startInd = 0,
        endInd = 0,
        startTag,
        endTag,
        temp;


    //expression = removeUpTags('<upcase>'.toUpperCase(), '</upcase>'.toUpperCase());
    expression = removeOrgTags('<orgcase>', '</orgcase>');
    //expression = removeOrgTags('<orgcase>'.toUpperCase(), '</orgcase>'.toUpperCase());
    expression = removeLowTags('<lowcase>', '</lowcase>');
    // expression = removeLowTags('<lowcase>'.toUpperCase(), '</lowcase>'.toUpperCase());
    expression = removeUpTags('<upcase>', '</upcase>');

    function removeUpTags(startTag, endTag) {
        startInd = expression.indexOf(startTag, startInd);
        endInd = expression.indexOf(endTag, startInd);
        while (startInd > -1) {
            temp = expression.substring(startInd + 8, endInd);
            expression = expression.replace(startTag, '');
            expression = expression.replace(temp, temp.toUpperCase());
            expression = expression.replace(endTag, '');
            startInd = expression.indexOf(startTag, startInd + 1);
            endInd = expression.indexOf(endTag, startInd + 1);
        }
        return expression;
    }

    function removeLowTags(startTag, endTag) {
        startInd = expression.indexOf(startTag, startInd);
        endInd = expression.indexOf(endTag, startInd);
        while (startInd > -1) {
            temp = expression.substring(startInd + 9, endInd);
            expression = expression.replace(startTag, '');
            expression = expression.replace(temp, temp.toLowerCase());
            expression = expression.replace(endTag, '');
            startInd = expression.indexOf(startTag, startInd + 1);
            endInd = expression.indexOf(endTag, startInd + 1);
        }
        return expression;
    }

    function removeOrgTags(startTag, endTag) {
        startInd = expression.indexOf(startTag, startInd);
        while (startInd > -1) {
            expression = expression.replace(startTag, '');
            expression = expression.replace(endTag, '');
            startInd = expression.indexOf(startTag, startInd + 1);
        }
        return expression;
    }

    console.log(expression);
}
solve(['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>ANYTHING</lowcase> else.'])