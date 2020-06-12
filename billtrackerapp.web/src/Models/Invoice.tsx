export default interface Invoice {
    invoiceID: number;
    billingPeriod: Date;
    dueDate: Date;
    amountPaid: number;
    balance: number;
    datePaid: Date;
    amountDue: number;
    confirmationNumber: String;
    note: String;
    //Company: Company;
    companyID: number;


}

