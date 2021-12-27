import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpCrudService } from '../http-crud.service';
import { ICity } from '../ICity';

@Component({
  selector: 'app-city-list',
  templateUrl: './city-list.component.html',
  styleUrls: ['./city-list.component.css']
})
export class CityListComponent implements OnInit {

  constructor(private apiService: HttpCrudService,private router:Router) { }

  cityList: ICity[] = []

  ngOnInit(): void {
    this.apiService.getAllCity().subscribe(data => {
      this.cityList = data
    })
  }

  editCity(id: number) {
    this.router.navigate(["edit",id])
  }

  deleteCity(id: number) {
    this.apiService.deleteCity(id).subscribe(res=>{
        this.router.navigate(["get"])
    })
  }
}
