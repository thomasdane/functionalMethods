var numbers = [30, 40, 99]

var withLoops = []

for (let number of numbers){
    if (number < 50){
        withLoops.push(number);
    }
}

console.log(withLoops);
