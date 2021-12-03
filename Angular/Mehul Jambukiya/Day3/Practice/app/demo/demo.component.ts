import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
  hasBackground:boolean=true
  // demoStyle ={'border':'2px solid red'}
  demoStyle ={'width.px':'200','background-color':'green'}
  userName:string=""
  product:string="mobile"
  products:string[]=["monitor","cpu","mouse","keyboard"]
  isActive:boolean=true
  choice:number=5
  constructor() { }

  ngOnInit(): void {
  }

}
