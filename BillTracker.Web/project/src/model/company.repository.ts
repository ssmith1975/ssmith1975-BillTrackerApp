import {Injectable} from "@angular/core";
import {Company} from "./company.model";
import {SampleDataSource} from "./sample.datasource";

@Injectable()
export class CompanyRepository {
    private companies: Company[];

    constructor(private dataSource: SampleDataSource){
        dataSource.getCompanies().subscribe(data =>{
            this.companies = <Company[]>(data);
        });
    }

    getCompanies(){
        return this.companies;
    }
    getCompany(CompanyID:number){
        return this.companies.find(c => c.CompanyID == CompanyID);
    }
}
