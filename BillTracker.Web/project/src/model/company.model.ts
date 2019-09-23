export class Company {
    public CompanyID:number;
    
    constructor (
        public Name:string,
        public AccountNumber:string,
        public Phone: string,
        public StartDate: Date
    ){

    }
}