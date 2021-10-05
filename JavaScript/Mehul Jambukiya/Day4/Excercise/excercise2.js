// Explain difference between var and let keyword using example. 

var x = 5;

if (true) {
    var x = 10;
    console.log(x);
}
console.log(x);


var y = 15;
if (true) {
    let y = 20;
    console.log(y);
}
console.log(y);

