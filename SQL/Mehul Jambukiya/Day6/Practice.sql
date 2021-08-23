USE JOINPRACTICE

--Select employee details from employee table if data exists in incentive table ?

SELECT * FROM Employee WHERE EXISTS (SELECT * FROM Incentives WHERE Employee.Employee_Id = Incentives.Employee_Ref_Id)

--Find Salary of the employee whose salary is more than Roy Salary

SELECT First_Name, Salary FROM Employee WHERE Salary > (SELECT Salary FROM Employee WHERE First_Name='Roy')