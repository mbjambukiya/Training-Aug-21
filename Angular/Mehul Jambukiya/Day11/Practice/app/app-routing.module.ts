import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeDetailsComponent } from './employee-details/employee-details.component';
import { EmployeeRatingsComponent } from './employee-ratings/employee-ratings.component';
import { EmployeeComponent } from './employee/employee.component';

const routes: Routes = [
  {
    path: 'employees', component: EmployeeComponent,
    children: [
      {
        path: 'detail/:id', component: EmployeeDetailsComponent,
        children: [
          {
            path: 'ratings/:id', component: EmployeeRatingsComponent,
          }
        ]
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
