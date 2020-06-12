import React from 'react';
import ListItem from '@material-ui/core/ListItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';

import DashboardIcon from '@material-ui/icons/Dashboard'
import AssignmentIcon from '@material-ui/icons/Assignment';

import EventNoteIcon from '@material-ui/icons/EventNote';
import MonetizationOnIcon from '@material-ui/icons/MonetizationOn';
import BusinessIcon from '@material-ui/icons/Business';

function ListItemLink(props:any) {
  return <ListItem button component="a" {...props} />;
}

export const secondaryListItems = (
  <div>
    
     <ListItemLink href="/dashboard">
      <ListItemIcon>
        <DashboardIcon />
      </ListItemIcon>   
      <ListItemText primary="Dashboard" />
    </ListItemLink>  
       
    {/* <ListSubheader inset>Reports</ListSubheader> */}

    <ListItemLink href="/reports/monthly">
      <ListItemIcon>
        <EventNoteIcon />
      </ListItemIcon>
      <ListItemText primary="Reports By Month" />
      </ListItemLink>
    <ListItemLink href="/reports/company">
      <ListItemIcon>
        <AssignmentIcon />
      </ListItemIcon>
      <ListItemText primary="Reports By Company" />
      </ListItemLink>
   
  </div>
);

export const mainListItems = (
  <div>
    <ListItemLink href="/invoices">
      <ListItemIcon>
        <MonetizationOnIcon />
      </ListItemIcon>
      <ListItemText primary="Invoices" />
      </ListItemLink>
    <ListItemLink href="/companies">
      <ListItemIcon>
        <BusinessIcon />
      </ListItemIcon>
      <ListItemText primary="Companies" />
      </ListItemLink>
  </div>
);