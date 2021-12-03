import { Component, OnInit } from '@angular/core';

interface Student {
  id: number
  name: string
  age: number
  average: number
  grade: string
  active: boolean
}

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})

export class StudentListComponent implements OnInit {

  gradeWiseStyle: Record<string, string> = {
     'A+': 'text-success fw-bold', 
     'A': 'text-primary fw-bold', 
     'B': 'text-info fw-bold', 
     'C': 'text-warning fw-bold', 
     'D': 'text-danger fw-bold' 
    }

  students: Student[] = [
    { id: 1, name: "Akash", age: 15, average: 78, grade: "B", active: true },
    { id: 2, name: "Ramesh", age: 16, average: 80, grade: "B", active: false },
    { id: 3, name: "Suresh", age: 15, average: 85, grade: "A", active: true },
    { id: 4, name: "Prayag", age: 15, average: 91, grade: "A+", active: true },
    { id: 5, name: "Vinayak", age: 16, average: 60, grade: "C", active: true },
    { id: 6, name: "Prakash", age: 15, average: 36, grade: "D", active: true },
    { id: 7, name: "Vimal", age: 15, average: 36, grade: "C", active: false },
    { id: 8, name: "Dhrumil", age: 15, average: 36, grade: "A", active: true }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
