import React, { Component } from 'react';
import NavBar from './components/NavBar';
import Main from './components/Main'; 
import Footer from './components/Footer'; 
import './custom.css'

export default class App extends Component {
  render () {
    return (
        <React.StrictMode>
          <NavBar/>
          <Main/>
          <Footer/>
        </React.StrictMode>
    );
  }
}
