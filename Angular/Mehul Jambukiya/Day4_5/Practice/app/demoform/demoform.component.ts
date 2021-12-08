import { Component, OnInit } from '@angular/core';
import {FormControl,FormGroup,FormBuilder,FormArray, Validators, AbstractControl} from '@angular/forms'


interface Subject{
  subId:number
  subName:string
}

interface Student{
  id:number
  name:string
  marks:number
  subject:Subject
}


@Component({
  selector: 'app-demoform',
  templateUrl: './demoform.component.html',
  styleUrls: ['./demoform.component.css']
})
export class DemoformComponent implements OnInit {

  constructor( private f:FormBuilder) { 
  }
  
  ngOnInit(): void {
  }

  
  stuForm:FormGroup = this.f.group({
    id:0,
    name:'',
    marks:0,
    subject:this.f.group({
      subId:0,
      subName:''
    })
    })
  
  

  //forms-basics

  // firstName = new FormControl('')

  // updateName(){
  //   this.firstName.setValue('Default')
  // }

  // myProfile = new FormGroup({
  //   firstName:new FormControl(''),
  //   lastName:new FormControl(''),
  //   address:new FormGroup({
  //     city:new FormControl(''),
  //     state:new FormControl('')
  //   })
  // });

  myProfile = this.f.group({
    firstName: ['',[Validators.required,Validators.minLength(4)]],
    lastName: [''],
    address: this.f.group({
      city: [''],
      state: ['']
    }),
    skills:this.f.array([
      this.f.control('')
    ])
  })

  get skills(){
    return this.myProfile.get('skills') as FormArray;
  }

  addSkill(){
    this.skills.push(this.f.control(''))
  }

  onSubmit() {
    console.log(this.myProfile.value);
  }

  get firstName(){
    return this.myProfile.get('firstName')
  }

}