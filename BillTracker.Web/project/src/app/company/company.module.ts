import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ModelModule } from '../../model/model.module';
import { CompanyRepository } from '../../model/company.repository';
import { CompanyComponent } from './company.component';

@NgModule({
  declarations: [CompanyComponent],
  imports: [
    CommonModule,ModelModule
  ],
  providers: [CompanyRepository],
  exports: [CompanyComponent]
})
export class CompanyModule { }
