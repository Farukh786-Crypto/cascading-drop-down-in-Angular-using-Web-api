import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CascadingDropdownComponent } from './dropdown/cascading-dropdown/cascading-dropdown.component';
import { EmployeeComponent } from './employee/employee.component';

const routes: Routes = [
    {path:'create-employee',component:EmployeeComponent},
    {path:'dropdown',component:CascadingDropdownComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
