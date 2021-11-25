//map

var employee:Map<any,any> = new Map()

employee.set(1,"emp1")
employee.set(2,"emp2")
employee.set(3,"emp3")
employee.set([4,5],123)
employee.set("a",4)

console.log(employee)

for (var key of employee.keys()) {
    console.log(key)
}

for (var value of employee.values()) {
    console.log(value)
}

for (var entry of employee.entries()) {
    console.log(entry[0],entry[1])
}

console.log(employee.get(2))
console.log(employee.has(2))

employee.delete(2)
console.log(employee)
console.log(employee.size)
console.log(employee.clear())
console.log(employee)

var employee1:Map<any,any> = employee
console.log(employee1)

//set

var dataset:Set<any> = new Set()
dataset.add(11)
dataset.add(22)
dataset.add(33)
dataset.add("abc")

console.log(dataset)
console.log(dataset.size)
console.log(dataset.has(11))
console.log(dataset.has(15))
console.log(dataset.delete(11))
console.log(dataset)
console.log(dataset.clear())
console.log(dataset)

//date

var date:Date = new Date()
console.log(date)

date = new Date(50000000000)
console.log(date)

date = new Date("2019-02-16")
console.log(date)

console.log(date.getDate())
console.log(date.getFullYear())
console.log(date.getMonth())
console.log(date.getDay())
console.log(date.getHours())
console.log(date.getMinutes())
console.log(date.getSeconds())
console.log(date.getMilliseconds())
console.log(date.getTime())

date = new Date(2019,4,12,10,15,42,12)
console.log(date)

date.setDate(21)
date.setMonth(10)
date.setFullYear(2021)
date.setHours(4)
date.setMinutes(26)
date.setSeconds(50)

console.log(date)