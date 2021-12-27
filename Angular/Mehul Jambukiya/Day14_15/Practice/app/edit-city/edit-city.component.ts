import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpCrudService } from '../http-crud.service';
import { ICity } from '../ICity';

@Component({
  selector: 'app-edit-city',
  templateUrl: './edit-city.component.html',
  styleUrls: ['./edit-city.component.css']
})
export class EditCityComponent implements OnInit {

  constructor(private route:ActivatedRoute,private apiService:HttpCrudService,private router:Router) { }

  id:number=0;
  city:ICity={} as ICity

  ngOnInit(): void {
    this.route.params.subscribe(params=>{
      this.id=params['id']
    })

    this.apiService.getCityById(this.id).subscribe(data=>{
      this.city=data
    });
  }

  editCity() {
    this.apiService.editCity(this.city).subscribe();
    this.router.navigate(["get"])
  }
}
