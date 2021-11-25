// Store 5 Employee Data(ID,Name,City,DOJ) in one Array. Search the employee with ID.
// Search the employees who has joined after year 2020
// Search the employee who has joined after year 2020 and stays in Mumbai city

var citylist:Map<number,string>=new Map()

citylist.set(1,"Ahmedabad")
citylist.set(2,"Mubmai")
citylist.set(3,"Baroda")

type Employee = {
    employeeId:number
    employeeName:string
    city:string
    dateOfJoin:Date
}

var employeeData:Employee[] = [
    {employeeId:1,employeeName:"Vishal Shah",city:citylist.get(1),dateOfJoin:new Date("2019-11-05")},
    {employeeId:2,employeeName:"Darshan Patel",city:citylist.get(3),dateOfJoin:new Date("2020-09-07")},
    {employeeId:3,employeeName:"Varjesh Shah",city:citylist.get(1),dateOfJoin:new Date("2021-08-02")},
    {employeeId:4,employeeName:"Kevin Patel",city:citylist.get(2),dateOfJoin:new Date("2021-08-15")},
    {employeeId:5,employeeName:"Pravin Patel",city:citylist.get(2),dateOfJoin:new Date("2016-05-15")}
]

function SearchByEmployeeId(employeeId:number):void {
    employeeData.forEach(employee => {
        if(employee.employeeId==employeeId){
            console.log(`EmployeeId : ${employee.employeeId}, Name : ${employee.employeeName}, City : ${employee.city}, Joining Date : ${employee.dateOfJoin.getDate()}/${employee.dateOfJoin.getMonth()}/${employee.dateOfJoin.getFullYear()}`)
        }
    });
}

function FilterByJoinYear(year:number):void {
    employeeData.forEach(employee => {
        if(employee.dateOfJoin.getFullYear() > year){
            console.log(`EmployeeId : ${employee.employeeId}, Name : ${employee.employeeName}, City : ${employee.city}, Joining Date : ${employee.dateOfJoin.getDate()}/${employee.dateOfJoin.getMonth()}/${employee.dateOfJoin.getFullYear()}`)
        }
    });
}

function FilterByCityJoinYear(city:string,year:number):void {
    employeeData.forEach(employee => {
        if(employee.dateOfJoin.getFullYear() > 2020 && employee.city==city){
            console.log(`EmployeeId : ${employee.employeeId}, Name : ${employee.employeeName}, City : ${employee.city}, Joining Date : ${employee.dateOfJoin.getDate()}/${employee.dateOfJoin.getMonth()}/${employee.dateOfJoin.getFullYear()}`)
        }
    });
}

console.log("\n1.Search by employeeId\n2.Filter by year of joining\n3.Filter by city and year of joining\n")
var choice:number = 3
var year:number
switch(choice){
    case 1:
        var employeeId:number = 1
        SearchByEmployeeId(employeeId)
        break
    case 2:
        year = 2020
        FilterByJoinYear(year)
        break
    case 3:
        year = 2020
        var city:string = citylist.get(2)
        FilterByCityJoinYear(city,year)
        break
    default:
        console.log("Invalid choice!!")
        break
}