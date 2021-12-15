import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-employee-ratings',
  templateUrl: './employee-ratings.component.html',
  styleUrls: ['./employee-ratings.component.css']
})
export class EmployeeRatingsComponent implements OnInit {

  constructor(private _activatedRoute: ActivatedRoute,) { }
  id: any
  ngOnInit(): void {
    this._activatedRoute.paramMap.subscribe(data => {
      this.id = data.get('id');
    })
  }
}
