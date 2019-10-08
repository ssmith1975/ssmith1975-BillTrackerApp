import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {CompanyComponent} from './company/company.component';

const routes: Routes = [ 
    { path: '', redirectTo: '/', pathMatch: 'full' },
    { path: 'companies', component: CompanyComponent }
  
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
