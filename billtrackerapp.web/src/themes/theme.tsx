import { createMuiTheme, Theme } from '@material-ui/core/styles';
import indigo from '@material-ui/core/colors/indigo';
import purple from '@material-ui/core/colors/purple';
import green from '@material-ui/core/colors/green';



const customTheme = (theme:any):Theme => createMuiTheme({
    ...theme,
    palette: {
      primary: green,
      secondary: indigo, // Indigo is probably a good match with pink
      sugar : {
        backgroundColor: purple[500], 
        color: '#000'
      }
    },
    overrides:{
        MuiAppBar:{
          zIndex: `${theme.zIndex.drawer + 1}`,
          transition: `${theme.transitions.create(['width', 'margin'], {
            easing: theme.transitions.easing.sharp,
            duration: theme.transitions.duration.leavingScreen,
          })}`,
        },
        MuiToolbar:{
           root:{
              paddingRight: 24,
               color:'white'
           } 
        }
    }
  });

export default customTheme;