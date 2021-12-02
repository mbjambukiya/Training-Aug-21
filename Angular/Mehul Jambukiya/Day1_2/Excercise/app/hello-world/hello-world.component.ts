import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello-world',
  templateUrl: './hello-world.component.html',
  styleUrls: ['./hello-world.component.css']
})
export class HelloWorldComponent implements OnInit {
  name:string="Mehul"
  constructor() { }

  ngOnInit(): void {
  }
  setName(event:Event){
    this.name = (event.target as HTMLInputElement).value
  }

}
