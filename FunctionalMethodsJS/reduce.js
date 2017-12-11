var numbers = [1, 2, 3]

/////////////////////////////////////

var withLoopsTotal = 0;

for (let number of numbers){
    withLoopsTotal += number;
}

console.log(withLoopsTotal);

//////////////////////////////////////

var withFilterTotal = numbers.reduce((a,b) => (a+b), 0);
console.log(withFilterTotal);