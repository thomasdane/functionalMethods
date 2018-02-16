var words = ['foo', 'bar', 'baz']

var withLoops = [];

for (let word of words) {
    withLoops.push(word.toUpperCase());
}

console.log(withLoops);