import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {CompanyRepository} from './company.repository';
import {SampleDataSource} from './sample.datasource';


@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  providers: [CompanyRepository, SampleDataSource]
})
export class ModelModule { }
