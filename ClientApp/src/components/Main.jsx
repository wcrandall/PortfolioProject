import React, { Component } from 'react';
import Project from './Project'; 

class Main extends Component {
    render() { 
        return ( 
            <main className="container">
                {this.props.projects.map((project) =>
                {
                    return <Project project={project} key={project.id}/>;
                })}
            </main>
         );
    }
}
 
export default Main;