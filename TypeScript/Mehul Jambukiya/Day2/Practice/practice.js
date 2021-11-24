//class
var Employee = /** @class */ (function () {
    function Employee(id, name) {
        this.empId = id;
        this.empName = name;
    }
    Employee.prototype.getDetails = function () {
        console.log("EmployeeId : ".concat(this.empId, ", EmployeeName : ").concat(this.empName));
    };
    return Employee;
}());
var emp = new Employee(1, "testname");
emp.getDetails();
//tuple
var tuple1;
tuple1 = ["abc", 123];
console.log(tuple1);
var tuple2;
tuple2 = [["aa", 1], ["bb", 2]];
console.log(tuple2);
//union
var union1;
union1 = 123;
console.log(union1);
console.log(typeof (union1));
union1 = "abc";
console.log(union1);
console.log(typeof (union1));
// union1 = true; //error
//enum
var Week;
(function (Week) {
    Week[Week["Sunday"] = 0] = "Sunday";
    Week[Week["Monday"] = 1] = "Monday";
    Week[Week["Tuesday"] = 2] = "Tuesday";
    Week[Week["Wednesday"] = 3] = "Wednesday";
    Week[Week["Thursday"] = 4] = "Thursday";
    Week[Week["Friday"] = 5] = "Friday";
    Week[Week["Saturday"] = 6] = "Saturday";
})(Week || (Week = {}));
var day = Week.Monday;
console.log(day);
var Lion = /** @class */ (function () {
    function Lion(name) {
        this.Name = name;
    }
    Lion.prototype.AnimalSound = function (sound) {
        console.log("".concat(this.Name, " sounds ").concat(sound, "!"));
    };
    return Lion;
}());
var lion = new Lion("Gir-Lion");
lion.AnimalSound("Roar");
var kv1 = { key: "aa", value: "abc" };
console.log(kv1);
function addKeyValue(key, value) {
    console.log("addKeyValue : key = ".concat(key, ", value = ").concat(value));
}
var kvp = addKeyValue;
kvp(1, "aaa");
var numArr = [1, 2, 3];
console.log(numArr[1]);
var Employee1 = /** @class */ (function () {
    function Employee1(name, gender, employeeId) {
        this.name = name;
        this.gender = gender;
        this.employeeId = employeeId;
    }
    return Employee1;
}());
var employee = new Employee1("Satish", "male", 111);
console.log(employee);
console.log(employee.employeeId);
console.log(employee.name);
console.log(employee.gender);
//named function
function add(a, b) {
    return a + b;
}
console.log(add(2, 3));
//anonymous function
var sum = function (a, b) {
    return a + b;
};
console.log(sum(10, 15));
//lambda funcion
var addition = function (a, b) {
    return a + b;
};
console.log(addition(3, 4));
