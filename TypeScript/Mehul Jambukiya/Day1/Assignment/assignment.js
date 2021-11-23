// Store 5 employees’ data in one array(ID, FirstName, LastName, Address, Salary).
// Do the operation searching by indexnumber, EmployeeID, Insert the employee, delete the 
// employee from the Array.Create one more array emp and join the value with above array.
// When display list combine firstname and lastname as fullname, From the address field
// flatnumber, city, state and should be splited.PF should be computed and total salary 
// should be display.
var EmployeeData1 = [
    { EmployeeId: 1, FirstName: "Harsh", LastName: "Varma", Address: "11,Abc Street,Ahmedabad,Gujarat", Salary: 50000 },
    { EmployeeId: 2, FirstName: "Pritesh", LastName: "Patel", Address: "17,Xyz Street,Surat,Gujarat", Salary: 45000 },
    { EmployeeId: 3, FirstName: "Hemanshu", LastName: "Chauhan", Address: "07,J.K.Road,Baroda,Gujarat", Salary: 40000 },
    { EmployeeId: 4, FirstName: "Harshad", LastName: "Parikh", Address: "23,V.N.Road,Baroda,Gujarat", Salary: 40000 },
    { EmployeeId: 5, FirstName: "Keyur", LastName: "Shah", Address: "44,M.G.Road,Mumbai,Maharashtra", Salary: 70000 }
];
var EmployeeData2 = [
    { EmployeeId: 6, FirstName: "Krunal", LastName: "Patel", Address: "15,Abc Street,Ahmedabad,Gujarat", Salary: 50000 },
    { EmployeeId: 7, FirstName: "Vishal", LastName: "Paarikh", Address: "12,Xyz Street,Surat,Gujarat", Salary: 42000 },
    { EmployeeId: 8, FirstName: "Vinod", LastName: "Patel", Address: "04,J.K.Road,Baroda,Gujarat", Salary: 41000 },
    { EmployeeId: 9, FirstName: "Dhrumil", LastName: "Shah", Address: "27,V.N.Road,Baroda,Gujarat", Salary: 40000 },
    { EmployeeId: 10, FirstName: "Jayesh", LastName: "Chauhan", Address: "41,M.G.Road,Mumbai,Maharashtra", Salary: 72000 }
];
var AllEmployeesData = EmployeeData1.concat(EmployeeData2);
function GetEmployeesData() {
    EmployeeData1.forEach(function (employee) {
        console.log("\nEmployeeId : ".concat(employee.EmployeeId));
        console.log("Name : ".concat(employee.FirstName, " ").concat(employee.LastName));
        console.log("Address : ".concat(employee.Address.split(",").toString()));
        console.log("PF : ".concat(employee.Salary * 0.12));
        console.log("Salary : ".concat(employee.Salary));
    });
}
function SearchEmployeeByIndex(index) {
    if (index < EmployeeData1.length) {
        return EmployeeData1[index];
    }
    else {
        return undefined;
    }
}
function SearchEmployeeByEmployeeId(empoleeId) {
    for (var i in EmployeeData1) {
        if (EmployeeData1[i].EmployeeId == empoleeId) {
            return EmployeeData1[i];
        }
    }
    return undefined;
}
function AddEmployee(employee) {
    if (EmployeeData1.push(employee) > 0) {
        return true;
    }
    else {
        return false;
    }
}
function DeleteEmployee(employeeId) {
    for (var i = 0; i < EmployeeData1.length; i++) {
        if (EmployeeData1[i].EmployeeId == employeeId) {
            EmployeeData1.splice(i, 1);
            return true;
        }
    }
    return false;
}
console.log("\n1.GetEmployeesData\n2.SearchEmployeeByIndex\n3.SearchEmployeeByEmployeeId\n4.AddEmployee\n5.DeleteEmployee");
var choice = 1;
var employee = undefined;
var index = undefined;
var employeeId = undefined;
var result = undefined;
switch (choice) {
    case 1:
        GetEmployeesData();
        break;
    case 2:
        index = 1;
        employee = SearchEmployeeByIndex(index);
        console.log(employee);
        break;
    case 3:
        employeeId = 1;
        employee = SearchEmployeeByEmployeeId(employeeId);
        console.log(employee);
        break;
    case 4:
        employee = {
            EmployeeId: 11,
            FirstName: "Avinash",
            LastName: "Patel",
            Address: "20,V.N.Road,Baroda,Gujarat",
            Salary: 43000
        };
        result = AddEmployee(employee);
        if (result == true) {
            console.log("Employee data added successfully!!");
            GetEmployeesData();
        }
        else {
            console.log("Something went wrong! Please try again!");
        }
        break;
    case 5:
        employeeId = 3;
        result = DeleteEmployee(employeeId);
        if (result == true) {
            console.log("Employee data deleted successfully!!");
            GetEmployeesData();
        }
        else {
            console.log("Something went wrong! Please try again!");
        }
        break;
    default:
        console.log("Invalid Choice!!");
}
