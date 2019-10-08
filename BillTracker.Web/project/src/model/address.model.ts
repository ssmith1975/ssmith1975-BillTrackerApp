export class Address {
  
    constructor(
        public StreetAddress1:String,
        public StreetAddress2:String = '',
        public City: String,
        public State: String,
        public Zip: String,
        public Country: String = 'US',
        public CompanyID: number,
        public AddressID?:number,
    ){}
}