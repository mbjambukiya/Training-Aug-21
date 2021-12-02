import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  defUsername:string="admin"
  defPassword:string="admin"
  inpUsername:string=""
  inpPassword:string=""
  loginStatus:boolean=false
  constructor() { }

  ngOnInit(): void {
  }

  login(){
    if(this.inpUsername==this.defUsername && this.inpPassword==this.defPassword){
      this.loginStatus=true
    }
    else{
      this.loginStatus=false
    }
  }

}
