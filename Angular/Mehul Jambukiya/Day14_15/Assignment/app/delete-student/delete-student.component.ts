import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ApiServiceService } from '../api-service.service';

@Component({
  selector: 'app-delete-student',
  templateUrl: './delete-student.component.html',
  styleUrls: ['./delete-student.component.css']
})
export class DeleteStudentComponent implements OnInit {

  constructor(private apiService: ApiServiceService, private route: ActivatedRoute, private router: Router) { }

  studentId: number = 0

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.studentId = params['id']
    })

    this.apiService.deleteStudent(this.studentId).subscribe(data => {
      console.log(data)
      alert("Record deleted successfully!!")
      if(confirm("Want to check available records?")){
        this.router.navigate(['get'])
      }
    })
  }

}
