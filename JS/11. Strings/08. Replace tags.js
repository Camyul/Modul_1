function solve(args) {
    let text = args[0],
        index,
        sait,
        i,
        comment,
        separators,
        splited;
    separators = ['<a href="', '</a>'];
    splited = text.split(new RegExp(separators.join('|'), 'g'));
    for (i = 1; i < splited.length; i += 2) {
        index = splited[i].indexOf('">');
        sait = splited[i].substring(0, index);
        comment = splited[i].substring(index + 2);
        splited[i] = `[${comment}](${sait})`;
        //splited[i] = '[' + comment + ']' + '(' + sait + ')';
    }
    console.log(splited.join(''));
}
solve(['<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>'])