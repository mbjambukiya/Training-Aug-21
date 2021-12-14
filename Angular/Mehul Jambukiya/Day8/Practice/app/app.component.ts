import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'DataPassingPractice';
  name='';
  msg:string='';
  
  getMsg(msg:string){
    this.msg=msg
  }
}
