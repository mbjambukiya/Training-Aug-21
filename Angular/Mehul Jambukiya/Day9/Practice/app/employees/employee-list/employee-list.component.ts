import { Component, OnInit} from '@angular/core';
import { EmployeeDataService } from '../employee-data.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  constructor(private employeeDstaService:EmployeeDataService) { }

  ngOnInit(): void {
    var emps = this.employeeDstaService.getEmployeesData();
    console.log(emps);
  }
}
