//class
class Employee {
    empId: number;
    empName: string;

    constructor(id: number, name: string) {
        this.empId = id;
        this.empName = name;
    }

    getDetails() {
        console.log(`EmployeeId : ${this.empId}, EmployeeName : ${this.empName}`)
    }
}

var emp = new Employee(1, "testname");
emp.getDetails();

//tuple

var tuple1: [string, number]
tuple1 = ["abc", 123]
console.log(tuple1)

var tuple2: [string, number][]
tuple2 = [["aa", 1], ["bb", 2]]
console.log(tuple2)

//union

var union1: string | number
union1 = 123;
console.log(union1)
console.log(typeof (union1))

union1 = "abc";
console.log(union1)
console.log(typeof (union1))
// union1 = true; //error


//enum

enum Week {
    Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
}

var day: Week = Week.Monday;
console.log(day)

//interface

interface IAnimal {
    Name: string
    AnimalSound: (string) => void;
}

class Lion implements IAnimal {
    Name: string
    constructor(name: string) {
        this.Name = name;
    }
    AnimalSound(sound: string): void {
        console.log(`${this.Name} sounds ${sound}!`)
    }
}

var lion = new Lion("Gir-Lion");
lion.AnimalSound("Roar");

//interface as type

interface KeyPair {
    key: string;
    value: string;
}

var kv1: KeyPair = { key: "aa", value: "abc" }
console.log(kv1)

//interface as function type

interface KeyValueProcessor {
    (key: number, value: string): void;
}

function addKeyValue(key: number, value: string): void {
    console.log(`addKeyValue : key = ${key}, value = ${value}`)
}

var kvp: KeyValueProcessor = addKeyValue
kvp(1, "aaa")

//interface as array type

interface numList {
    [index: number]: number
}

var numArr: numList = [1, 2, 3];
console.log(numArr[1])

//extend interface

interface IPerson{
    name:string
    gender:string
}

interface IEmployee extends IPerson{
    employeeId:number
}

class Employee1 implements IEmployee{
    name:string
    gender:string
    employeeId:number
    constructor(name:string,gender:string,employeeId:number){
        this.name=name
        this.gender=gender
        this.employeeId=employeeId
    }
}

var employee = new Employee1("Satish","male",111)
console.log(employee)
console.log(employee.employeeId)
console.log(employee.name)
console.log(employee.gender)

//named function

function add(a:number,b:number):number{
    return a+b
}

console.log(add(2,3))

//anonymous function

var sum = function(a:number,b:number):number{
    return a+b
}
console.log(sum(10,15))

//lambda funcion

var addition = (a:number,b:number)=>{
    return a+b
}

console.log(addition(3,4))