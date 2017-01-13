function solve(args) {
    let link = args[0],
        startInd,
        endInd,
        server,
        resource,
        protocol;


    startInd = link.indexOf('//', 0);
    protocol = link.substr(0, startInd - 1);
    endInd = link.indexOf('/', startInd + 2);
    server = link.substring(startInd + 2, endInd);
    resource = link.substring(endInd);
    console.log(`protocol: ${protocol}`);
    console.log(`server: ${server}`);
    console.log(`resource: ${resource}`);
}
solve(['http://telerikacademy.com/Courses/Courses/Details/239'])