export default interface Invoice {
    InvoiceID:Number;
    BillingPeriod: Date;
    DueDate: Date;
    AmountPaid: Number;
    Balance: Number;
    DatePaid: Date;
    AmountDue: Number;
    ConfirmationNumber: String;
    Note: String;
    //Company: Company;
    CompanyID: Number;


}

