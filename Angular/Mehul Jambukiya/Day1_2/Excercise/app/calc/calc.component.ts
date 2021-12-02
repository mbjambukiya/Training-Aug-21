import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})

export class CalcComponent implements OnInit {
  operations: Array<string> = ['Addition', 'Subtraction', 'Multiplication', 'Division']
  num1: number = 0
  num2: number = 0
  result: number = 0
  operation: string = "operator"
  constructor() { }

  ngOnInit(): void {
  }

  Calculate(operation: string) {
    var index = this.operations.indexOf(operation)
    switch (index) {
      case 0:
        this.operation = '+'
        this.result = this.num1 + this.num2
        break
      case 1:
        this.operation = '-'
        this.result = this.num1 - this.num2
        break
      case 2:
        this.operation = '*'
        this.result = this.num1 * this.num2
        break
      case 3:
        this.operation = '/'
        this.result = this.num1 / this.num2
        break
      default:
        break
    }
  }
}
