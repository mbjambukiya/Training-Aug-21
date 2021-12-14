import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-greetings',
  templateUrl: './greetings.component.html',
  styleUrls: ['./greetings.component.css']
})
export class GreetingsComponent implements OnInit {
  @Input() Name: string = ''
  @Output() msgnotify = new EventEmitter<string>();
  message: string = "Good Morning"

  sendMsg() {
    this.msgnotify.emit(this.message+" "+this.Name+"!!");
  }
  constructor() { }

  ngOnInit(): void {
  }

}