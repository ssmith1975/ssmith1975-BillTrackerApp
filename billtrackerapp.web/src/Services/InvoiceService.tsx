import axios from 'axios';
import Invoice from '../Models/Invoice';

const rootUrl = 'https://billtrackerapp.azurewebsites.net/api';


const InvoiceService = {
    getInvoices:  async () => {
        const result = await axios(
           `${rootUrl}/invoices`,
        );
        
        return result.data as Array<Invoice>;  
    }  
};

export default InvoiceService;
