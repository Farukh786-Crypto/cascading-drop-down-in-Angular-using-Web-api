import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmployeeComponent } from './employee/employee.component';
import {HttpClientModule} from '@angular/common/http'
import { EmpService } from './employee/emp.service';
import { CascadingDropdownComponent } from './dropdown/cascading-dropdown/cascading-dropdown.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    CascadingDropdownComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
   
  ],
  providers: [EmpService],
  bootstrap: [AppComponent]
})
export class AppModule { }
