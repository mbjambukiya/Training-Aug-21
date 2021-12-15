import { Component, Inject, OnInit } from '@angular/core';
import { EmployeeService, IEmployee } from '../employee.service'; 

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  constructor(@Inject(EmployeeService) private empService:EmployeeService) { }
  employees:IEmployee[]=[]

  ngOnInit(): void {
    this.employees=this.empService.getEmployees();
  }



}
