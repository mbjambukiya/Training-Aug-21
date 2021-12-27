import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ApiServiceService } from '../api-service.service';

@Component({
  selector: 'app-student-list',
  templateUrl: './student-list.component.html',
  styleUrls: ['./student-list.component.css']
})
export class StudentListComponent implements OnInit {

  constructor(private apiService:ApiServiceService,private router:Router) { }

  studentList:any

  ngOnInit(): void {
    this.apiService.getStudents().subscribe(data=>{
      this.studentList = data
    })
  }

  editStudent(id:number){
    this.router.navigate(['edit',id])
  }

  deleteStudent(id:number){
    if(confirm("Are you sure to delete?")){
      this.router.navigate(['delete',id])
    }
  }
}
