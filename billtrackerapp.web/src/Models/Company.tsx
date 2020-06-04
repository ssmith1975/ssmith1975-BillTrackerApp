import Invoice from "./Invoice";
import Address from "./Address";
export default interface Company {
    CompanyID: Number;
    Name: String;
    AccountNumber: String;
    Phone: String;
    StartDate: Date;
    Invoices: Invoice[];
    Address: Address;
}