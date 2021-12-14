import { Injectable ,Inject} from '@angular/core';
import { EmployeeService } from './employee.service';

@Injectable({
  providedIn: 'root'
})
export class EmployeeDataService {
  
  constructor(@Inject(EmployeeService) private employeeService:any) { }

  getEmployeesData(){
    return this.employeeService.getEmployees()
  }
}
