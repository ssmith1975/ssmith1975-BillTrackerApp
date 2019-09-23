export class Address {
    public AddressID:number;
    
    constructor(
        public StreetAddress1:String,
        public StreetAddress2:String,
        public City: String,
        public State: String,
        public Zip: String,
        public Country: String,
        public CompanyID: number

    ){}
}