import { Component } from 'react';
import { Route, Link, NavLink, Redirect, Switch } from 'react-router-dom';

import style from './App.module.css';
import Header from './components/Header/Header';
import Players from './components/Players/Players';

/*function App() {
  return (
    <div className={style.app}>
      <Header />
    </div>
  );
}*/

class App extends Component {
  constructor(props) {
      super(props);

      this.state = {
          players: [],
      }

  }

  render() {
      return (
          <div className={style.app}>
              <Header />

              <div className={style.container}>
                  <Switch>
                      <Route path="/players" component={Players} />
                      <Route render={() => <h1 >Error Page</h1>} />
                  </Switch>
              </div>
          </div>
      );
  }
}

export default App;
