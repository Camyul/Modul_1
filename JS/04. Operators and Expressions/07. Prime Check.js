function solve(args){
var num = 17;
var sqrtNum = Math.floor(Math.sqrt(num));
var isPrime = true;
if(num > 1){
    for(var i = 2; i <= sqrtNum; i+=1) {
        if ((num % i) != 0) {
            continue;
        } else {
            isPrime = false;
            return isPrime; 
        }
    }
    return isPrime;
}
else{
    isPrime = false;
    return isPrime;
}
}