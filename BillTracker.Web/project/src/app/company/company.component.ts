import { Component, OnInit } from '@angular/core';
import { CompanyRepository } from '../../model/company.repository';
import {Company} from '../../model/company.model';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.less']
})
export class CompanyComponent implements OnInit {
  public title:String = 'Company';
  constructor(private repository: CompanyRepository){

  }

  getCompanies():Company[]{
    return this.repository.getCompanies();
  }

  ngOnInit() {


  }

}
