import React, { Component } from 'react';
import NavBar from './components/NavBar';
import Main from './components/Main'; 
import Footer from './components/Footer'; 
import './custom.css';

export default class App extends Component {
  state = { 
    pageUrls : [{id: 1, url:"about", name : "About", isActive: true},
                {id:2, url:"projects", name : "Projects", isActive: false},
                {id:3, url:"contact", name:"Contact me", isActive : false}], 
    projects : []
  }; 

  componentDidMount = () =>{
      fetch("https://localhost:5001/api/projects/")
      .then(res=>res.json())
      .then((result) =>{
        this.setState({projects: result})
      });
  };

  render () {
    return (
        <React.StrictMode>
          <NavBar pageUrls={this.state.pageUrls}/>
          <Main projects={this.state.projects}/>
          <Footer/>
        </React.StrictMode>
    );
  }
}
