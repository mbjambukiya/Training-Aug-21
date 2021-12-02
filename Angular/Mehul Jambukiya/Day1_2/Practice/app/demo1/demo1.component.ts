import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
  allowClick:boolean = false
  serverCreated:boolean = false
  serverId:number=15
  serverName:string="Test"
  serverStatus:string="available"
  constructor() { 
    setTimeout(() => {
      this.allowClick = true
    }, 3000);
  }

  ngOnInit(): void {
  }

  addServer(){
    this.serverCreated=true
  }

  getColor(){
    return this.serverStatus=="available"?"green":"red"
  }

  getServerStatus(){
    return this.serverStatus
  }
  updateServer(event:Event){
    this.serverName = (event.target as HTMLInputElement).value
  }

}
