import { Component, OnInit, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';

import { QuestionBase } from '../question-base';


@Component({
  selector: 'app-dynamic-form-question',
  templateUrl: './dynamic-form-question.component.html',
  styleUrls: ['./dynamic-form-question.component.css']
})

export class DynamicFormQuestionComponent implements OnInit {

  @Input() question!: QuestionBase<string>;
  @Input() form!: FormGroup;

  get isValid() {
    return this.form.controls[this.question.key].valid;
  }
  get isTouched() {
    return this.form.controls[this.question.key].touched;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
