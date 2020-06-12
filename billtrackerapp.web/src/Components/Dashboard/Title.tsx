import React from 'react';
import PropTypes from 'prop-types';
import Typography from '@material-ui/core/Typography';
import { makeStyles } from '@material-ui/core/styles';

  const useStyles = makeStyles((theme) => ({
    greenText: {
      color: '#484'
    },
  }));

export default function Title(props:any ) {
const classes = useStyles();

  
  return (
    <Typography component="h2" variant="h6" className={classes.greenText} gutterBottom>
      {props.children}
    </Typography>
  );
}

Title.propTypes = {
  children: PropTypes.node,
};