import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCityComponent } from './add-city/add-city.component';
import { CityListComponent } from './city-list/city-list.component';
import { EditCityComponent } from './edit-city/edit-city.component';

const routes: Routes = [
  {path:'add',component:AddCityComponent},
  {path:'get',component:CityListComponent},
  {path:'edit/:id',component:EditCityComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
