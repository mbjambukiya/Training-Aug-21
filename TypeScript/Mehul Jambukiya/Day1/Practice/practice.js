var num1 = 6;
var num2 = 0x123;
var num3 = 83;
var num4 = 13;
console.log(num1);
console.log(num2);
console.log(num3);
console.log(num4);
var a = undefined;
console.log(a);
function PrintHello() {
    console.log("Hello!");
}
PrintHello();
var str1 = "abc";
var str2 = 'aaa';
var str3 = "num1 = ".concat(num1);
console.log(str1);
console.log(str2);
console.log(str3);
var var1 = null;
console.log(var1);
var var2 = false;
console.log(var2);
var var3 = "abc";
console.log(var3);
var3 = 55;
console.log(var3);
var3 = null;
console.log(var3);
var arr = [1, 2, 3];
console.log(arr);
var arr1 = [1, 2, 3];
console.log(arr1);
var multiarr = ["aaa", 1, "bbb", 2, 3, "ccc"];
console.log(multiarr);
var multiarr1 = ["aaa", 1, "bbb", 2, 3, "ccc"];
console.log(multiarr1);
for (var k = 0; k < multiarr.length; k++) {
    console.log(multiarr[k]);
}
for (var i in multiarr) {
    console.log(multiarr[i]);
}
for (var _i = 0, multiarr_1 = multiarr; _i < multiarr_1.length; _i++) {
    var j = multiarr_1[_i];
    console.log(j);
}
//number methods
var num5 = 1225.30;
var val = num5.toExponential();
console.log(val);
num5 = 177.234;
console.log(num5.toFixed());
console.log(num5.toFixed(2));
console.log(num5.toFixed(6));
console.log(num5.toLocaleString());
console.log(num5.toString());
num5 = 7.123456;
console.log(num5.toPrecision());
console.log(num5.toPrecision(1));
console.log(num5.toPrecision(2));
console.log(num5.valueOf());
//string methods
str1 = "Hello Everyone!!";
console.log(str1.charAt(6));
console.log(str1.concat("Good morning!!"));
console.log(str1.indexOf('e'));
console.log(str1.indexOf('e', 2));
console.log(str1.replace('Everyone', 'world'));
str2 = "aaa,bbb,ccc";
console.log(str2.split(","));
console.log(str1.toUpperCase());
console.log(str1.toLowerCase());
console.log(str1.charCodeAt(6));
// console.log(str1.codePointAt(6))
// console.log(str1.includes("every"))
// console.log(str1.endsWith('e',1))
console.log(str1.lastIndexOf("one"));
console.log(str1.localeCompare("one"));
console.log(str1.localeCompare("Everyone"));
console.log(str1.localeCompare("World"));
console.log(str1.localeCompare("Hello Everyone!!"));
var re = /everyone/gi;
console.log(str1.search(re));
console.log(str1.match(re));
console.log(str1.slice(0, 5));
console.log(str1.substr(6, 5));
console.log(str1.substring(0, 5));
console.log(str1.toLocaleLowerCase());
console.log(str1.toLocaleUpperCase());
str1 = "      abcd         ";
console.log(str1.trim());
// console.log(str1.trimLeft())
// console.log(str1.trimRight())
// console.log(str1.trimEnd())
// console.log(str1.trimStart())
//array methods
var array1 = [1, 2, 3, 4, 5, 4];
var array2 = [4, 5, 6, 7, 8, 9];
console.log(array1.concat(array2));
// console.log(array1.copyWithin(0,2,4))
console.log(array1.every(function (e) { return e > 0; }));
console.log(array1.every(function (e) { return e > 2; }));
console.log(array1.some(function (e) { return e > 2; }));
console.log(array1.filter(function (e) { return e > 2; }));
console.log(array1.forEach(function (e) { return console.log(e); }));
console.log(array1.indexOf(4));
console.log(array1.lastIndexOf(4));
console.log(array1.join(","));
console.log(array1.join());
console.log(array1.join(""));
console.log(array1.map(Math.sqrt));
console.log(array1.pop());
console.log(array1);
console.log(array1.push(30));
console.log(array1);
console.log(array1.reduce(function (a, b) { return a + b; }));
console.log(array1.reduceRight(function (a, b) { return a + b; }));
console.log(array1.reverse());
console.log(array1.shift());
console.log(array1);
console.log(array1.unshift(12, 15));
console.log(array1);
console.log(array1.slice(2, 5));
console.log(array1.sort());
console.log(array1.splice(0, 0, 40, 50, 60));
console.log(array1);
console.log(array1.splice(0, 3));
console.log(array1);
console.log(array1.toString());
