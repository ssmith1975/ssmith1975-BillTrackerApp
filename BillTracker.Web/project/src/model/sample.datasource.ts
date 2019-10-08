import {Injectable} from "@angular/core";
import {Company} from "./company.model";
import {Observable, from} from "rxjs";

@Injectable()
export class SampleDataSource {
    private companies: Company[] = [
        new Company("Company 1", "111111", "123-345-1111", new Date("1/1/2019"),1),
        new Company("Company 2", "222222", "123-345-2222", new Date("2/2/2019"),2),
        new Company("Company 3", "333333", "123-345-3333", new Date("3/3/2019"),3)

    ];

    getCompanies(): Observable<Company[]>{
        return from([this.companies]);
    }
}

/*
        
        public Name:string,
        public AccountNumber:string,
        public Phone: string,
        public StartDate: Date,
        public CompanyID?:number
*/