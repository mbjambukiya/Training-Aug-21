import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateStudentComponent } from './create-student/create-student.component';
import { DeleteStudentComponent } from './delete-student/delete-student.component';
import { EditStudentComponent } from './edit-student/edit-student.component';
import { HomeComponent } from './home/home.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { StudentListComponent } from './student-list/student-list.component';

const routes: Routes = [
  {path:'home',component:HomeComponent},
  {path:'add',component:CreateStudentComponent},
  {path:'delete/:id',component:DeleteStudentComponent},
  {path:'edit/:id',component:EditStudentComponent},
  {path:'get',component:StudentListComponent},
  {path:'',redirectTo:'home',pathMatch:"full"},
  {path:'**',component:PagenotfoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
