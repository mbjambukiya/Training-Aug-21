import { Component, OnInit } from '@angular/core';

type myAppUser={
  id:number
  name:string
  address:string
  panNumber:string
}
var id:number=0
@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent implements OnInit {
  users:myAppUser[]=[]
  user:myAppUser = {id:0,name:"",address:"",panNumber:""}
  name:string=""
  address:string=""
  panNumber:string=""
  constructor() { }

  ngOnInit(): void {
  }

  signUp(){
    this.user={id:id+1,name:this.name,address:this.address,panNumber:this.panNumber}
    this.users.push(this.user)
  }

}
