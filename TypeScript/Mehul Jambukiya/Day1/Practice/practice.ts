
var num1: number = 6
var num2: number = 0x123
var num3: number = 0o123
var num4: number = 0b1101

console.log(num1)
console.log(num2)
console.log(num3)
console.log(num4)

let a :void = undefined
console.log(a)

function PrintHello():void{
    console.log("Hello!")
}

PrintHello()

let str1: string = "abc"
let str2: string = 'aaa'
let str3:string=`num1 = ${num1}`

console.log(str1)
console.log(str2)
console.log(str3)

let var1:number = null
console.log(var1)

let var2:boolean = false
console.log(var2);

let var3:any="abc"
console.log(var3)

var3=55
console.log(var3)

var3=null
console.log(var3)

var arr:Array<number> = [1,2,3]
console.log(arr)

var arr1:number[] = [1,2,3]
console.log(arr1)

var multiarr:Array<number|string> = ["aaa",1,"bbb",2,3,"ccc"]
console.log(multiarr)

var multiarr1:(number|string)[] = ["aaa",1,"bbb",2,3,"ccc"]
console.log(multiarr1)

for(var k=0;k<multiarr.length;k++){
    console.log(multiarr[k])
}

for(var i in multiarr){
    console.log(multiarr[i])
}

for(var j of multiarr){
    console.log(j)
}

//number methods

var num5:number = 1225.30 
var val =  num5.toExponential()
console.log(val)

num5 = 177.234 
console.log(num5.toFixed()) 
console.log(num5.toFixed(2)) 
console.log(num5.toFixed(6))

console.log(num5.toLocaleString())
console.log(num5.toString())

num5 = 7.123456 
console.log(num5.toPrecision()) 
console.log(num5.toPrecision(1))
console.log(num5.toPrecision(2))

console.log(num5.valueOf())

//string methods

str1 = "Hello Everyone!!"
console.log(str1.charAt(6))

console.log(str1.concat("Good morning!!"))

console.log(str1.indexOf('e'))
console.log(str1.indexOf('e', 2))
console.log(str1.replace('Everyone', 'world'))

str2 = "aaa,bbb,ccc"
console.log(str2.split(","))

console.log(str1.toUpperCase())
console.log(str1.toLowerCase())

console.log(str1.charCodeAt(6))

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

console.log(str1.slice(0,5));
console.log(str1.substr(6,5));
console.log(str1.substring(0,5));

console.log(str1.toLocaleLowerCase())
console.log(str1.toLocaleUpperCase())

str1 = "      abcd         "
console.log(str1.trim())

// console.log(str1.trimLeft())
// console.log(str1.trimRight())
// console.log(str1.trimEnd())
// console.log(str1.trimStart())

//array methods

var array1:number[]=[1,2,3,4,5,4]
var array2:number[]=[4,5,6,7,8,9]

console.log(array1.concat(array2))
// console.log(array1.copyWithin(0,2,4))
console.log(array1.every(e=>e>0))
console.log(array1.every(e=>e>2))
console.log(array1.some(e=>e>2))
console.log(array1.filter(e=>e>2))
console.log(array1.forEach(e=>console.log(e)))
console.log(array1.indexOf(4))
console.log(array1.lastIndexOf(4))
console.log(array1.join(","))
console.log(array1.join())
console.log(array1.join(""))
console.log(array1.map(Math.sqrt))
console.log(array1.pop())
console.log(array1)
console.log(array1.push(30))
console.log(array1)
console.log(array1.reduce((a,b)=>a+b))
console.log(array1.reduceRight((a,b)=>a+b))
console.log(array1.reverse())
console.log(array1.shift())
console.log(array1)
console.log(array1.unshift(12,15))
console.log(array1)
console.log(array1.slice(2,5))
console.log(array1.sort())
console.log(array1.splice(0,0,40,50,60))
console.log(array1)
console.log(array1.splice(0,3))
console.log(array1)
console.log(array1.toString())