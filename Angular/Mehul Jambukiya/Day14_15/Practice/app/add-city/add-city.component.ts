import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { HttpCrudService } from '../http-crud.service';

@Component({
  selector: 'app-add-city',
  templateUrl: './add-city.component.html',
  styleUrls: ['./add-city.component.css']
})
export class AddCityComponent implements OnInit {

  constructor(private apiService: HttpCrudService, private fb: FormBuilder,private router:Router) { }

  ngOnInit(): void {
  }

  city = this.fb.group({
    cityName: [''],
    stateId: ['']
  })

  onSubmit() {
    this.apiService.addCity(this.city.value).subscribe(res=>{
      if(res == true){
        this.router.navigate(["get"])
      }
      else{
        alert("something went wrong!!!")
      }
    });
  }
}
