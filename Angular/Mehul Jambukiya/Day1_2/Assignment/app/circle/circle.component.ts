import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-circle',
  templateUrl: './circle.component.html',
  styleUrls: ['./circle.component.css']
})
export class CircleComponent implements OnInit {

  radius:number=0
  area:number=0
  constructor() { }

  ngOnInit(): void {
  }
  getArea(){
    this.area=3.14*this.radius*this.radius
  }

}
