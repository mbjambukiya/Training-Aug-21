import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.css']
})
export class EmployeeDetailsComponent implements OnInit {

  constructor(
    private _activatedRoute: ActivatedRoute,
    private _router: Router,
    @Inject(EmployeeService) private empService: EmployeeService
  ) { }

  employee: any
  id: any
  ngOnInit(): void {
    this._activatedRoute.paramMap.subscribe(data => {
      this.id = data.get('id');
      this.employee = this.empService.getEmployee(this.id);
    })
  }
  
}
