import React, {useState,useEffect,MouseEvent} from 'react';
import Link from '@material-ui/core/Link';
import { makeStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Title from './Title';
import Invoice from '../../Models/Invoice';
import InvoiceService from '../../Services/InvoiceService';



function preventDefault(event: MouseEvent<HTMLButtonElement | HTMLAnchorElement>) {
  event.preventDefault();
}

const useStyles = makeStyles((theme) => ({
  seeMore: {
    marginTop: theme.spacing(3),
    color: '#484'
  },
}));

export default function Payments() {
  const classes = useStyles();

  const [data, setData] = useState([] as Array<Invoice>);
  useEffect(() => {
    const fetchData = async () => {
 
      var invoices= await InvoiceService.getInvoices(); ///result.data as Array<Invoice>;
      setData(invoices);
    };
  
    fetchData();
  }, []);

  return (
    <React.Fragment>
      <Title>Recent Invoices</Title>
      <Table size="small">
        <TableHead>
          <TableRow>
            <TableCell>Billing Period</TableCell>
            <TableCell>Due Date</TableCell>
            <TableCell>Amount Paid</TableCell>
            <TableCell align="right">Balance</TableCell>
            <TableCell>Date Paid</TableCell>
            <TableCell>Amount Due</TableCell>
            <TableCell>Confirmation Number</TableCell>
            <TableCell>Note</TableCell>
            <TableCell>Company ID</TableCell>

          </TableRow>
        </TableHead>
        <TableBody>
          {data.map((row) => (
            <TableRow key={row.invoiceID as number}>
              <TableCell>{row.billingPeriod}</TableCell>
              <TableCell>{row.dueDate}</TableCell>
              <TableCell>{row.amountPaid}</TableCell>
              <TableCell>{row.balance}</TableCell>
              <TableCell align="right">{row.datePaid}</TableCell>
            
              <TableCell>{row.amountDue}</TableCell>
              <TableCell>{row.confirmationNumber}</TableCell>
              <TableCell>{row.note}</TableCell>
              <TableCell>{row.companyID}</TableCell>
           </TableRow>
          ))}
        </TableBody>
      </Table>
      <div className={classes.seeMore}>
        <Link className={classes.seeMore} href="#" onClick={preventDefault}>
          See more invoices
        </Link>
      </div>
    </React.Fragment>
  );
}