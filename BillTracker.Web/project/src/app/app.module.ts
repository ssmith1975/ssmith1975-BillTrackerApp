import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { CompanyModule} from './company/company.module';
//import {CompanyComponent} from '../company/company.component';

@NgModule({
  declarations: [
    AppComponent//, CompanyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    CompanyModule
   
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }