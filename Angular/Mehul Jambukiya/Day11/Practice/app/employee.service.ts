import { Injectable } from '@angular/core';

export interface IEmployee{
  id:number
  name:string
}
@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor() { }

  employees:IEmployee[]=[
    {id:1,name:"emp1"},
    {id:2,name:"emp2"},
    {id:3,name:"emp3"}
  ]

  getEmployees():IEmployee[]{
    return this.employees
  }

  getEmployee(id:number){
    return this.employees.find(p=>p.id==id);
  }
}
