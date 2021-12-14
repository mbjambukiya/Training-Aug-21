import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private employees:string[]=["emp1","emp2","emp3"]
  constructor() { }
  getEmployees(){
    return this.employees;
  }
}
