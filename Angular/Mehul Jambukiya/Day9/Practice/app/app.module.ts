import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms'

import { AppComponent } from './app.component';
import { EmployeeListComponent } from './employees/employee-list/employee-list.component';
import { EmployeeService } from './employees/employee.service';
import { API_URL, ValueDataServiceService } from './value-data-service.service';
import { ValueDataComponent } from './value-data/value-data.component';
import { ObervableDemoComponent } from './obervable-demo/obervable-demo.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeListComponent,
    ValueDataComponent,
    ObervableDemoComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [
    EmployeeService,
    { provide: ValueDataServiceService, useClass: ValueDataServiceService },
    { provide: API_URL, useValue: 'http://localhost:4200/' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
