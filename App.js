import './App.css';
import 'materialize-css/dist/css/materialize.min.css';
import 'materialize-css/dist/js/materialize.min.js';
import {BrowserRouter as Router, Route, Switch} from 'react-router-dom';
import Home from './components/Home';
import User from './components/User';
import Orders from './components/Orders';


function App() {
  return (
    <Router>
      <>
        <Route exact path ="/" component={Home} />
        <Switch>
          <Route exact path= "/orders" component={Orders}/>
          <Route path= "/user" component={User}/>
        </Switch>
      </>
    </Router>
  );
}

export default App;
