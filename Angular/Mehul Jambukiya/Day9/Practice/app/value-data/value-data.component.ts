import { Component, OnInit } from '@angular/core';
import {ValueDataServiceService} from '../value-data-service.service';
 
@Component({
  selector: 'app-value-data',
  templateUrl: './value-data.component.html',
  styleUrls: ['./value-data.component.css']
})
export class ValueDataComponent implements OnInit {

  constructor(private apiService:ValueDataServiceService) { }

  ngOnInit(): void {

  }

  invokeApi(){
    this.apiService.get();
  }

}
