import React, { Component } from 'react';
import './project.css'; 

class Project extends Component {
    render() { 
        const project = this.props.project; 

        return ( 
            <div>
                <h1 className="title">{project.title}</h1>
                <p>{project.description}</p>
                <p>{project.url}</p>
            </div>
         );
    }
}
 
export default Project;