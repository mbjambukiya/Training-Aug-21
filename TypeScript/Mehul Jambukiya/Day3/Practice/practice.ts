// //generic function

// function Demo<T>(msg:T){
// console.log(msg)
// console.log(typeof(msg))
// }
// Demo<string>("message")
// Demo("Hello")
// Demo(55)
// Demo(true)
// Demo([1,2])

// //generic class

// class StudentInfo<T,U>{
//     private Id:T 
//     private Name:U

//     constructor(Id:T,Name:U){
//         this.Id=Id
//         this.Name=Name
//     }

//     Display(){
//         console.log(`Id : ${this.Id}, Name : ${this.Name}`)
//     }
// }

// var student = new StudentInfo(1,"Satish")
// student.Display()

// //module

// //import
// import { varifyLength as StringLengthVarifier} from "./demo"

// var result = StringLengthVarifier("Hello Everyone!!")
// console.log(result)

// //default import-export

// import Addition from "./demo"

// Addition(2,3)

// //import *

// import * as demomodule from "./demo" 

// demomodule.DisplayString("Hello Everyone!!")
// console.log(demomodule.varifyLength("abc"))

// //re-export
// export {StringLengthVarifier as StringVerifier}


//namespace
/// <reference path="StudentData.ts" />
var totalFees = StudentDataNs.TotalFeeCalulate(500,5)
console.log(totalFees)