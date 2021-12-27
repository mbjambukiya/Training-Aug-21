import { Component, OnInit } from '@angular/core';
import { HttpCrudService } from '../http-crud.service';
import { ICity } from '../ICity';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {

  constructor(private crudOp: HttpCrudService) { }
  citiList: ICity[] = []
  id: number = 7;
  city: any = {
    "Id": 7,
    "CityName": "Rajkot-Modified",
    "StateId": 1
  }
  ngOnInit(): void {
    // this.crudOp.getCityById(this.id);
    // this.crudOp.addCity(this.city);
    // this.crudOp.editCity(this.city);
    // this.crudOp.deleteCity(this.id);
  }

  getData() {
    console.log("hello1")
    this.crudOp.getAllCity().subscribe(data => {
      this.citiList = data
      console.log(this.citiList)
    });
  }

}
