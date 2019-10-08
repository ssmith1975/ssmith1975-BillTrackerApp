export class Invoice {

    constructor(
        public BillingPeriod: Date,
        public DueDate: Date,
        public AmountPaid: number,
        public Balance: number,
        public DatePaid:Date,
        public AmountDue: number,
        public ConfirmationNumber: String,
        public Note: String,
        public InvoiceID?: number
    ){}
}